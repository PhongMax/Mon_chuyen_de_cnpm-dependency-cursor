using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonChuyenDe
{
    public partial class frmLenhDat : Form
    {
        private const string tableName = "BANG_GIA_TRUC_TUYEN";
        private SqlConnection _connection = null;

        public frmLenhDat()
        {
            InitializeComponent();

        }

        private void frmLenhDat_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private string GetConnectionString()
        {
            return @"Data Source=DESKTOP-CJGOS0L;Initial Catalog=CHUNGKHOAN;User ID=sa;Password=123456";
        }

        private void FormLoad()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(GetConnectionString());
                _connection.Open();
            }
        }

        private void btnLenhDat_Click(object sender, EventArgs e)
        {
                using (var cmd = new SqlCommand("SP_KHOPLENH_LO", _connection))
                {
                    //SqlCommand cmd = new SqlCommand("SP_KHOPLENH_LO", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@macp", txtMaCP.Text));
                    cmd.Parameters.Add(new SqlParameter("@LoaiGD", txtLoaiGD.Text));
                    cmd.Parameters.Add(new SqlParameter("@soluongMB", int.Parse(txtSoLuong.Text)));
                    cmd.Parameters.Add(new SqlParameter("@giadatMB", float.Parse(txtGiaDat.Text)));

                    //conn.Open();
                    cmd.ExecuteNonQuery();
                    //conn.Close();

                }
                MessageBox.Show("thanh cong");
           
                
            
        }


        private void txtMaCP_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaCP.Text))
            {
                errorProvider.SetError(txtMaCP, "Vui lòng điền Mã Cổ Phiếu!");
            }
            else if (!Regex.IsMatch(txtMaCP.Text, @"[A-Za-z][A-Za-z0-9]{2,7}"))
            {
                errorProvider.SetError(txtMaCP, "Mã Cổ Phiếu Không hợp lệ!");
            }
            else
            {
                errorProvider.SetError(txtMaCP, null);
            }
        }

        private void txtSoLuong_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                errorProvider.SetError(txtSoLuong, "Vui lòng điền Số Lượng!");
            }
            else if (!Regex.IsMatch(txtSoLuong.Text.ToString(), @"[0-9]{2,7}"))
            {
                errorProvider.SetError(txtSoLuong, "Số lượng Không hợp lệ!");
            }
            else
            {
                errorProvider.SetError(txtSoLuong, null);
            }
        }

        private void txtGiaDat_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGiaDat.Text.ToString()))
            {
                errorProvider.SetError(txtGiaDat, "Vui lòng điền Giá đặt!");
            }
            else if (!Regex.IsMatch(txtGiaDat.Text.ToString(), @"[0-9]{2,7}"))
            {
                errorProvider.SetError(txtGiaDat, "Giá đặt Không hợp lệ!");
            }
            else
            { 
                errorProvider.SetError(txtGiaDat, null);
            }
        }

        private void txtLoaiGD_Validated(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtLoaiGD.Text))
            {
                errorProvider.SetError(txtGiaDat, "Vui lòng điền Giá đặt!");
            }
            else if (!txtLoaiGD.Text.Equals("B") || !txtLoaiGD.Text.Equals("M"))
            {
                errorProvider.SetError(txtLoaiGD, "Giá đặt Không hợp lệ!");
            }
            else
            {
                errorProvider.SetError(txtLoaiGD, null);
            }
        }
    }
}
