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

namespace MonChuyenDe
{
    public partial class frmLenhDat : Form
    {
        public frmLenhDat()
        {
            InitializeComponent();
        }

        private void lENHDATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lENHDATBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cHUNGKHOANDataSet);

        }

        private void frmLenhDat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHUNGKHOANDataSet.LENHDAT' table. You can move, or remove it, as needed.
            this.lENHDATTableAdapter.Fill(this.cHUNGKHOANDataSet.LENHDAT);

        }

        private int datlenh(string ma, string loaiGD, int sl, float giaDat )
        {
            int result = 1; // thoa
            string lenh = string.Format("EXEC SP_KHOPLENH_LO {0}, {1}, {2}, {3}, {4} ", ma, DateTime.Now, loaiGD, sl, giaDat);
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(lenh, connection);
                sqlCommand.CommandType = CommandType.Text;
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch
                {
                    result = 0; // ko thoa
                }
            }
            return result;
        }

        private void btnLenhDat_Click(object sender, EventArgs e)
        {
            //if (Program.KetNoi() == 0) return;
            //Program.conn.Close();

            //string ma = txtMaCP.Text;
            //string loaiGD = txtLoaiGD.Text;
            //int sl = int.Parse( txtSoLuong.Text);
            //float gia = float.Parse(txtGiaDat.Text);

            //datlenh(ma, loaiGD, sl, gia);
            //this.lENHDATTableAdapter.Fill(this.cHUNGKHOANDataSet.LENHDAT);

            

        }
    }
}
