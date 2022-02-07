using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace event_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked Me!");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You are on Me!!!!");
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("I'm Loading...");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked Me ...");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            MessageBox.Show("I'm Resizing ...");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // MessageBox.Show("You Pressed a key:"+e.KeyCode.ToString());
            this.Text = e.KeyCode.ToString();
            //if (e.KeyCode==Keys.Escape)
            //{
            //    this.Close();
            //}
            //if (e.KeyCode==Keys.F5)
            //{
            //    button2_Click(sender, e);
            //}
            //if (e.KeyCode==Keys.F4 )
            //{
            //    this.BackColor = Color.Green;
            //}
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.F5:
                    button2_Click(sender, e);
                    break;

                case Keys.F4:
                    this.BackColor = Color.Green;
                    break;
             

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = this.textBox1.Text;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.Yellow;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            this.textBox2.BackColor = Color.Yellow;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            this.textBox3.BackColor = Color.Yellow;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.White;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            this.textBox2.BackColor = Color.White;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            this.textBox3.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I clicked!!!!");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.Yellow;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.LightGray;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.checkBox1.Checked.ToString());
            //////////if (this.checkBox1.Checked == true)
            //////////{
            //////////    MessageBox.Show("You Checked!");
            //////////}
            ////////////------------------------------
            //////////if (this.checkBox1.Checked == false)
            //////////{
            //////////    MessageBox.Show("You Unchecked Me!");
            //////////}
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                MessageBox.Show("You Checked!");
            }
            //------------------------------
            if (this.checkBox1.Checked == false)
            {
                MessageBox.Show("You Unchecked Me!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //////this.textBox1.Text = this.comboBox1.SelectedIndex.ToString();
            //////this.textBox2.Text = this.comboBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("First Select Your Item!!!!");
                return;
            }
            this.textBox1.Text = this.comboBox1.SelectedIndex.ToString();
            this.textBox2.Text = this.comboBox1.Text;
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("First Select Your Item!!!!");
                return;
            }
            this.textBox1.Text = this.listBox1.SelectedIndex.ToString();
            this.textBox2.Text = this.listBox1.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("First Select Your Item!!!!");
                return;
            }
            this.textBox1.Text = this.listBox1.SelectedIndex.ToString();
            this.textBox2.Text = this.listBox1.Text;
        }



        //private void button6_Click(object sender, EventArgs e)
        //{

        //}
    }
}
