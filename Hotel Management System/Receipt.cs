using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        private void childpanel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // SolidBrush brush1 = new SolidBrush(invoicetoo.BackColor);
           // SolidBrush brush2 = new SolidBrush(Name.BackColor);

            e.Graphics.DrawImage(pictureBox1.Image, 0, 0);
                
                e.Graphics.DrawString(Name.Text, Name.Font, Brushes.Black, 80,340
                 );
               

                
            //e.Graphics.DrawString(Roomtype.Text, Roomtype.Font, brush1, Roomtype.Location);
            //e.Graphics.DrawString(bunifuLabel1.Text, bunifuLabel1.Font, brush2, bunifuLabel1.Location);
            //e.Graphics.DrawString(Total.Text, Total.Font, brush1, Total.Location);
            //e.Graphics.DrawString(bunifuLabel3.Text, bunifuLabel3.Font, brush2, bunifuLabel3.Location);
            //e.Graphics.DrawString("-------------------------------", Name.Font, brush2, 172, 139);


        }

        private void Book_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Height = 300;
            printPreviewDialog1.Width = 400;
            printPreviewDialog1.ShowDialog();
        }
    }
}
