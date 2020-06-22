using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiLaTrieuPhu
{
    public partial class ThuaCuoc : Form
    {
        private int count = 0;
        public ThuaCuoc(int n)
        {
            InitializeComponent();
            count = n-1;
            Hien();
        }
        void Hien()
        {
            l1.Text = count.ToString();
            if (count == 0)
            {
                l2.Text = "0 đồng";
            }
            else if (count == 1)
            {
                l2.Text = "200,000 đồng";
            }
            else if (count == 2)
            {
                l2.Text = "400,000 đồng";
            }
            else if (count == 3)
            {
                l2.Text = "600,000 đồng";
            }
            else if (count == 4)
            {
                l2.Text = "1,000,000 đồng";
            }
            else if (count == 5)
            {
                l2.Text = "2,000,000 đồng";
            }
            else if (count == 6)
            {
                l2.Text = "3,000,000 đồng";
            }
            else if (count == 7)
            {
                l2.Text = "6,000,000 đồng";
            }
            else if (count == 8)
            {
                l2.Text = "10,000,000 đồng";
            }
            else if (count == 9)
            {
                l2.Text = "14,000,000 đồng";
            }
            else if (count == 10)
            {
                l2.Text = "22,000,000 đồng";
            }
            else if (count == 11)
            {
                l2.Text = "30,000,000 đồng";
            }
            else if (count == 12)
            {
                l2.Text = "40,000,000 đồng";
            }
            else if (count == 13)
            {
                l2.Text = "60,000,000 đồng";
            }
            else if (count == 14)
            {
                l2.Text = "85,000,000 đồng";
            }
            else if (count == 15)
            {
                l2.Text = "150,000,000 đồng";
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Khoitao f = new Khoitao();
            f.ShowDialog();
            this.Close();
        }
    }
}
