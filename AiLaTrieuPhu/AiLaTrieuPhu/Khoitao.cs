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
    public partial class Khoitao : Form
    {
        public Khoitao()
        {
            InitializeComponent();
            mediaSoundPlayer.Stream = Properties.Resources.Mo_Dau;
            mediaSoundPlayer.Play();
        }
        private System.Media.SoundPlayer mediaSoundPlayer = new System.Media.SoundPlayer();

        private void Khoitao_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mediaSoundPlayer.Stop();
            Form1 f = new Form1();
            f.ShowDialog();
            //this.Close();
        }
    }
}
