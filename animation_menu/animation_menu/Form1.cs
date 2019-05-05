using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animation_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int id = 0;
        Form2 frm2 = new Form2();

        

        private void button1_Click(object sender, EventArgs e)
        {
            //timer5.Start();
        }

        #region "animation"
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Left -= 7;
            label1.Left -= 7;
            if (panel1.Left <= 300)
            {
                timer2.Start();
            }
            if (panel2.Left <= 300)
            {
                timer3.Start();
            }
            if (panel3.Left <= 300)
            {
                timer4.Start();
            }
            if (panel1.Left <= 22)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Left -= 7;
            label2.Left -= 7;
            if (panel2.Left <= 22)
            {
                timer2.Stop();
            }    

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel3.Left -= 7;
            label3.Left -= 7;
            if (panel3.Left <= 22)
            {
                timer3.Stop();
            } 
 
        }
 

        private void timer4_Tick(object sender, EventArgs e)
        {
            panel4.Left -= 7;
            label4.Left -= 7;
            if (panel4.Left <= 22)
            {
                timer4.Stop();
                label8.Show();
                panel6.Show();
                id = 0;
            }  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Left = 350;
            //this.Top = 300;
        }

        

        private void timer5_Tick(object sender, EventArgs e)
        {
            panel1.Left += 7;
            label1.Left += 7;
            if (panel1.Left >= 62)
            {
                timer6.Start();
            }

            if (panel2.Left >= 62)
            {
                timer7.Start();
            }
            if (panel3.Left >= 62)
            {
                timer8.Start();
            }
            if (panel1.Left >= 344)
            {
                timer5.Stop();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            panel2.Left += 7;
            label2.Left += 7;
            if (panel2.Left >= 344)
            {
                timer6.Stop();
            }  
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            panel3.Left += 7;
            label3.Left += 7;
            if (panel3.Left >= 344)
            {
                timer7.Stop();
            }  
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            panel4.Left += 7;
            label4.Left += 7;
            if (panel4.Left >= 344)
            {
                timer8.Stop();
                label8.Hide();
                panel6.Hide();

                panel5.Show();
                label5.Show();
                textBox1.Show();
                textBox1.Text = "admin";
                rectangleShape1.Show();
                panel5.BackgroundImage = Properties.Resources.act;
            }  
        }

        #endregion

        private void panel5_Click(object sender, EventArgs e)
        {
            if (id == 1)
            {
                timer1.Start();
                panel5.Hide();
                label5.Hide();
                textBox1.Hide();
                rectangleShape1.Hide();
            }

            if (textBox1.Text == "ucuzoyuncun")
            {
                panel5.BackgroundImage = Properties.Resources._1450252986_Key;
                textBox1.Hide();
                rectangleShape1.Hide();
                id = 1;
            }

            else
            {
                textBox1.Text = "incorrect!";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "ucuzoyuncun")
                {
                    panel5.BackgroundImage = Properties.Resources._1450252986_Key;
                    textBox1.Hide();
                    rectangleShape1.Hide();
                    id = 1;
                }
                else
                {
                    textBox1.Text = "incorrect!";
                }
            }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void panel6_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }
        


        //menu
        private void label1_Click(object sender, EventArgs e)
        {
            frm2.Show();
            frm2.title = "Profile";
            frm2.img = Properties.Resources._1450248235_neck_tie;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frm2.Show();
            frm2.title = "Dashboard";
            frm2.img = Properties.Resources._1450248230_monitor_graphs;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frm2.Show();
            frm2.title = "Database";
            frm2.img = Properties.Resources._1450249056_database_gear;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frm2.Show();
            frm2.title = "System";
            frm2.img = Properties.Resources._1450252434_Coding_Html;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
