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
    public partial class QuanLyHocPhan : Form
    {
        public QuanLyHocPhan()
        {
            InitializeComponent();
            LoadHP();
        }
        void LoadHP()
        {
            string query = "Select MaHP,TenHP,TinChiHP,HeSoHP From HocPhan";
            DataProvider dataProvider = new DataProvider();
            dtgvHocPhan.DataSource = dataProvider.ExecuteQuery(query);
            this.dtgvHocPhan.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        void RefreshHP()
        {
            txtMaHP.Text = "";
            txtHeSoHP.Text = "";
            txtTenHP.Text = "";
            txtTinChiHP.Text = "";
        }
        private void dtgvHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex > -1)
            {
                row = dtgvHocPhan.Rows[e.RowIndex];
                txtMaHP.Text = Convert.ToString(row.Cells["MaHP"].Value);
                txtTenHP.Text = Convert.ToString(row.Cells["TenHP"].Value);
                txtTinChiHP.Text = Convert.ToString(row.Cells["TinChiHP"].Value);
                txtHeSoHP.Text = Convert.ToString(row.Cells["HeSoHP"].Value);
            }

        }
        
        public bool KTThongTinHP()
        {
            if (txtMaHP.Text == "")
            {
                MessageBox.Show("Chưa có thông tin mã học phần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHP.Focus();
                return false;
            }
            if (txtTenHP.Text == "")
            {
                MessageBox.Show("Chưa có thông tin tên học phần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHP.Focus();
                return false;
            }
            if (txtTinChiHP.Text == "")
            {
                MessageBox.Show("Chưa có thông tin tín chỉ của học phần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTinChiHP.Focus();
                return false;
            }
            if (txtHeSoHP.Text == "")
            {
                MessageBox.Show("Chưa có thông tin hệ số của học phần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHeSoHP.Focus();
                return false;
            }

            return true;
        }
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (KTThongTinHP())
            {
                try
                {
                    string sql = "INSERT INTO HocPhan(MaHP,TenHP,TinChiHP,HeSoHP)VALUES (";
                    sql += "'" + txtMaHP.Text + "',N'" + txtTenHP.Text + "', " + txtTinChiHP.Text + ", " + txtHeSoHP.Text+")";
                    string con = "Data Source=.\\sqlexpress;Initial Catalog=TinhHocPhi;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(con);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    LoadHP();
                    MessageBox.Show("Đã thêm mới học phần thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnDelCourse_Click(object sender, EventArgs e)
        {
            if (KTThongTinHP())
            {
                try
                {
                    string sql = "DELETE FROM HocPhan WHERE ";
                    sql += "MaHP = '" + txtMaHP.Text + "'";
                    string con = "Data Source=.\\sqlexpress;Initial Catalog=TinhHocPhi;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(con);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    LoadHP();
                    RefreshHP();
                    MessageBox.Show("Đã xóa học phần thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            if (KTThongTinHP())
            {
                try
                {
                    string sql = "UPDATE HocPhan SET MaHP = '" + txtMaHP.Text + "',TenHP = N'" + txtTenHP.Text + "',TinChiHP = " + txtTinChiHP.Text + ", HeSoHP = " + txtHeSoHP.Text + " Where MaHP = '" + txtMaHP.Text + "'";
                    string con = "Data Source=.\\sqlexpress;Initial Catalog=TinhHocPhi;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(con);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    LoadHP();
                    RefreshHP();
                    MessageBox.Show("Đã sửa học phần thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
    }
}
