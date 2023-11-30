using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                pictureBox1.ImageLocation = @"C:\Users\ilezt\Downloads\Калькулятор объемов (1)\Калькулятор объемов\___ Для КТ17\Без названия.png";
            }
            if (radioButton5.Checked)
            {
                pictureBox1.ImageLocation = @"C:\Users\ilezt\Downloads\Калькулятор объемов (1)\Калькулятор объемов\___ Для КТ17\130.png";
            }
            if (radioButton6.Checked)
            {
                pictureBox1.ImageLocation = @"C:\Users\ilezt\Downloads\Калькулятор объемов (1)\Калькулятор объемов\___ Для КТ17\6594bf79a2be76273fbe8a9b3ac3e2de.jpeg";
            }
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.ImageLocation = @"C:\Users\ilezt\Downloads\Калькулятор объемов (1)\Калькулятор объемов\___ Для КТ17\Без названия.png";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.ImageLocation = @"C:\Users\ilezt\Downloads\Калькулятор объемов (1)\Калькулятор объемов\___ Для КТ17\130.png";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.ImageLocation = @"C:\Users\ilezt\Downloads\Калькулятор объемов (1)\Калькулятор объемов\___ Для КТ17\6594bf79a2be76273fbe8a9b3ac3e2de.jpeg";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
            textBox3.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\ilezt\Downloads\Калькулятор объемов (1)\Калькулятор объемов\___ Для КТ17\Без названия (1).png";

            groupBox1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked & radioButton4.Checked)
            {
                label6.Text = ((1.0 / 3) * ((Math.Sqrt(3) * ((Math.Pow(Convert.ToUInt32(textBox1.Text), 2)))) / 4) * (Math.Pow(Convert.ToUInt32(textBox2.Text), 3))).ToString();
            }
            if (radioButton1.Checked & radioButton5.Checked)
            {
                label6.Text = ((1.0 / 3) * Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (radioButton1.Checked & radioButton6.Checked)
            {
               label6.Text = ((1.0 / 3) * ((Math.Sqrt(3) * (5*(Math.Pow(Convert.ToUInt32(textBox1.Text), 2)))) / 4) * (Math.Pow(Convert.ToUInt32(textBox2.Text), 3))).ToString();
            }
            if (radioButton3.Checked)
            {
                label6.Text = ((4 / 3) * (Math.PI) * Math.Pow(Convert.ToUInt32(textBox3.Text), 3)).ToString();
            }
            if (radioButton2.Checked & radioButton4.Checked)
            {
                label6.Text = ((Math.Sqrt(3) * (Math.Pow(Convert.ToUInt32(textBox1.Text), 2))) / 4 * (Convert.ToInt32(textBox2.Text))).ToString();
            }
            if (radioButton2.Checked & radioButton5.Checked)
            {
                label6.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (radioButton2.Checked & radioButton6.Checked)
            {
                label6.Text = ((5 * Math.Sqrt(3) * Math.Pow(Convert.ToUInt32(textBox1.Text), 2)) / 4 * Convert.ToInt32(textBox2.Text)).ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                pictureBox1.ImageLocation = @"C:\Users\ilezt\Downloads\Калькулятор объемов (1)\Калькулятор объемов\___ Для КТ17\1109f28f636c033a39219712f3fe0d3c.jpg";
            }
            if (radioButton5.Checked)
            {
                pictureBox1.ImageLocation = @"C:\Users\ilezt\Downloads\Калькулятор объемов (1)\Калькулятор объемов\___ Для КТ17\fullsize.png";
            }
            if (radioButton6.Checked)
            {
                pictureBox1.ImageLocation = @"C:\Users\ilezt\Downloads\Калькулятор объемов (1)\Калькулятор объемов\___ Для КТ17\ploshad-osnovaniia-prizmy-ot-treygolnoi-do-mnogoygolnoi_4.jpg";
            }
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            groupBox1.Enabled = true;
        }
    }
}
