using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_HW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) textBox1.Text = "1.20";
            else if (comboBox1.SelectedIndex == 1) textBox1.Text = "1.50";
            else if (comboBox1.SelectedIndex == 2) textBox1.Text = "1.80";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Enabled = true;
                textBox3.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Enabled = false;
                textBox3.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label6.Text = (float.Parse(textBox1.Text) * float.Parse(textBox2.Text)).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label6.Text = textBox3.Text;
        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            label10.Text = (float.Parse(label9.Text) + float.Parse(label6.Text)).ToString();
        }

        private void label6_TextChanged(object sender, EventArgs e)
        {
            label10.Text = (float.Parse(label9.Text) + float.Parse(label6.Text)).ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) textBox9.Enabled = true;
            else textBox9.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) textBox8.Enabled = true;
            else textBox8.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) textBox10.Enabled = true;
            else textBox10.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) textBox11.Enabled = true;
            else textBox11.Enabled = false;
        }

        private void count_TextChanged(object sender, EventArgs e)
        {
            label9.Text = "0";

            if (textBox8.Enabled && textBox8.Text.Length > 0) label9.Text = (float.Parse(label9.Text) + float.Parse(textBox8.Text) * float.Parse(textBox7.Text)).ToString();
            if (textBox9.Enabled && textBox9.Text.Length > 0) label9.Text = (float.Parse(label9.Text) + float.Parse(textBox9.Text) * float.Parse(textBox4.Text)).ToString();
            if (textBox10.Enabled && textBox10.Text.Length > 0) label9.Text = (float.Parse(label9.Text) + float.Parse(textBox10.Text) * float.Parse(textBox6.Text)).ToString();
            if (textBox11.Enabled && textBox11.Text.Length > 0) label9.Text = (float.Parse(label9.Text) + float.Parse(textBox11.Text) * float.Parse(textBox5.Text)).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            dayOfWeekToolStripMenuItem.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if(trackBar1.Value == 1)
            {
                this.BackColor = Color.FromArgb(0, 0, 0);
                groupBox1.BackColor = Color.FromArgb(0, 0, 0);
                groupBox2.BackColor = Color.FromArgb(0, 0, 0);
                groupBox3.BackColor = Color.FromArgb(0, 0, 0);
                groupBox4.BackColor = Color.FromArgb(0, 0, 0);
                groupBox5.BackColor = Color.FromArgb(0, 0, 0);
                groupBox6.BackColor = Color.FromArgb(0, 0, 0);
                statusStrip1.BackColor = Color.FromArgb(0, 0, 0);
                this.ForeColor = Color.FromArgb(255, 255, 255);
                groupBox1.ForeColor = Color.FromArgb(255, 255, 255);
                groupBox2.ForeColor = Color.FromArgb(255, 255, 255);
                groupBox3.ForeColor = Color.FromArgb(255, 255, 255);
                groupBox4.ForeColor = Color.FromArgb(255, 255, 255);
                groupBox5.ForeColor = Color.FromArgb(255, 255, 255);
                groupBox6.ForeColor = Color.FromArgb(255, 255, 255);
                statusStrip1.ForeColor = Color.FromArgb(255, 255, 255);

            }
            else if (trackBar1.Value == 0)
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
                groupBox1.BackColor = Color.FromArgb(255, 255, 255);
                groupBox2.BackColor = Color.FromArgb(255, 255, 255);
                groupBox3.BackColor = Color.FromArgb(255, 255, 255);
                groupBox4.BackColor = Color.FromArgb(255, 255, 255);
                groupBox5.BackColor = Color.FromArgb(255, 255, 255);
                groupBox6.BackColor = Color.FromArgb(255, 255, 255);
                statusStrip1.BackColor = Color.FromArgb(255, 255, 255);
                this.ForeColor = Color.FromArgb(0, 0, 0);
                groupBox1.ForeColor = Color.FromArgb(0, 0, 0);
                groupBox2.ForeColor = Color.FromArgb(0, 0, 0);
                groupBox3.ForeColor = Color.FromArgb(0, 0, 0);
                groupBox4.ForeColor = Color.FromArgb(0, 0, 0);
                groupBox5.ForeColor = Color.FromArgb(0, 0, 0);
                groupBox6.ForeColor = Color.FromArgb(0, 0, 0);
                statusStrip1.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
            groupBox1.BackColor = Color.FromArgb(255, 255, 255);
            groupBox2.BackColor = Color.FromArgb(255, 255, 255);
            groupBox3.BackColor = Color.FromArgb(255, 255, 255);
            groupBox4.BackColor = Color.FromArgb(255, 255, 255);
            groupBox5.BackColor = Color.FromArgb(255, 255, 255);
            groupBox6.BackColor = Color.FromArgb(255, 255, 255);
            statusStrip1.BackColor = Color.FromArgb(255, 255, 255);
            this.ForeColor = Color.FromArgb(0, 0, 0);
            groupBox1.ForeColor = Color.FromArgb(0, 0, 0);
            groupBox2.ForeColor = Color.FromArgb(0, 0, 0);
            groupBox3.ForeColor = Color.FromArgb(0, 0, 0);
            groupBox4.ForeColor = Color.FromArgb(0, 0, 0);
            groupBox5.ForeColor = Color.FromArgb(0, 0, 0);
            groupBox6.ForeColor = Color.FromArgb(0, 0, 0);
            statusStrip1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
    }
}
