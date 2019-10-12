using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Iinv2Client cliente = new ServiceReference1.Iinv2Client())
            {
                cliente.guardar(Int32.Parse(textBox1.Text), textBox2.Text, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), textBox5.Text);
            }
            listBox1.Items.Add(textBox1.Text + ' ' + textBox2.Text + ' ' + Int32.Parse(textBox3.Text) + ' ' + Int32.Parse(textBox4.Text) + ' ' + textBox5.Text + ' ');
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] vector = new string[5];
            using (ServiceReference1.Iinv2Client cliente = new ServiceReference1.Iinv2Client())
            {
                try
                {
                    vector = cliente.buscar(Convert.ToInt32(textBox1.Text));
                    textBox2.Text = vector[1];
                    textBox3.Text = vector[2];
                    textBox4.Text = vector[3];
                    textBox5.Text = vector[4];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Producto no encontrado");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Iinv2Client cliente = new ServiceReference1.Iinv2Client())
            {
                textBox6.Text = cliente.toText(Convert.ToDouble(textBox3.Text));
            }

        }

        
    }
}
