using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Dosya oluşturup son oynanan oyunu tutmaya çalştım.
            string oynamasirasi = "";
            Directory.CreateDirectory("C:SudeTopal");
            FileStream fs = File.Create(@"C:\SudeTopal\metinbelgesi.txt");
            StreamReader sw = new StreamReader(fs);
            oynamasirasi = sw.ReadLine();
            sw.Close();
            fs.Close();
            if (oynamasirasi == "X")
            {
                label1.Text = "Sıradaki Oyuncu:O";

            }
            else
                label1.Text = "Sıradaki Oyuncu:X";
            


        }
       
        //Butonlara X ve O ları bastırdım.
        //Labelda sıradaki oyuncuyu gösterdim.
        int XorO = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(XorO %2==0)
            {
                button1.Text = "X";
                label1.Text = "Sıradaki Oyuncu=O";
                button1.Enabled = false;
            }
           
           
            else
            {
                button1.Text = "O";
                label1.Text = "Sıradaki Oyuncu=X";
                button1.Enabled = false;
            }
            XorO++;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (XorO % 2 == 0)
            {
                button2.Text = "X";
                label1.Text = "Sıradaki Oyuncu=O";
                button2.Enabled = false;
            }
            else
            {
                button2.Text = "O";
                label1.Text = "Sıradaki Oyuncu=X";
                button2.Enabled = false;
            }
            XorO++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (XorO % 2 == 0)
            {
                button3.Text = "X";
                label1.Text = "Sıradaki Oyuncu=O";
                button3.Enabled = false;
            }
            else
            {
                button3.Text = "O";
                label1.Text = "Sıradaki Oyuncu=X";
                button3.Enabled = false;
            }
            XorO++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (XorO % 2 == 0)
            {
                button4.Text = "X";
                label1.Text = "Sıradaki Oyuncu=O";
                button4.Enabled = false;
            }
            else
            {
                button4.Text = "O";
                label1.Text = "Sıradaki Oyuncu=X";
                button4.Enabled = false;
            }
            XorO++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (XorO % 2 == 0)
            {
                button5.Text = "X";
                label1.Text = "Sıradaki Oyuncu=O";
                button5.Enabled = false;
            }
            else
            {
                button5.Text = "O";
                label1.Text = "Sıradaki Oyuncu=X";
                button5.Enabled = false;
            }
            XorO++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (XorO % 2 == 0)
            {
                button6.Text = "X";
                label1.Text = "Sıradaki Oyuncu=O";
                button6.Enabled = false;
            }
            else
            {
                button6.Text = "O";
                label1.Text = "Sıradaki Oyuncu=X";
                button6.Enabled = false;
            }
            XorO++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (XorO % 2 == 0)
            {
                button7.Text = "X";
                label1.Text = "Sıradaki Oyuncu=O";
                button7.Enabled = false;
            }
            else
            {
                button7.Text = "O";
                label1.Text = "Sıradaki Oyuncu=X";
                button7.Enabled = false;
            }
            XorO++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (XorO % 2 == 0)
            {
                button8.Text = "X";
                label1.Text = "Sıradaki Oyuncu=O";
                button8.Enabled = false;
            }
            else
            {
                button8.Text = "O";
                label1.Text = "Sıradaki Oyuncu=X";
                button8.Enabled = false;
            }
            XorO++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (XorO % 2 == 0)
            {
                button9.Text = "X";
                label1.Text = "Sıradaki Oyuncu=O";
                button9.Enabled = false;
            }
            else
            {
                button9.Text = "O";
                label1.Text = "Sıradaki Oyuncu=X";
                button9.Enabled = false;
            }
            XorO++;
            //if else if ile kazanan oyuncuyu belirledim.
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X Oyuncusu Kazandı");
            }
            else if(button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X Oyuncusu Kazandı");
            }
            else if(button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X Oyuncusu Kazandı");
            }
            else if(button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X Oyuncusu Kazandı");
            }
            else if(button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X Oyuncusu Kazandı");
            }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X Oyuncusu Kazandı");
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X Oyuncusu Kazandı");
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X Oyuncusu Kazandı");
            }

           else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O Oyuncusu Kazandı");
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O Oyuncusu Kazandı");
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O Oyuncusu Kazandı");
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O Oyuncusu Kazandı");
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O Oyuncusu Kazandı");
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O Oyuncusu Kazandı");
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O Oyuncusu Kazandı");
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O Oyuncusu Kazandı");
            }


            else
            {
                //Beraberlik durumuna baktım ve yeni oyun başlattım.
               MessageBox.Show("Oyun Berabere");
                button1.Text = "";    
                button1.Enabled = true;
                button2.Text = ""; 
                button2.Enabled = true;
                button3.Text = "";   
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }

}
        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geliştirici:Sude Topal");//Hakkında kısmına bilgilerimi girdim.
                          
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//Çıkış yaptım.
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Yeni oyun başlattım.
            button1.Text = "";
            button1.Enabled = true;
            button2.Text = "";
            button2.Enabled = true;
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
            button9.Text = "";
            button9.Enabled = true;

        }
     



}
}
