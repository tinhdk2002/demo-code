using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhHocPhi
{

    public partial class QuanLySinhVien : Form
    {
        
        public QuanLySinhVien()
        {
           
            InitializeComponent();
            LoadSinhVien();
        }
        void LoadSinhVien()
        {
            string query = "Select MaSV,HoTen,NgaySinh,DiaChi From SinhVien";
            DataProvider dataProvider = new DataProvider();
            dtgvSV.DataSource = dataProvider.ExecuteQuery(query);
            this.dtgvSV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        void RefreshSinhVien()
        {
            txtDiaChiSinhVien.Text = "";
            txtMaSV.Text = "";
            txtTenSV.Text = "";
        }
        private void dtgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex > -1)
            {
                row = dtgvSV.Rows[e.RowIndex];
                txtMaSV.Text = Convert.ToString(row.Cells["MaSV"].Value);
                txtTenSV.Text = Convert.ToString(row.Cells["HoTen"].Value);
                txtDiaChiSinhVien.Text = Convert.ToString(row.Cells["DiaChi"].Value);
                dTPNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            }
        }
        public bool KTThongTinSinhVien()
        {
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Chưa có thông tin mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSV.Focus();
                return false;
            }
            if (txtTenSV.Text == "")
            {
                MessageBox.Show("Chưa có thông tin họ tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSV.Focus();
                return false;
            }
            if (txtDiaChiSinhVien.Text == "")
            {
                MessageBox.Show("Chưa có thông tin địa chỉ của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChiSinhVien.Focus();
                return false;
            }
            
            return true;
        }
       
        private void btnAddSV_Click(object sender, EventArgs e)
        {
            if (KTThongTinSinhVien())
            {
                try
                {
                    string sql = "INSERT INTO SinhVien(MaSV,HoTen,DiaChi,NgaySinh)VALUES (";
                    sql += "'" + txtMaSV.Text + "',N'" + txtTenSV.Text + "',N'" + txtDiaChiSinhVien.Text+ "','" +dTPNgaySinh.Value.ToString("dd/MM/yyyy") + "')";
                    string con = "Data Source=.\\sqlexpress;Initial Catalog=TinhHocPhi;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(con);
                    connection.Open();
                     SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    LoadSinhVien();
                    MessageBox.Show("Đã thêm mới sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelSV_Click(object sender, EventArgs e)
        {
            if (KTThongTinSinhVien())
            {
                try
                {
                    string sql = "DELETE FROM SinhVien WHERE ";
                    sql += "MaSV = '"+  txtMaSV.Text + "'";
                    string con = "Data Source=.\\sqlexpress;Initial Catalog=TinhHocPhi;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(con);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    LoadSinhVien();
                    RefreshSinhVien();
                    MessageBox.Show("Đã xóa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdateSV_Click(object sender, EventArgs e)
        {
            if (KTThongTinSinhVien())
            {
                try
                {
                    string sql = "UPDATE SinhVien SET MaSV = '" + txtMaSV.Text +"',HoTen = N'"+ txtTenSV.Text +"',DiaChi = N'" + txtDiaChiSinhVien.Text+ "',NgaySinh = '"+ dTPNgaySinh.Value.ToString("MM/dd/yyyy")+ "' Where MaSV = '"+ txtMaSV.Text +"'";
                    string con = "Data Source=.\\sqlexpress;Initial Catalog=TinhHocPhi;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(con);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    LoadSinhVien();
                    RefreshSinhVien();
                    MessageBox.Show("Đã sửa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
