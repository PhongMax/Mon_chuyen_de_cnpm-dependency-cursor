using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonChuyenDe
{
    public partial class frmBGTT : Form
    {
        private const string tableName = "BANG_GIA_TRUC_TUYEN";
        private SqlConnection _connection = null;
        private SqlCommand _command = null;
    
        private int _vitriRow;
        private int _vitriColumn;

        public frmBGTT()
        {
            InitializeComponent();
        }

        private void frmBGTT_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ColumnHeadersHeight = this.dataGridView1.ColumnHeadersHeight * 2;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            if (CanRequestNotifications() == true)
                BatDau();
            else
                MessageBox.Show("Bạn chưa kích hoạt dịch vụ Broker", "", MessageBoxButtons.OK);
         
        }
      

        private void BatDau()
        {
            // Remove any existing dependency connection, then create a new one.
            SqlDependency.Stop(GetConnectionString());
            try
            {
                SqlDependency.Start(GetConnectionString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OK);
                return;
            }
            if (_connection == null)
            {
                _connection = new SqlConnection(GetConnectionString());
                _connection.Open();
            }

            if (_command == null)
            {
                _command = new SqlCommand(GetSQL(), _connection);
                _command.CommandType = CommandType.Text;
                _command.CommandTimeout = 600;

            }



            GetData();
        }

        private void GetData()
        {


            // Make sure the command object does not already have
            // a notification object associated with it.
            _command.Notification = null;

            // Create and bind the SqlDependency object
            // to the command object.

            SqlDependency dependency = new SqlDependency(_command);
            dependency.OnChange += dependency_OnChange;


            // SqlDataReader is then loaded into a DataTable and finally the DataTable is used to populate the DataGridView.
            DataTable dt = new DataTable();
            dt.Load(_command.ExecuteReader());    // vì chỉ đọc thôi nên dùng data Reader. ko cần phải dùng dataset
            this.dataGridView1.DataSource = dt;

            // giữ vị trí cursor
            try
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[_vitriRow].Cells[_vitriColumn].Selected = true;

            }
            catch (Exception ex)
            {
                // neu co loi thi reset lai
                this.dataGridView1.ClearSelection();
            }



        }
        private string GetSQL()
        {
            return " SELECT MACP AS[    - - - - - - -], DM_GIA2 AS[Giá Mua 2], DM_KL2 AS[KLM 2], DM_GIA1 AS[Giá Mua 1], DM_KL1 AS[KLM 1], KL_GIA AS[Giá Khớp], "
                    + " KL_KL AS[KL khớp], DB_GIA1 AS[Giá Bán 1], DB_KL1 AS[KLB 1], DB_GIA2 AS[Giá Bán 2], DB_KL2 AS[KLB 2] " +
                    " FROM dbo.BANG_GIA_TRUC_TUYEN ";
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            // This event will occur on a thread pool thread.
            // It is illegal to update the UI from a worker thread
            // The following code checks to see if it is safe update the UI.
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;

            // If InvokeRequired returns True, the code is executing on a worker thread.
            if (i.InvokeRequired)
            {
                // Create a delegate to perform the thread switch
                OnChangeEventHandler tempDelegate = new OnChangeEventHandler(dependency_OnChange);

                object[] args = new[] { sender, e };

                // Marshal the data from the worker thread
                // to the UI thread.
                i.BeginInvoke(tempDelegate, args);

                return;
            }
            // Remove the handler since it's only good
            // for a single notification
            SqlDependency dependency = (SqlDependency)sender;
            dependency.OnChange -= dependency_OnChange;
            // Reload the dataset that's bound to the grid.
            GetData();
        }




        private bool CanRequestNotifications()
        {
            // In order to use the callback feature of the
            // SqlDependency, the application must have
            // the SqlClientPermission permission.
            try
            {
                SqlClientPermission perm = new SqlClientPermission(PermissionState.Unrestricted);

                perm.Demand();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private string GetConnectionString()
        {
            return @"Data Source=MSI;Initial Catalog=CHUNGKHOAN;User ID=sa;Password=123456";
        }
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            // format text
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            // độ rộng muỗi ô
            int w = this.dataGridView1.GetCellDisplayRectangle(2, -1, true).Width;

            // vẽ viền
            Pen pen = new Pen(Color.Brown, 1);
            pen.Alignment = PenAlignment.Inset;

            // ==> ô header Mã cổ phiếu
            // lấy đối tượng rectangle....
            Rectangle r1 = this.dataGridView1.GetCellDisplayRectangle(0, -1, true);


            //  chiều dài và rộng...
            r1.Width = r1.Width;
            r1.Height = r1.Height / 2 - 2;

            // vẽ ô header
            e.Graphics.FillRectangle(new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor), r1);
            e.Graphics.DrawString("MÃ CỔ PHIẾU", this.dataGridView1.ColumnHeadersDefaultCellStyle.Font, new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor),
            r1, format);
            e.Graphics.DrawRectangle(pen, r1);
            //==>  ô header Dư mua

            Rectangle r2 = this.dataGridView1.GetCellDisplayRectangle(1, -1, true);
            r2.Width = 4 * w;
            r2.Height = r2.Height / 2 - 2;

            e.Graphics.FillRectangle(new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor), r2);
            e.Graphics.DrawString("DƯ MUA", this.dataGridView1.ColumnHeadersDefaultCellStyle.Font, new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor),
            r2, format);
            e.Graphics.DrawRectangle(pen, r2);

            Rectangle r3 = this.dataGridView1.GetCellDisplayRectangle(5, -1, true);
            r3.Width = 2 * w;
            r3.Height = r3.Height / 2 - 2;

            e.Graphics.FillRectangle(new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor), r3);
            e.Graphics.DrawString("KHỚP LỆNH", this.dataGridView1.ColumnHeadersDefaultCellStyle.Font, new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor),
            r3, format);
            e.Graphics.DrawRectangle(pen, r3);

            Rectangle r4 = this.dataGridView1.GetCellDisplayRectangle(7, -1, true);

            r4.Width = 4 * w;
            r4.Height = r4.Height / 2 - 2;

            e.Graphics.FillRectangle(new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor), r4);
            e.Graphics.DrawString("DƯ BÁN", this.dataGridView1.ColumnHeadersDefaultCellStyle.Font, new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor),
            r4, format);
            e.Graphics.DrawRectangle(pen, r4);
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle rtHeader = this.dataGridView1.DisplayRectangle;
            rtHeader.Height = this.dataGridView1.ColumnHeadersHeight / 2;
            this.dataGridView1.Invalidate(rtHeader);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _vitriColumn = dataGridView1.CurrentCell.ColumnIndex;
            _vitriRow = dataGridView1.CurrentRow.Index;
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle rtHeader = this.dataGridView1.DisplayRectangle;
            rtHeader.Height = this.dataGridView1.ColumnHeadersHeight / 2;
            this.dataGridView1.Invalidate(rtHeader);
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                Rectangle r2 = e.CellBounds;
                r2.Y += e.CellBounds.Height / 2;
                r2.Height = e.CellBounds.Height / 2;

                e.PaintBackground(r2, true);
                e.PaintContent(r2);
                e.Handled = true;
            }
        }

        private int datlenh()
        {
            int result = 1; // thoa
            string lenh = string.Format("EXEC SP_KHOPLENH_LO {0}, {1}, {2},{3}, {4} ", txtMaCP, DateTime.Now, txtLoaiGD,txtSoLuong, txtGiaDat);
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
             using (var cmd = new SqlCommand("SP_KHOPLENH_LO", _connection))
            {
                //SqlCommand cmd = new SqlCommand("SP_KHOPLENH_LO", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@macp", txtMaCP.Text));
                cmd.Parameters.Add(new SqlParameter("@Ngay", "2020-04-17 13:33:08.183"));
                cmd.Parameters.Add(new SqlParameter("@LoaiGD", txtLoaiGD.Text));
                cmd.Parameters.Add(new SqlParameter("@soluongMB", int.Parse(txtSoLuong.Text)));
                cmd.Parameters.Add(new SqlParameter("@giadatMB", float.Parse(txtGiaDat.Text)));

                //conn.Open();
                cmd.ExecuteNonQuery();
                //conn.Close();

            }
            MessageBox.Show("thanh cong");
        }

    }
}
