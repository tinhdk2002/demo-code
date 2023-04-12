using System.Data;
using System.Data.SqlClient;

namespace TinhHocPhi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadcbHPSV();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quảnLýHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHocPhan quanLyHocPhan = new QuanLyHocPhan();
            quanLyHocPhan.ShowDialog();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySinhVien quanLySinhVien = new QuanLySinhVien();
            quanLySinhVien.ShowDialog();
        }

        private void quảnLýMônĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyMonSinhVienDangKy quanLyMonSinhVienDangKy = new QuanLyMonSinhVienDangKy();
            quanLyMonSinhVienDangKy.ShowDialog();
        }
        void LoadcbHPSV()
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=TinhHocPhi;Integrated Security=True");
            // Viết truy vấn SQL để lấy dữ liệu từ bảng
            string query = "SELECT MaSV,HoTen FROM SinhVien";

            // Sử dụng SqlDataAdapter để đổ dữ liệu từ truy vấn vào DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Thiết lập DataSource và DisplayMember của ComboBox để hiển thị dữ liệu từ DataTable lên ComboBox
            cbHPSV.DataSource = dataTable;
            cbHPSV.DisplayMember = "MaSV";
        }
        void LoadDTGVHP()
        {
            string query = "SELECT HocKy,SoTien,TinhTrang FROM [TinhHocPhi].[dbo].[HocPhi] WHere MaSV = '"+cbHPSV.Text+"'";
            DataProvider dataProvider = new DataProvider();
            dtgvHP.DataSource = dataProvider.ExecuteQuery(query);
            this.dtgvHP.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btnXemHP_Click(object sender, EventArgs e)
        {
            LoadDTGVHP();
        }

        private void thiếtLậpMứcĐơnVịPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThietLapMucDonViHocPHi thietLapMucDonViHocPHi  = new ThietLapMucDonViHocPHi();
            thietLapMucDonViHocPHi.ShowDialog();
        }
    }
}
