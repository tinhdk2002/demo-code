using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhHocPhi
{
    public partial class QuanLyMonSinhVienDangKy : Form
    {
        string maHocPhan;
        public QuanLyMonSinhVienDangKy()
        {
            InitializeComponent();
            LoadComboSV();
            LoadComboHocKy();
            LoadDangKyMon();
        }
        void LoadComboSV()
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=TinhHocPhi;Integrated Security=True");
            // Viết truy vấn SQL để lấy dữ liệu từ bảng
            string query = "SELECT MaSV,HoTen FROM SinhVien";

            // Sử dụng SqlDataAdapter để đổ dữ liệu từ truy vấn vào DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Thiết lập DataSource và DisplayMember của ComboBox để hiển thị dữ liệu từ DataTable lên ComboBox
            cbMaSinhVien.DataSource = dataTable;
            cbMaSinhVien.DisplayMember = "MaSV";
        }
        void LoadComboHocKy()
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=TinhHocPhi;Integrated Security=True");
            // Viết truy vấn SQL để lấy dữ liệu từ bảng
            string query = "SELECT DISTINCT HocKy FROM HocPhanSinhVienDangKy";

            // Sử dụng SqlDataAdapter để đổ dữ liệu từ truy vấn vào DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Thiết lập DataSource và DisplayMember của ComboBox để hiển thị dữ liệu từ DataTable lên ComboBox
            cbHocKy.DataSource = dataTable;
            cbHocKy.DisplayMember = "HocKy";
        }

        void LoadDangKyMon()
        {
            flpDangKy.Controls.Clear();
            List<HocPhan> tablelist = new();
            DataProvider provider = new();
            DataTable data = provider.ExecuteQuery("select * from dbo.HocPhan ");


            foreach (DataRow item in data.Rows)
            {
                HocPhan table = new(item);
                tablelist.Add(table);
            }

            foreach (HocPhan table in tablelist)
            {
                Button btn = new() { Width = 150, Height = 120};
                btn.Text = table.ma + Environment.NewLine + table.ten;
                btn.Click += Btn_Click;
                btn.Tag = table;
                flpDangKy.Controls.Add(btn);
            }
        }
        void LoadHocPhi()
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=TinhHocPhi;Integrated Security=True";
            string tableName = "HocPhi";
            int rowCount = 0;
            SqlCommand command;
            // Tạo đối tượng kết nối SqlConnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();

                // Kiểm tra số lượng bản ghi trong bảng
                using (command = new SqlCommand("SELECT COUNT(*) FROM " + tableName +" WHERE HocKy =N'"+cbHocKy.Text+"' and MaSV = '"+cbMaSinhVien.Text+"'", connection))
                {
                    rowCount = (int)command.ExecuteScalar();
                    connection.Close();
                }

                // Nếu bảng có dữ liệu, thực hiện update
                if (rowCount > 0)
                {
                    command = new SqlCommand
                    {
                        CommandText = "dbo.usp_UpdateTongSoTien",
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.Clear();
                    command.Parameters.Add("@masv", SqlDbType.NChar).Value = cbMaSinhVien.Text;
                    command.Parameters.Add("@hocky", SqlDbType.NVarChar).Value = cbHocKy.Text;
                    command.Parameters.Add("@status", SqlDbType.NChar).Value = "CHUA_THU";
                    command.Connection = connection;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                // Nếu bảng không có dữ liệu, thực hiện insert
                else
                {
                    command = new SqlCommand
                    {
                        CommandText = "dbo.usp_GetTongSoTien",
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.Clear();
                    command.Parameters.Add("@masv", SqlDbType.NChar).Value = cbMaSinhVien.Text;
                    command.Parameters.Add("@hocky", SqlDbType.NVarChar).Value = cbHocKy.Text;
                    command.Parameters.Add("@status", SqlDbType.NChar).Value = "CHUA_THU";
                    command.Connection = connection;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            maHocPhan = ((sender as Button).Tag as HocPhan).ma;
            string sql = "declare @a int; select @a = count(MaSV) from HocPhanSinhVienDangKy Where MaSV = '"+cbMaSinhVien.Text + "' and MaHP = '"+maHocPhan+"' and HocKy = N'"+cbHocKy.Text+"' if (@a = 0) insert into HocPhanSinhVienDangKy(HocKy, MaHP, MaSV) Values(";
            sql += "N'" + cbHocKy.Text + "','" + maHocPhan+ "','" + cbMaSinhVien.Text + "')";
            string con = "Data Source=.\\sqlexpress;Initial Catalog=TinhHocPhi;Integrated Security=True";
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã thêm môn học cho sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadHocPhi();
        }
        void LoadThongTinHK()
        {

            string query = "SELECT dbo.HocPhanSinhVienDangKy.MaHP, dbo.HocPhan.TenHP, dbo.HocPhan.TinChiHP, dbo.HocPhan.HeSoHP FROM dbo.HocPhan INNER JOIN dbo.HocPhanSinhVienDangKy ON dbo.HocPhan.MaHP = dbo.HocPhanSinhVienDangKy.MaHP Where dbo.HocPhanSinhVienDangKy.HocKy = N'"+ cbHocKy.Text + "' and dbo.HocPhanSinhVienDangKy.MaSV = '"+cbMaSinhVien.Text+"'";
            DataProvider dataProvider = new DataProvider();
            dtgvXemMonDangKy.DataSource = dataProvider.ExecuteQuery(query);
            this.dtgvXemMonDangKy.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btnXemMonDangKy_Click(object sender, EventArgs e)
        {
            flpDangKy.Hide();
            panelXemMonHoc.Show();
            if(cbHocKy.Text == "")
            {
                MessageBox.Show("Chưa có thông tin học kỳ của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbHocKy.Focus();
            }
            else
            {
                LoadThongTinHK();
            }    
        }

        private void btnDangKyMon_Click(object sender, EventArgs e)
        {
            panelXemMonHoc.Hide();
            flpDangKy.Show();
        }

        private void dtgvXemMonDangKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
