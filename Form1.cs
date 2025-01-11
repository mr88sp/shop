using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void hesabkarbari_MouseDown(object sender, MouseEventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void sabadkharid_MouseDown(object sender, MouseEventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;

        }

        private void foroshgah_MouseDown(object sender, MouseEventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }


        private void darbarema_MouseDown(object sender, MouseEventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;

        }

        private void bishtar_MouseDown(object sender, MouseEventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                
                Clipboard.SetText(clickedLabel.Text);
        
                MessageBox.Show($"متن در کلیپ بورد کپی شد");
            }
        }

        private void label11_MouseClick(object sender, MouseEventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                Clipboard.SetText(clickedLabel.Text);

                MessageBox.Show($"متن در کلیپ بورد کپی شد");
            }
        }

        private void label12_MouseClick(object sender, MouseEventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                Clipboard.SetText(clickedLabel.Text);

                MessageBox.Show($"متن در کلیپ بورد کپی شد");
            }
        }

        private void label13_MouseClick(object sender, MouseEventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                Clipboard.SetText(clickedLabel.Text);
                
                MessageBox.Show($"متن در کلیپ بورد کپی نشد");
            } 
        }
    }
}
