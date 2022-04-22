using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Komis
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.FormClosed += (s, args) =>
            {
                var serializer = new XmlSerializer(UsedCarDeserializer.Cars.GetType(), "Cars");
                using (var writer = new StreamWriter("Cars.xml", false))
                {
                    serializer.Serialize(writer.BaseStream, UsedCarDeserializer.Cars);
                }
            };
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" 
                && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
        
        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var car = new UsedCar(textBox1.Text, textBox2.Text, textBox3.Text, 
                Convert.ToInt32(textBox4.Text),Convert.ToInt32(textBox5.Text), textBox6.Text);
            UsedCarDeserializer.Cars.Add(car);
            Reset();
        }

        private void Reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}