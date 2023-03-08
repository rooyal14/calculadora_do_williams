using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_do_williams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(textBox2.Text) == 0 && comboBox1.SelectedItem.ToString() == "Divisão")
            {
                textBox3.Text = "Impossível dividir por zero";
                return;
            }

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Soma":
                    textBox3.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)).ToString();
                    break;
                case "Subtração":
                    textBox3.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text)).ToString();
                    break;
                case "Multiplicação":
                    textBox3.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
                    break;
                case "Divisão":
                    textBox3.Text = Convert.ToDouble(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString();
                    break;

            }
        }
    }
}
