using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AiLaTrieuPhu
{
    public partial class HoiYKienKhanGia : Form
    {
        private DapAn dapan;

        public HoiYKienKhanGia(DapAn dapan)
        {
            InitializeComponent();
            this.dapan = dapan;
            System.Media.SoundPlayer mediaSoundPlayer = new System.Media.SoundPlayer();
            mediaSoundPlayer.Stream = Properties.Resources.HoiYKienKhanGia;
            mediaSoundPlayer.Play();
            Thread.Sleep(20000);
            mediaSoundPlayer.Stop();
            
            setbutton();
        }
        void setbutton()
        {
            DataTable tabledapan = new DataTable();
            tabledapan=dapan.LayDapAn();
            Random r = new Random();
            int flag,flag1=0, flag2=0, flag3=0;
            
            if (tabledapan.Rows[0][1].ToString() == "A")
            {
                Point temp = new Point();
                Point temp1 = new Point();
                Point temp2 = new Point();
                Point temp3 = new Point();
                flag = r.Next(40, 55);
                flag1 = r.Next(10, 25);
                flag2 = r.Next(10, 15);
                flag3 = flag - flag1 - flag2;
                if (dapan.trangthai != "ABCD")
                {
                    if (dapan.trangthai == "AB")
                    {
                        flag2 = 0;
                        flag3 = 0;
                        flag += 10;
                        flag1 = 100 - flag;
                    }
                    else if (dapan.trangthai == "AC")
                    {
                        flag1 = 0;
                        flag3 = 0;
                        flag += 10;
                        flag2 = 100 - flag;
                    }
                    else if (dapan.trangthai == "AD")
                    {
                        flag1 = 0;
                        flag2 = 0;
                        flag += 10;
                        flag3 = 100 - flag;
                    }
                }
                Point a = new Point();
                a.X = 10;
                a.Y = 230 - flag * 2;
                temp.X = a.X+15;
                temp.Y = a.Y - 20;
                Button A = new Button { Height = flag * 2, Location = a, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                la.Text = flag.ToString() + "%";
                la.Location = temp;
                la.ForeColor = Color.Black;
                panel.Controls.Add(la);
                panel.Controls.Add(A);
                Point b = new Point();
                b.X = 80;
                b.Y = 230 - flag1 * 2;
                temp1.X = b.X + 15;
                temp1.Y = b.Y - 20;
                Button B = new Button { Height = flag1 * 2, Location = b, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                lb.Text = flag1.ToString() + "%";
                lb.Location = temp1;
                lb.ForeColor = Color.Black;
                panel.Controls.Add(lb);
                panel.Controls.Add(B);
                Point c = new Point();
                c.X = 150;
                c.Y = 230 - flag2 * 2;
                temp2.X = c.X + 15;
                temp2.Y = c.Y - 20;
                Button C = new Button { Height = flag2 * 2, Location = c, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                lc.Text = flag2.ToString() + "%";
                lc.Location = temp2;
                lc.ForeColor = Color.Black;
                panel.Controls.Add(lc);
                panel.Controls.Add(C);
                Point d = new Point();
                d.X = 220;
                d.Y = 230 - flag3 * 2;
                temp3.X = d.X + 15;
                temp3.Y = d.Y - 20;
                Button D = new Button { Height = flag3 * 2, Location = d, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                ld.Text = flag3.ToString() + "%";
                ld.Location = temp3;
                ld.ForeColor = Color.Black;
                panel.Controls.Add(ld);
                panel.Controls.Add(D);
            }
            else if (tabledapan.Rows[0][1].ToString() == "B")
            {
                Point temp = new Point();
                Point temp1 = new Point();
                Point temp2 = new Point();
                Point temp3 = new Point();
                flag1 = r.Next(40, 55);
                flag = r.Next(10, 25);
                flag2 = r.Next(10, 15);
                flag3 = flag1 - flag - flag2;
                if (dapan.trangthai != "ABCD")
                {
                    if (dapan.trangthai == "AB")
                    {
                        flag2 = 0;
                        flag3 = 0;
                        flag1 += 7;
                        flag = 100 - flag1;
                    }
                    else if (dapan.trangthai == "BC")
                    {
                        flag = 0;
                        flag3 = 0;
                        flag1 += 8;
                        flag2 = 100 - flag1;
                    }
                    else if (dapan.trangthai == "BD")
                    {
                        flag = 0;
                        flag2 = 0;
                        flag1 += 9;
                        flag3 = 100 - flag1;
                    }
                }
                Point a = new Point();
                a.X = 10;
                a.Y = 230 - flag * 2;
                temp.X = a.X + 15;
                temp.Y = a.Y - 20;
                Button A = new Button { Height = flag * 2, Location = a, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                la.Text = flag.ToString() + "%";
                la.Location = temp;
                la.ForeColor = Color.Black;
                panel.Controls.Add(la);
                panel.Controls.Add(A);
                Point b = new Point();
                b.X = 80;
                b.Y = 230 - flag1 * 2;
                temp1.X = b.X + 15;
                temp1.Y = b.Y - 20;
                Button B = new Button { Height = flag1 * 2, Location = b, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                lb.Text = flag1.ToString() + "%";
                lb.Location = temp1;
                lb.ForeColor = Color.Black;
                panel.Controls.Add(lb);
                panel.Controls.Add(B);
                Point c = new Point();
                c.X = 150;
                c.Y = 230 - flag2 * 2;
                temp2.X = c.X + 15;
                temp2.Y = c.Y - 20;
                Button C = new Button { Height = flag2 * 2, Location = c, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                lc.Text = flag2.ToString() + "%";
                lc.Location = temp2;
                lc.ForeColor = Color.Black;
                panel.Controls.Add(lc);
                panel.Controls.Add(C);
                Point d = new Point();
                d.X = 220;
                d.Y = 230 - flag3 * 2;
                temp3.X = d.X + 15;
                temp3.Y = d.Y - 20;
                Button D = new Button { Height = flag3 * 2, Location = d, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                ld.Text = flag3.ToString() + "%";
                ld.Location = temp3;
                ld.ForeColor = Color.Black;
                panel.Controls.Add(ld);
                panel.Controls.Add(D);
            }
            else if (tabledapan.Rows[0][1].ToString() == "C")
            {
                Point temp = new Point();
                Point temp1 = new Point();
                Point temp2 = new Point();
                Point temp3 = new Point();
                flag2 = r.Next(40, 55);
                flag3 = r.Next(10, 25);
                flag1 = r.Next(10, 15);
                flag = flag2 - flag3 - flag1;
                if (dapan.trangthai != "ABCD")
                {
                    if (dapan.trangthai == "AC")
                    {
                        flag1 = 0;
                        flag3 = 0;
                        flag2 += 10;
                        flag = 100 - flag2;
                    }
                    else if (dapan.trangthai == "BC")
                    {
                        flag = 0;
                        flag3 = 0;
                        flag2 += 8;
                        flag1 = 100 - flag2;
                    }
                    else if (dapan.trangthai == "CD")
                    {
                        flag = 0;
                        flag1 = 0;
                        flag2 += 8;
                        flag3 = 100 - flag2;
                    }
                }
                Point a = new Point();
                a.X = 10;
                a.Y = 230 - flag * 2;
                temp.X = a.X + 15;
                temp.Y = a.Y - 20;
                Button A = new Button { Height = flag * 2, Location = a, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                la.Text = flag.ToString() + "%";
                la.Location = temp;
                la.ForeColor = Color.Black;
                panel.Controls.Add(la);
                panel.Controls.Add(A);
                Point b = new Point();
                b.X = 80;
                b.Y = 230 - flag1 * 2;
                temp1.X = b.X + 15;
                temp1.Y = b.Y - 20;
                Button B = new Button { Height = flag1 * 2, Location = b, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                lb.Text = flag1.ToString() + "%";
                lb.Location = temp1;
                lb.ForeColor = Color.Black;
                panel.Controls.Add(lb);
                panel.Controls.Add(B);
                Point c = new Point();
                c.X = 150;
                c.Y = 230 - flag2 * 2;
                temp2.X = c.X + 15;
                temp2.Y = c.Y - 20;
                Button C = new Button { Height = flag2 * 2, Location = c, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                lc.Text = flag2.ToString() + "%";
                lc.Location = temp2;
                lc.ForeColor = Color.Black;
                panel.Controls.Add(lc);
                panel.Controls.Add(C);
                Point d = new Point();
                d.X = 220;
                d.Y = 230 - flag3 * 2;
                temp3.X = d.X + 15;
                temp3.Y = d.Y - 20;
                Button D = new Button { Height = flag3 * 2, Location = d, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                ld.Text = flag3.ToString() + "%";
                ld.Location = temp3;
                ld.ForeColor = Color.Black;
                panel.Controls.Add(ld);
                panel.Controls.Add(D);
            }
            else if (tabledapan.Rows[0][1].ToString() == "D")
            {
                Point temp = new Point();
                Point temp1 = new Point();
                Point temp2 = new Point();
                Point temp3 = new Point();
                flag3 = r.Next(40, 55);
                flag1 = r.Next(10, 25);
                flag2 = r.Next(10, 15);
                flag = flag3 - flag2 - flag1;
                if (dapan.trangthai != "ABCD")
                {
                    if (dapan.trangthai == "AD")
                    {
                        flag1 = 0;
                        flag2 = 0;
                        flag3 += 8;
                        flag = 100 - flag3;
                    }
                    else if (dapan.trangthai == "BD")
                    {
                        flag = 0;
                        flag2 = 0;
                        flag3 += 8;
                        flag1 = 100 - flag3;
                    }
                    else if (dapan.trangthai == "CD")
                    {
                        flag = 0;
                        flag1 = 0;
                        flag3 += 8;
                        flag2 = 100 - flag3;
                    }
                }
                Point a = new Point();
                a.X = 10;
                a.Y = 230 - flag * 2;
                temp.X = a.X + 15;
                temp.Y = a.Y - 20;
                Button A = new Button { Height = flag * 2, Location = a, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                la.Text = flag.ToString() + "%";
                la.Location = temp;
                la.ForeColor = Color.Black;
                panel.Controls.Add(la);
                panel.Controls.Add(A);
                Point b = new Point();
                b.X = 80;
                b.Y = 230 - flag1 * 2;
                temp1.X = b.X + 15;
                temp1.Y = b.Y - 20;
                Button B = new Button { Height = flag1 * 2, Location = b, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                lb.Text = flag1.ToString() + "%";
                lb.Location = temp1;
                lb.ForeColor = Color.Black;
                panel.Controls.Add(lb);
                panel.Controls.Add(B);
                Point c = new Point();
                c.X = 150;
                c.Y = 230 - flag2 * 2;
                temp2.X = c.X + 15;
                temp2.Y = c.Y - 20;
                Button C = new Button { Height = flag2 * 2, Location = c, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                lc.Text = flag2.ToString() + "%";
                lc.Location = temp2;
                lc.ForeColor = Color.Black;
                panel.Controls.Add(lc);
                panel.Controls.Add(C);
                Point d = new Point();
                d.X = 220;
                d.Y = 230 - flag3 * 2;
                temp3.X = d.X + 15;
                temp3.Y = d.Y - 20;
                Button D = new Button { Height = flag3 * 2, Location = d, Text = null, BackColor = Color.RoyalBlue, Width = 50 };
                ld.Text = flag3.ToString() + "%";
                ld.Location = temp3;
                ld.ForeColor = Color.Black;
                panel.Controls.Add(ld);
                panel.Controls.Add(D);
            }
        }
        private void HoiYKienKhanGia_Load(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
