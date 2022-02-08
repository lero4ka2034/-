using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oby4enie
{
    public partial class Form1 : Form
    {
        Point dvig;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name;
            int Price;
            int Quantity;
            try
            {
                if (textBox1.Text.Length > 0 && textBox2.Text.Trim().Length > 0 && textBox3.Text.Trim().Length > 0)
                {

                    Name = textBox1.Text.Trim();
                    Price = int.Parse(textBox2.Text);
                    Quantity = int.Parse(textBox3.Text);

                    listBox1.Items.Add(Name + " " + Price.ToString() + "р. " + Quantity.ToString() + "шт.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - dvig.X;
                this.Top += e.Y - dvig.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            dvig = new Point(e.X, e.Y);
        }
    }
}

//textBox1.Text.Length - говорит сколько у нас символов в textBox1
//listBox1.Items.Add() - добавить к listBox1 то что в скобочках 
//int.Parce - преобразовать в целое