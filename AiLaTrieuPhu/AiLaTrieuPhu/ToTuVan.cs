using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiLaTrieuPhu
{
    public partial class ToTuVan : Form
    {
        string dapan = "";
        public ToTuVan(string a)
        {
            InitializeComponent();
            dapan = a;

        }

        private void ToTuVan_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ngô Trung Sơn trợ giúp cho bạn là đáp án " + dapan);
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anhxtanh trợ giúp cho bạn là đáp án " + dapan);
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nghê Quyết Tiến trợ giúp cho bạn là đáp án " + dapan);
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bùi Mạnh Cường trợ giúp cho bạn là đáp án " + dapan);
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trịnh Văn Trường trợ giúp cho bạn là đáp án " + dapan);
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bill Gates trợ giúp cho bạn là đáp án " + dapan);
            this.Close();
        }
    }
}
