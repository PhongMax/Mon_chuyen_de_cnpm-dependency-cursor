using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonChuyenDe
{
    public partial class frmBGTT : Form
    {
        public frmBGTT()
        {
            InitializeComponent();
        }

        private void frmBGTT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHUNGKHOANDataSet.BANG_GIA_TRUC_TUYEN' table. You can move, or remove it, as needed.
            this.bANG_GIA_TRUC_TUYENTableAdapter.Fill(this.cHUNGKHOANDataSet.BANG_GIA_TRUC_TUYEN);

            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            this.dataGridView1.ColumnHeadersHeight = this.dataGridView1.ColumnHeadersHeight * 2;

            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;


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

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle rtHeader = this.dataGridView1.DisplayRectangle;

            rtHeader.Height = this.dataGridView1.ColumnHeadersHeight / 2;

            this.dataGridView1.Invalidate(rtHeader);

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

            // custom lại đối tượng rectangle tọa độ...

            r1.Y += 1;

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



            r2.Y += 1;

            r2.Width = 4 * w;
            r2.Height = r2.Height / 2 - 2;


            e.Graphics.FillRectangle(new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor), r2);
            e.Graphics.DrawString("DƯ MUA", this.dataGridView1.ColumnHeadersDefaultCellStyle.Font, new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor),
            r2, format);
            e.Graphics.DrawRectangle(pen, r2);

            Rectangle r3 = this.dataGridView1.GetCellDisplayRectangle(5, -1, true);
            r3.Y += 1;
            r3.Width = 2 * w;
            r3.Height = r3.Height / 2 - 2;

            e.Graphics.FillRectangle(new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor), r3);
            e.Graphics.DrawString("KHỚP LỆNH", this.dataGridView1.ColumnHeadersDefaultCellStyle.Font, new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor),
            r3, format);
            e.Graphics.DrawRectangle(pen, r3);


            Rectangle r4 = this.dataGridView1.GetCellDisplayRectangle(7, -1, true);
            r4.Y += 1;
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
    }
}
