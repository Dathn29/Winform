using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cocaro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        List<List<Button>> matran;
        Stack<Point> stp;
        List<Point> pointend;
        int chedochoi = 0;
        void VeBanCo()
        {
            Banco.Controls.Clear();
            stp = new Stack<Point>();
            matran = new List<List<Button>>();
            for (int i = 0; i < 20; i++)
            {
                List<Button> item = new List<Button>();
                matran.Add(item);
                for (int j = 0; j < 20; j++)
                {
                    Button b = new Button() { Width = dodai.dai, Height = dodai.rong };
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    b.Location = new Point(b.Location.X + j * 30, b.Location.Y + i * 30);
                    b.Tag = i;
                    b.Click += b_click;
                    Banco.Controls.Add(b);
                    matran[i].Add(b);
                }

            }
        }
        Point getpoint(Button b)
        {
            Point a;
            a = new Point();
            a.X = int.Parse(b.Tag.ToString());
            a.Y = matran[a.X].IndexOf(b);
            return a;
        }
        bool checkngang(Button b)
        {
            pointend = new List<Point>();
            Point use = new Point();
            Point a = getpoint(b);
            int temp = 0, temp2 = 0;
            for (int i = a.Y; i < 20; i++)
            {
                if (matran[a.X][i].Text == b.Text)
                {
                    use.X = a.X;
                    use.Y = i;
                    temp++;
                    pointend.Add(use);
                }
                else
                    break;
            }
            int temp1 = 0;
            for (int i = a.Y - 1; i >= 0; i--)
            {
                if (matran[a.X][i].Text == b.Text)
                {
                    use.X = a.X;
                    use.Y = i;
                    temp1++;
                    pointend.Add(use);
                }
                else
                    break;
            }
            if (a.Y - temp1 - 1 >= 0 && matran[a.X][a.Y - temp1 - 1].BackgroundImage != null)
            {
                temp2++;
            }
            if (a.Y + temp + 1 < 20 && matran[a.X][a.Y + temp].BackgroundImage != null)
            {
                temp2++;
            }
            // MessageBox.Show(temp2.ToString());
            if (temp + temp1 >= 5 && temp2 != 2)
            {
                //MessageBox.Show(matran[a.X][a.Y].Text);
                if (b.Text == ".")
                    MessageBox.Show("Kết thúc game! Bên X win");
                else
                    MessageBox.Show("Kết thúc game! Bên O win");
                return true;
            }
            return false;

        }
        bool checkdoc(Button b)
        {
            pointend = new List<Point>();
            Point use = new Point();
            Point a = getpoint(b);
            int temp = 0, temp1 = 0, temp2 = 0;
            for (int i = a.X; i < 20; i++)
            {
                if (matran[i][a.Y].Text == b.Text)
                {
                    use.X = i;
                    use.Y = a.Y;
                    temp++;
                    pointend.Add(use);
                } 
                else
                    break;
            }
            for (int i = a.X - 1; i >= 0; i--)
            {
                if (matran[i][a.Y].Text == b.Text)
                {
                    use.X = i;
                    use.Y = a.Y;
                    temp1++;
                    pointend.Add(use);
                }
                else
                    break;
            }

            if (a.X - temp1 - 1 >= 0 && matran[a.X - temp1 - 1][a.Y].BackgroundImage != null)
            {
                temp2++;
            }
            if (a.X + temp < 20 && matran[a.X + temp][a.Y].BackgroundImage != null)
            {
                temp2++;
            }

            if (temp1 + temp >= 5 && temp2 != 2)
            {
                if (b.Text == ".")
                    MessageBox.Show("Kết thúc game! Bên X win");
                else
                    MessageBox.Show("Kết thúc game! Bên O win");
                return true;
            }
            return false;
        }
        bool checkcheo1(Button b)
        {
            Point a = getpoint(b);
            pointend = new List<Point>();
            Point use = new Point();
            int temp = 0, temp1 = 0, temp2 = 0;
            for (int i = 0; i <= a.X; i++)
            {
                if (a.Y - i < 0 || a.X - i < 0)
                    break;
                if (matran[a.X - i][a.Y - i].Text == b.Text)
                {
                    temp++;
                    use.X = a.X - i;
                    use.Y = a.Y - i;
                    pointend.Add(use);
                }
                else
                    break;
            }
            for (int i = 1; i < 20 - a.X; i++)
            {
                if (a.X + i > 19 || a.Y + i > 19)
                    break;
                if (matran[a.X + i][a.Y + i].Text == b.Text)
                {
                    temp1++;
                    use.X = a.X + i;
                    use.Y = a.Y + i;
                    pointend.Add(use);

                }
                else
                    break;
            }
            if (a.X - temp >= 0 && a.Y - temp >= 0 && matran[a.X - temp][a.Y - temp].BackgroundImage != null)
            {
                temp2++;
            }
            if (a.Y + temp1 + 1 < 20 && a.X + temp1 + 1 < 20 && matran[a.X + temp1 + 1][a.Y + temp1 + 1].BackgroundImage != null)
            {
                temp2++;
            }
            if (temp1 + temp >= 5 && temp2 != 2)
            {
                if (b.Text == ".")
                {
                    MessageBox.Show("Kết thúc game! Bên X win");
                }
                else
                {
                    MessageBox.Show("Kết thúc game! Bên O win");
                }
                return true;
            }
            return false;
        }
        bool checkcheo2(Button b)
        {

            Point a = getpoint(b);
            pointend = new List<Point>();
            Point use = new Point();
            int temp = 0, temp1 = 0, temp2 = 0;
            for (int i = 0; i <= a.X; i++)
            {
                if (a.X - i < 0 || a.Y + i > 19)
                    break;
                if (matran[a.X - i][a.Y + i].Text == b.Text)
                {
                    temp++;
                    use.X = a.X - i;
                    use.Y = a.Y + i;
                    pointend.Add(use);
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 20 - a.X; i++)
            {
                if (a.X + i > 19 || a.Y - i < 0)
                    break;
                if (matran[a.X + i][a.Y - i].Text == b.Text)
                {
                    use.X = a.X + i;
                    use.Y = a.Y - i;
                    pointend.Add(use);
                    temp1++;
                }
                else
                {
                    break;
                }

            }
            if (a.X - temp >= 0 && a.Y + temp < 20 && matran[a.X - temp][a.Y + temp].BackgroundImage != null)
            {
                temp2++;
            }
            if (a.X + temp1 + 1 < 20 && a.Y - temp1 - 1 >= 0 && matran[a.X + temp1 + 1][a.Y - temp1 - 1].BackgroundImage != null)
            {
                temp2++;
            }
            if (temp + temp1 >= 5 && temp2 != 2)
            {
                if (b.Text == ".")
                {
                    MessageBox.Show("Kết thúc game! Bên X win");
                }
                else
                {
                    MessageBox.Show("Kết thúc game! Bên O win");
                }
                return true;
            }
            return false;
        }
        bool endgame(Button b)
        {
            if (checkngang(b))
                return true;
            if (checkdoc(b))
                return true;
            if (checkcheo1(b))
                return true;
            if (checkcheo2(b))
                return true;
            return false;
        }
        void pause()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Button b = matran[i][j];
                    b.Enabled = false;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Button b = matran[pointend[i].X][pointend[i].Y];
                if (b.Text == " ")
                    b.BackgroundImage = Image.FromFile(Application.StartupPath + "\\anh\\O_2.jpg");
                else
                    b.BackgroundImage = Image.FromFile(Application.StartupPath + "\\anh\\X_2.jpg");
            }
        }
        void b_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (chedochoi == 1)
            {
                undo1.Enabled = true;
                stp.Push(getpoint(b));
                if (b.BackgroundImage != null)
                    return;
                if (count == 0)
                {
                    b.BackgroundImage = Image.FromFile(Application.StartupPath + "\\anh\\O.jpg");
                    count = 1;
                    // textBox1.Text = "Đến lượt của X ";
                    pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\anh\\Xdo.jpg");
                    b.Text = " ";
                }
                else
                {
                    b.BackgroundImage = Image.FromFile(Application.StartupPath + "\\anh\\Xdo.jpg");
                    count = 0;
                    //textBox1.Text = "Đến lượt của O";
                    pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\anh\\O.jpg");
                    b.Text = ".";
                }
                if (endgame(b))
                {
                    undo1.Enabled = false;
                    //PP.Enabled = true;
                    //bPC.Enabled = true;
                    pause();
                }
            }
            else
            {
                undo1.Enabled = true;
                if (b.BackgroundImage != null)
                    return;
                b.BackgroundImage = Image.FromFile(Application.StartupPath + "\\anh\\Xdo.jpg");
                b.Text = ".";
                stp.Push(getpoint(b));
                if (endgame(b))
                {
                    undo1.Enabled = false;
                    //PP.Enabled = true;
                    //bPC.Enabled = true;
                    pause();
                    return;
                }
                Point oco = SearchPoint();
                //MessageBox.Show(oco.X.ToString() + " " + oco.Y.ToString());
                Button b1 = matran[oco.X][oco.Y];
                b1.BackgroundImage = b1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\anh\\O.jpg");
                b1.Text = " ";
                stp.Push(getpoint(b1));
                if (endgame(b1))
                {
                    undo1.Enabled = false;
                    //PP.Enabled = true;
                    pause();
                }
            }
        }

        void Newgame()
        {
            if (count == 0&&chedochoi==1)
            {
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\anh\\Xdo.jpg");
                count = 1;
            }
            VeBanCo();
            if (chedochoi == 2)
            {
                Random rd = new Random();
                int a = rd.Next(7, 12);
                int b = rd.Next(7, 12);
                Button b2 = matran[a][b];
                b2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\anh\\O.jpg");
                b2.Text = " ";
            }
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }


        }
        void Undo1()
        {
            if (stp.Count == 0)
            {
                undo1.Enabled = false;
            }
            else if (stp.Count == 1) {
                undo1.Enabled = false;
                Point a = stp.Pop();
                Button b = matran[a.X][a.Y];
                b.BackgroundImage = null;
                b.Text = null;
                if (count == 0)
                {
                    pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\anh\\Xdo.jpg");
                    count = 1;
                }
                else
                {
                    pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\anh\\O.jpg");
                    count = 0;
                }
            }
            else
            {
                Point a = stp.Pop();
                Button b = matran[a.X][a.Y];
                b.BackgroundImage = null;
                b.Text = null;
                if (count == 0)
                {
                    pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\anh\\Xdo.jpg");
                    count = 1;
                }
                else
                {
                    pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\anh\\O.jpg");
                    count = 0;
                }
            }

        }
        void Undo2()
        {
            if (stp.Count == 0)
            {
                undo1.Enabled = false;
            }
            else if (stp.Count == 2)
            {
                undo1.Enabled = false;
                Point a = stp.Pop();
                Button b = matran[a.X][a.Y];
                b.BackgroundImage = null;
                b.Text = null;
                a = stp.Pop();
                b = matran[a.X][a.Y];
                b.BackgroundImage = null;
                b.Text = null;

            }
            else
            {
                Point a = stp.Pop();
                Button b = matran[a.X][a.Y];
                b.BackgroundImage = null;
                b.Text = null;
                a = stp.Pop();
                b = matran[a.X][a.Y];
                b.BackgroundImage = null;
                b.Text = null;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            bNew.Enabled = true;
            PP.Enabled = false;
            bPC.Enabled = true;
            chedochoi = 1;
            Newgame();
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (chedochoi== 1)
            {
                Undo1();
            }
            else
            {
                Undo2();
            }
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            bPC.Enabled = false;
            bNew.Enabled = true;
            PP.Enabled = true;
            chedochoi = 2;
            Newgame();
        }

        # region AI
        long[] PointAttack = new long[7] {0, 12, 54, 162, 1458, 13112, 118008 };
        long[] PointDepense = new long[7] {0, 9, 27, 99, 729, 6561, 59049};
        Point SearchPoint()
        {
            Point use = new Point();
            long Maxpoint = 0;
            long Minpoint = 0;
            for(int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Button b = matran[i][j];
                    if (b.BackgroundImage == null)
                    {
                        long Attack = Attack_Ngang(i, j)+Attack_Doc(i, j) + Attack_Cheo1(i, j) + Attack_Cheo2(i, j);
                        long Defense = Defense_Ngang(i, j) + Defense_Doc(i, j) + Defense_Cheo1(i, j) + Defense_Cheo2(i, j);
                        if (Attack > Defense)
                            Minpoint = Attack;
                        else
                        { 
                            Minpoint = Defense;
                        }
                        if (Maxpoint < Minpoint)
                        {
                            Maxpoint = Minpoint;
                            use.X = i;
                            use.Y = j;
                        }

                    }
                }
            }
            return use;
        }
        long Attack_Ngang(int posX, int posY)
        {

            long sum = 0;
            long countC = 0;
            long countP = 0;
            for(int dem = 1; dem < 6 && posY+dem<20; dem++)
            {
                if (matran[posX][posY + dem].Text == " ")
                {
                    countC++;
                }
                else if (matran[posX][posY + dem].Text == ".")
                {
                    countP++;
                    break;
                }
                else
                    break;
            }
            for (int dem = 1; dem < 6 && posY-dem>=0; dem++)
            {
                if (matran[posX][posY - dem].Text == " ")
                {
                    countC++;
                }
                else if (matran[posX][posY - dem].Text == ".")
                {
                    countP++;
                    break;
                }
                else
                    break;
            }
            if (countP == 2)
            {
                return 0;
            }
            sum -= PointDepense[countP+1];
            sum += PointAttack[countC];
            return sum;
        }
        long Attack_Doc(int posX, int posY)
        {
            long sum = 0;
            long countC = 0;
            long countP = 0;
            for (int i = 1; i < 6 && posX+i < 20; i++)
            {
                if (matran[posX+i][posY].Text == " ")
                {
                    countC++;
                }
                else if (matran[posX+i][posY].Text == ".")
                {
                    countP++;
                    break;
                }
                else
                    break;
            }
            for (int i = 1; i < 6 && posX - i >= 0; i++)
            {
                if (matran[posX-i][posY].Text ==" ")
                {
                    countC++;
                }
                else if (matran[posX-i][posY].Text == ".")
                {
                    countP++;
                    break;
                }
                else
                    break;
            }
            if (countP == 2)
            {
                return 0;
            }
            sum -= PointDepense[countP+1];
            sum += PointAttack[countC];
            return sum;
        }
        long Attack_Cheo1(int posX, int posY)
        {
            long sum = 0;
            long countC = 0;
            long countP = 0;
            for (int i = 1; i < 6 && posY + i < 20&&posX+i<20; i++)
            {
                if (matran[posX+i][posY + i].Text == " ")
                {
                    countC++;
                }
                else if (matran[posX+i][posY + i].Text == ".")
                {
                    countP++;
                    break;
                }
                else
                    break;
            }
            for (int i = 1; i < 6 && posY - i >= 0&& posX-i>=0; i++)
            {
                if (matran[posX-i][posY - i].Text == " ")
                {
                    countC++;
                }
                else if (matran[posX-i][posY -i].Text == ".")
                {
                    countP++;
                    break;
                }
                else
                    break;
            }
            if (countP == 2)
            {
                return 0;
            }
            sum -= PointDepense[countP+1];
            sum += PointAttack[countC];
            return sum;
        }
        long Attack_Cheo2(int posX, int posY)
        {
            long sum = 0;
            long countC = 0;
            long countP = 0;
            for (int i = 1; i < 6 && posY + i < 20&&posX-i>=0; i++)
            {
                if (matran[posX-i][posY + i].Text == " ")
                {
                    countC++;
                }
                else if (matran[posX-i][posY + i].Text == ".")
                {
                    countP++;
                    break;
                }
                else
                    break;
            }
            for (int i = 1; i < 6 && posY - i >= 0&& posX+i<20; i++)
            {
                if (matran[posX+i][posY - i].Text == " ")
                {
                    countC++;
                }
                else if (matran[posX + i][posY - i].Text == ".")
                {
                    countP++;
                    break;
                }
                else
                    break;
            }
            if (countP == 2)
            {
                return 0;
            }
            sum -= PointDepense[countP+1];
            sum += PointAttack[countC];
            return sum;
        }
        long Defense_Ngang(int posX, int posY)
        {
            long sum = 0;
            long countC = 0;
            long countP = 0;
            for (int i = 1; i < 6 && posY + i < 20; i++)
            {
                if (matran[posX][posY + i].Text == " ")
                {
                    countC++;
                    break;
                }
                else if (matran[posX][posY + i].Text == ".")
                {
                    countP++;
                }
                else
                    break;
            }
            for (int i = 1; i < 6 && posY - i >= 0; i++)
            {
                if (matran[posX][posY - i].Text == " ")
                {
                    countC++;
                    break;
                }
                else if (matran[posX][posY - i].Text == ".")
                {
                    countP++;
                }
                else
                    break;
            }
            if (countC == 2)
            {
                return 0;
            }
            sum += PointDepense[countP];
            if (countP == 3)
                sum -= PointDepense[countC + 1];
            else
                sum -= PointDepense[countC];
            return sum;
        }
        long Defense_Doc(int posX, int posY)
        {
            long sum = 0;
            long countC = 0;
            long countP = 0;
            for (int i = 1; i < 6 && posX + i < 20; i++)
            {
                if (matran[posX+i][posY].Text == " ")
                {
                    countC++;
                    break;
                }
                else if (matran[posX+i][posY].Text == ".")
                {
                    countP++;
                }
                else
                    break;
            }
            for (int i = 1; i < 6 && posX - i >= 0; i++)
            {
                if (matran[posX-i][posY].Text == " ")
                {
                    countC++;
                    break;
                }
                else if (matran[posX-i][posY].Text == ".")
                {
                    countP++;
                }
                else
                    break;
            }
            if (countC == 2)
            {
                return 0;
            }
            sum += PointDepense[countP];
            if (countP == 3)
                sum -= PointDepense[countC + 1];
            else
                sum -= PointDepense[countC];
            return sum;
        }
        long Defense_Cheo1(int posX, int posY)
        {
            long sum = 0;
            long countC = 0;
            long countP = 0;
            for (int i = 1; i < 6 && posY + i < 20&&posX+i<20; i++)
            {
                if (matran[posX+i][posY + i].Text == " ")
                {
                    countC++;
                    break;
                }
                else if (matran[posX+i][posY + i].Text == ".")
                {
                    countP++;
                }
                else
                    break;
            }
            for (int i = 1; i < 6 && posY - i >= 0&& posX-i>=0; i++)
            {
                if (matran[posX-i][posY - i].Text == " ")
                {
                    countC++;
                    break;
                }
                else if (matran[posX-i][posY - i].Text == ".")
                {
                    countP++;
                }
                else
                    break;
            }
            if (countC == 2)
            {
                return 0;
            }
            sum += PointDepense[countP];
            if (countP == 3)
                sum -= PointDepense[countC + 1];
            else
                sum -= PointDepense[countC];
            return sum;
        }
        long Defense_Cheo2(int posX, int posY)
        {
            long sum = 0;
            long countC = 0;
            long countP = 0;
            for (int i = 1; i < 6 && posY + i < 20&&posX-i>=0; i++)
            {
                if (matran[posX-i][posY + i].Text == " ")
                {
                    countC++;
                    break;
                }
                else if (matran[posX-i][posY + i].Text == ".")
                {
                    countP++;
                }
                else
                    break;
            }
            for (int i = 1; i < 6 && posY - i >= 0&& posX +i<20; i++)
            {
                if (matran[posX+i][posY - i].Text == " ")
                {
                    countC++;
                    break;
                }
                else if (matran[posX+i][posY - i].Text == ".")
                {
                    countP++;
                }
                else
                    break;
            }
            if (countC == 2)
            {
                return 0;
            }
            sum += PointDepense[countP];
            if (countP == 3)
                sum -= PointDepense[countC + 1];
            else
                sum -= PointDepense[countC];
            return sum;
        }
        #endregion
        private void bNew_Click(object sender, EventArgs e)
        {
            Newgame();
        }
























        private void pictureBox2tureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Banco_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
