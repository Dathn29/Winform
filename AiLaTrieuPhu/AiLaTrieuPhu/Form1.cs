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
using System.Data.SqlClient;

namespace AiLaTrieuPhu
{
    public partial class Form1 : Form
    {
        public static int count = 0;
        string[] array = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        public Form1()
        {
            
            InitializeComponent();
            count = 0;
            Play();
        }
        private System.Media.SoundPlayer mediaSoundPlayer = new System.Media.SoundPlayer();
        void Random()
        {
            Random r = new Random();
            for(int i = 0; i < 5; i++)
            {
                string s = r.Next(1, 11).ToString();
                int temp = 0;
                for (int j = 0; j < 15; j++)
                {
                    if (s == array[j]) 
                    {
                        temp = 1;
                        i--;
                        break;

                    }
                }
                if (temp == 0)
                {
                    array[i] = s;
                }
            }
            for(int i = 5; i < 10; i++)
            {
                string s = r.Next(11, 30).ToString();
                int temp = 0;
                for (int j = 0; j < 15; j++)
                {
                    if (s == array[j])
                    {
                        i--;
                        temp = 1;
                        break;
                    }
                }
                if (temp == 0)
                {
                    array[i] = s;
                }
            }
            for (int i = 10; i < 15; i++)
            {
                string s = r.Next(30, 39).ToString();
                int temp = 0;
                for (int j = 0; j < 15; j++)
                {
                    if (s == array[j])
                    {
                        i--;
                        temp = 1;
                        break;
                    }
                }
                if (temp == 0)
                {
                    array[i] = s;
                }
            }
        }
        string macauhoi = "1";
        int counter = 30;
        void Play()
        {
            ViTri();
            Khoitao();
            if (count == 0)
            {
                Random();
            }
            counter = 30;
            Time();
            macauhoi =array[count].ToString();
            Help5050 = "";
            LayCauHoi();
            DocCau();
            DocCauHoi();
        }
        void Khoitao()
        {
            bA.Enabled = true;
            bB.Enabled = true;
            bC.Enabled = true;
            bD.Enabled = true;
        }
        void DocCau()
        {
            if (count == 0)
            {
                mediaSoundPlayer.Stream = Properties.Resources.c1;
                mediaSoundPlayer.Play();
                Thread.Sleep(2000);
            }
            else if (count == 1)
            {
                mediaSoundPlayer.Stream = Properties.Resources.c2;
                mediaSoundPlayer.Play();
                Thread.Sleep(2000);
            }
            else if (count == 2)
            {
                mediaSoundPlayer.Stream = Properties.Resources.c3;
                mediaSoundPlayer.Play();
                Thread.Sleep(2000);
            }
            else if (count == 3)
            {
                mediaSoundPlayer.Stream = Properties.Resources.c4;
                mediaSoundPlayer.Play();
                Thread.Sleep(2000);
            }
            else if (count == 4)
            {
                mediaSoundPlayer.Stream = Properties.Resources.c5;
                mediaSoundPlayer.Play();
                Thread.Sleep(2000);
            }
            else if (count == 5)
            {
                mediaSoundPlayer.Stream = Properties.Resources.c6;
                mediaSoundPlayer.Play();
                Thread.Sleep(2000);
            }
            else if (count == 6)
            {
                mediaSoundPlayer.Stream = Properties.Resources.c7;
                mediaSoundPlayer.Play();
                Thread.Sleep(2000);
            }
            else if (count == 7)
            {
                mediaSoundPlayer.Stream = Properties.Resources.c8;
                mediaSoundPlayer.Play();
                Thread.Sleep(2000);
            }
            else if (count == 8)
            {
                mediaSoundPlayer.Stream = Properties.Resources.c9;
                mediaSoundPlayer.Play();
                Thread.Sleep(2000);
            }
            else if (count == 9)
            {
                mediaSoundPlayer.Stream = Properties.Resources.c10;
                mediaSoundPlayer.Play();
                Thread.Sleep(2000);
            }
            else if (count == 10)
            {
                mediaSoundPlayer.Stream = Properties.Resources.c11;
                mediaSoundPlayer.Play();
                Thread.Sleep(2000);
            }
            else if (count == 11)
            {
                mediaSoundPlayer.Stream = Properties.Resources.c12;
                mediaSoundPlayer.Play();
                Thread.Sleep(2000);
            }
            else if (count == 12)
            {
                mediaSoundPlayer.Stream = Properties.Resources.c13;
                mediaSoundPlayer.Play();
                Thread.Sleep(2000);
            }
            else if (count == 13)
            {
                mediaSoundPlayer.Stream = Properties.Resources.c14;
                mediaSoundPlayer.Play();
                Thread.Sleep(2000);
            }
            else if (count == 14)
            {
                mediaSoundPlayer.Stream = Properties.Resources.c15;
                mediaSoundPlayer.Play();
                Thread.Sleep(5000);
            }
        }
        void DocCauHoi()
        {
            if (macauhoi == "1")
            {
                mediaSoundPlayer.Stream = Properties.Resources._1;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "2")
            {
                mediaSoundPlayer.Stream = Properties.Resources._2;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "3")
            {
                mediaSoundPlayer.Stream = Properties.Resources._3;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "4")
            {
                mediaSoundPlayer.Stream = Properties.Resources._4;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "5")
            {
                mediaSoundPlayer.Stream = Properties.Resources._5;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "6")
            {
                mediaSoundPlayer.Stream = Properties.Resources._6;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "7")
            {
                mediaSoundPlayer.Stream = Properties.Resources._7;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "8")
            {
                mediaSoundPlayer.Stream = Properties.Resources._8;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "9")
            {
                mediaSoundPlayer.Stream = Properties.Resources._9;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "10")
            {
                mediaSoundPlayer.Stream = Properties.Resources._10;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "11")
            {
                mediaSoundPlayer.Stream = Properties.Resources._11;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "12")
            {
                mediaSoundPlayer.Stream = Properties.Resources._12;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "13")
            {
                mediaSoundPlayer.Stream = Properties.Resources._13;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "14")
            {
                mediaSoundPlayer.Stream = Properties.Resources._14;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "15")
            {
                mediaSoundPlayer.Stream = Properties.Resources._15;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "16")
            {
                mediaSoundPlayer.Stream = Properties.Resources._16;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "17")
            {
                mediaSoundPlayer.Stream = Properties.Resources._17;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "18")
            {
                mediaSoundPlayer.Stream = Properties.Resources._18;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "19")
            {
                mediaSoundPlayer.Stream = Properties.Resources._19;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "20")
            {
                mediaSoundPlayer.Stream = Properties.Resources._20;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "21")
            {
                mediaSoundPlayer.Stream = Properties.Resources._21;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "22")
            {
                mediaSoundPlayer.Stream = Properties.Resources._22;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "23")
            {
                mediaSoundPlayer.Stream = Properties.Resources._23;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "24")
            {
                mediaSoundPlayer.Stream = Properties.Resources._24;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "25")
            {
                mediaSoundPlayer.Stream = Properties.Resources._25;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "26")
            {
                mediaSoundPlayer.Stream = Properties.Resources._26;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "27")
            {
                mediaSoundPlayer.Stream = Properties.Resources._27;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "28")
            {
                mediaSoundPlayer.Stream = Properties.Resources._28;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "29")
            {
                mediaSoundPlayer.Stream = Properties.Resources._29;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "30")
            {
                mediaSoundPlayer.Stream = Properties.Resources._30;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "31")
            {
                mediaSoundPlayer.Stream = Properties.Resources._31;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "32")
            {
                mediaSoundPlayer.Stream = Properties.Resources._32;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "33")
            {
                mediaSoundPlayer.Stream = Properties.Resources._33;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "34")
            {
                mediaSoundPlayer.Stream = Properties.Resources._34;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "35")
            {
                mediaSoundPlayer.Stream = Properties.Resources._35;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "36")
            {
                mediaSoundPlayer.Stream = Properties.Resources._36;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "37")
            {
                mediaSoundPlayer.Stream = Properties.Resources._37;
                mediaSoundPlayer.Play();
            }
            else if (macauhoi == "38")
            {
                mediaSoundPlayer.Stream = Properties.Resources._38;
                mediaSoundPlayer.Play();
            }
        }
        void LayCauHoi()
        {
            Connect connect = new Connect();
            DataTable tablecauhoi = new DataTable();
            string sql = string.Format("Select * from CauHoiDee where MaCauHoi='{0}'", macauhoi);
            tablecauhoi = connect.GetDataTable(sql);
            cauhoi.Text = "Câu hỏi số "+(count+1).ToString()+":  "+tablecauhoi.Rows[0][1].ToString();
            bA.Text = tablecauhoi.Rows[0][2].ToString();
            bB.Text = tablecauhoi.Rows[0][3].ToString();
            bC.Text = tablecauhoi.Rows[0][4].ToString();
            bD.Text = tablecauhoi.Rows[0][5].ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool CheckAnswer(string str)
        {
            DataTable tablecauhoi = new DataTable();
            tablecauhoi = LayDapAn();
            if (str == tablecauhoi.Rows[0][1].ToString())
                return true;
            else
                return false;
        }
       
        private void bA_Click(object sender, EventArgs e)
        {
            mediaSoundPlayer.Stop();
            bA.BackColor = Color.Red;
            if (MessageBox.Show("Đáp án A là đáp án cuối cùng của bạn", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (CheckAnswer("A"))
                {
                    mediaSoundPlayer.Stream = Properties.Resources.TraLoiDung;
                    mediaSoundPlayer.Play();
                    MessageBox.Show("Đó là câu trả lời đúng");
                    mediaSoundPlayer.Stop();
                    if (count == 4)

                    {
                        mediaSoundPlayer.Stream = Properties.Resources.C5_Dung;
                        mediaSoundPlayer.Play();
                        Thread.Sleep(7000);
                    }
                    bA.BackColor = Color.RoyalBlue;
                    count++;
                    if (count != 15)
                        Play();
                    if (count == 15)
                    {
                        MessageBox.Show("Bạn đã trở thành triệu phú! Xin chúc mừng");
                        timer1.Stop();
                        ThuaCuoc f = new ThuaCuoc(count + 1);
                        f.ShowDialog();
                        this.Hide();
                        count = 0;
                    }
                    
                }
                else
                {
                    DataTable table = new DataTable();
                    table = LayDapAn();
                    MessageBox.Show(table.Rows[0][1].ToString() + " mới là đáp án đúng");
                    timer1.Stop();
                    ThuaCuoc f = new ThuaCuoc(count + 1);
                    f.ShowDialog();
                    this.Hide();
                }

            }
            else
            {
                bA.BackColor = Color.RoyalBlue;
            }
        }

        private void bB_Click(object sender, EventArgs e)
        {
            mediaSoundPlayer.Stop();
            bB.BackColor = Color.Red;
            if (MessageBox.Show("Đáp án B là đáp án cuối cùng của bạn", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (CheckAnswer("B"))
                {
                    mediaSoundPlayer.Stream = Properties.Resources.TraLoiDung;
                    mediaSoundPlayer.Play();
                    MessageBox.Show("Đó là câu trả lời đúng");
                    mediaSoundPlayer.Stop();
                    if (count == 4)
                    {
                        mediaSoundPlayer.Stream = Properties.Resources.C5_Dung;
                        mediaSoundPlayer.Play();
                        Thread.Sleep(7000);

                    }
                    bB.BackColor = Color.RoyalBlue;
                    count++;
                    if (count != 15)
                        Play();
                    if (count == 15)
                    {
                        MessageBox.Show("Bạn đã trở thành triệu phú! Xin chúc mừng");
                        timer1.Stop();
                        ThuaCuoc f = new ThuaCuoc(count + 1);
                        f.ShowDialog();
                        this.Hide();
                        count = 0;
                    }
                    
                }
                else
                {
                    DataTable table = new DataTable();
                    table = LayDapAn();
                    MessageBox.Show(table.Rows[0][1].ToString() + " mới là đáp án đúng");
                    timer1.Stop();
                    ThuaCuoc f = new ThuaCuoc(count+1);
                    f.ShowDialog();
                    this.Hide();
                }

            }
            else
            {
                bB.BackColor = Color.RoyalBlue;
            }
        }

        private void bC_Click(object sender, EventArgs e)
        {
            mediaSoundPlayer.Stop();
            bC.BackColor = Color.Red;
            if (MessageBox.Show("Đáp án C là đáp án cuối cùng của bạn", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (CheckAnswer("C"))
                {
                    if (count == 14)
                    {
                        MessageBox.Show("Bạn là người thắng cuộc");
                        this.Close();
                    }
                    mediaSoundPlayer.Stream = Properties.Resources.TraLoiDung;
                    mediaSoundPlayer.Play();
                    MessageBox.Show("Đó là câu trả lời đúng");
                    mediaSoundPlayer.Stop();
                    if (count == 4)
                    {
                        mediaSoundPlayer.Stream = Properties.Resources.C5_Dung;
                        mediaSoundPlayer.Play();
                        Thread.Sleep(7000);
                    }
                    bC.BackColor = Color.RoyalBlue;
                    count++;
                    if (count != 15)
                        Play();
                    if (count == 15)
                    {
                        MessageBox.Show("Bạn đã trở thành triệu phú! Xin chúc mừng");
                        timer1.Stop();
                        ThuaCuoc f = new ThuaCuoc(count + 1);
                        f.ShowDialog();
                        this.Hide();
                        count = 0;
                    }
                    
                }
                else
                {
                    DataTable table = new DataTable();
                    table = LayDapAn();
                    MessageBox.Show(table.Rows[0][1].ToString() + " mới là đáp án đúng");
                    timer1.Stop();
                    ThuaCuoc f = new ThuaCuoc(count+1);
                    f.ShowDialog();
                    this.Hide();
                }

            }
            else
            {
                bC.BackColor = Color.RoyalBlue;
            }
        }

        private void bD_Click_1(object sender, EventArgs e)
        {
            mediaSoundPlayer.Stop();
            bD.BackColor = Color.Red;
            if (MessageBox.Show("Đáp án D là đáp án cuối cùng của bạn", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (CheckAnswer("D"))
                {
                    mediaSoundPlayer.Stream = Properties.Resources.TraLoiDung;
                    mediaSoundPlayer.Play();
                    MessageBox.Show("Đó là câu trả lời đúng");
                    mediaSoundPlayer.Stop();
                    if (count == 4)
                    {
                        mediaSoundPlayer.Stream = Properties.Resources.C5_Dung;
                        mediaSoundPlayer.Play();
                        Thread.Sleep(7000);
                    }
                    bD.BackColor = Color.RoyalBlue;
                    count++;
                    if (count == 15)
                    {
                        MessageBox.Show("Bạn đã trở thành triệu phú! Xin chúc mừng");
                        timer1.Stop();
                        ThuaCuoc f = new ThuaCuoc(count + 1);
                        f.ShowDialog();
                        this.Hide();
                        count = 0;
                    }
                    if (count != 15)
                        Play();
                }
                else
                {
                    DataTable table = new DataTable();
                    table = LayDapAn();
                    MessageBox.Show(table.Rows[0][1].ToString() + " mới là đáp án đúng");
                    timer1.Stop();
                    ThuaCuoc f = new ThuaCuoc(count + 1) ;
                    f.ShowDialog();
                    this.Hide();
                }

            }
            else
            {
                bD.BackColor = Color.RoyalBlue;
            }

        }
        void Time()
        {
            counter = 31;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            label1.Text = counter.ToString();
            if (counter == 0)
            {
                MessageBox.Show("Hết thời gian");
                ThuaCuoc f = new ThuaCuoc(count+1);
                f.ShowDialog();
                this.Hide();
                timer1.Stop();
            }
        }
        void ViTri()

        {
            if (count == 0)
            {
                l1.BackColor = Color.Black;
            }
            if (count == 1)
            {
                l1.BackColor = Color.MidnightBlue;
                l2.BackColor = Color.Black;
            }
            else if (count == 2)
            {
                l2.BackColor = Color.MidnightBlue;
                l3.BackColor = Color.Black;
            }
            else if (count == 3)
            {
                l3.BackColor = Color.MidnightBlue;
                l4.BackColor = Color.Black;
            }
            else if (count == 4)
            {
                l4.BackColor = Color.MidnightBlue;
                l5.BackColor = Color.Black;
            }
            else if (count == 5)
            {
                l5.BackColor = Color.MidnightBlue;
                l6.BackColor = Color.Black;
            }
            else if (count == 6)
            {
                l6.BackColor = Color.MidnightBlue;
                l7.BackColor = Color.Black;
            }
            else if (count == 7)
            {
                l7.BackColor = Color.MidnightBlue;
                l8.BackColor = Color.Black;
            }
            else if (count == 8)
            {
                l8.BackColor = Color.MidnightBlue;
                l9.BackColor = Color.Black;

            }
            else if (count == 9)
            {
                l9.BackColor = Color.MidnightBlue;
                l10.BackColor = Color.Black;

            }
            else if (count == 10)
            {
                l10.BackColor = Color.MidnightBlue;
                l11.BackColor = Color.Black;
            }
            else if (count == 11)
            {
                l11.BackColor = Color.MidnightBlue;
                l12.BackColor = Color.Black;
            }
            else if (count == 12)
            {
                l12.BackColor = Color.MidnightBlue;
                l13.BackColor = Color.Black;
            }
            else if (count == 13)
            {
                l13.BackColor = Color.MidnightBlue;
                l14.BackColor = Color.Black;
            }
            else if (count == 14)
            {
                l14.BackColor = Color.MidnightBlue;
                l15.BackColor = Color.Black;
            }

        }
       
        public DataTable LayDapAn()
        {
            Connect connect = new Connect();
            DataTable tablecauhoi = new DataTable();
            string sql = string.Format("Select * from DapAnDe where MaCauHoi='{0}'", macauhoi);
            tablecauhoi = connect.GetDataTable(sql);
            return tablecauhoi;
        }
        string Help5050 = null;
        private void Trogiup5050_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban chắc chắn muốn dùng trợ giúp này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Random r = new Random();
                DataTable tablecauhoi = new DataTable();
                tablecauhoi = LayDapAn();
                mediaSoundPlayer.Stream = Properties.Resources.TroGiup5050;
                mediaSoundPlayer.Play();
                Thread.Sleep(6500);
                if (tablecauhoi.Rows[0][1].ToString() == "A")
                {
                    int a = r.Next(1, 3);
                    int b = r.Next(1, 3);
                    while (a == b)
                    {
                        b = r.Next(1, 3);
                    }
                    if (a == 1)
                    {
                        bB.Text = null;
                        bB.Enabled = false;
                    }
                    else if (a == 2)
                    {
                        bC.Text = null;
                        bC.Enabled = false;
                    }
                    else if (a == 3)
                    {
                        bD.Text = null;
                        bD.Enabled = false;
                    }
                    if (b == 1)
                    {
                        bB.Text = null;
                        bB.Enabled = false;
                    }
                    else if (b == 2)
                    {
                        bC.Text = null;
                        bC.Enabled = false;
                    }
                    else if (b == 3)
                    {
                        bD.Text = null;
                        bD.Enabled = false;
                    }

                }
                if (tablecauhoi.Rows[0][1].ToString() == "B")
                {
                    int a = r.Next(1, 3);
                    int b = r.Next(1, 3);
                    while (a == b)
                    {
                        b = r.Next(1, 3);
                    }
                    if (a == 1)
                    {
                        bA.Text = null;
                        bA.Enabled = false;
                    }
                    else if (a == 2)
                    {
                        bC.Text = null;
                        bC.Enabled = false;
                    }
                    else if (a == 3)
                    {
                        bD.Text = null;
                        bD.Enabled = false;
                    }
                    if (b == 1)
                    {
                        bA.Text = null;
                        bA.Enabled = false;
                    }
                    else if (b == 2)
                    {
                        bC.Text = null;
                        bC.Enabled = false;
                    }
                    else if (b == 3)
                    {
                        bD.Text = null;
                        bD.Enabled = false;
                    }

                }
                if (tablecauhoi.Rows[0][1].ToString() == "C")
                {
                    int a = r.Next(1, 3);
                    int b = r.Next(1, 3);
                    while (a == b)
                    {
                        b = r.Next(1, 3);
                    }
                    if (a == 1)
                    {
                        bB.Text = null;
                        bB.Enabled = false;
                    }
                    else if (a == 2)
                    {
                        bA.Text = null;
                        bA.Enabled = false;
                    }
                    else if (a == 3)
                    {
                        bD.Text = null;
                        bD.Enabled = false;
                    }
                    if (b == 1)
                    {
                        bB.Text = null;
                        bB.Enabled = false;
                    }
                    else if (b == 2)
                    {
                        bA.Text = null;
                        bA.Enabled = false;
                    }
                    else if (b == 3)
                    {
                        bD.Text = null;
                        bD.Enabled = false;
                    }

                }
                if (tablecauhoi.Rows[0][1].ToString() == "D")
                {
                    int a = r.Next(1, 3);
                    int b = r.Next(1, 3);
                    while (a == b)
                    {
                        b = r.Next(1, 3);
                    }
                    if (a == 1)
                    {
                        bB.Text = null;
                        bB.Enabled = false;
                    }
                    else if (a == 2)
                    {
                        bC.Text = null;
                        bC.Enabled = false;
                    }
                    else if (a == 3)
                    {
                        bA.Text = null;
                        bA.Enabled = false;
                    }
                    if (b == 1)
                    {
                        bB.Text = null;
                        bB.Enabled = false;
                    }
                    else if (b == 2)
                    {
                        bC.Text = null;
                        bC.Enabled = false;
                    }
                    else if (b == 3)
                    {
                        bA.Text = null;
                        bA.Enabled = false;
                    }

                }
                if (bA.Text != "")
                {
                    Help5050 += "A";
                }
                if (bB.Text != "")
                {
                    Help5050 += "B";
                }
                if (bC.Text != "")
                {
                    Help5050 += "C";
                }
                if (bD.Text != "")
                {
                    Help5050 += "D";
                }
                Trogiup5050.Enabled = false;
            }
        }
        private void Hoiykienkhangia_Click(object sender, EventArgs e)
        {
            DapAn dapan = new DapAn();
            dapan.macauhoi = macauhoi;
            dapan.trangthai = Help5050;
            HoiYKienKhanGia f = new HoiYKienKhanGia(dapan);
            f.ShowDialog();
            Hoiykienkhangia.Enabled = false;
        }

        private void Totuvantaicho_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban chắc chắn muốn dùng trợ giúp này","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataTable tablecauhoi = new DataTable();
                tablecauhoi = LayDapAn();
                Totuvantaicho.Enabled = false;
                string a = tablecauhoi.Rows[0][1].ToString();
                ToTuVan f = new ToTuVan(a);
                f.ShowDialog();
            }

        }
    }
}
