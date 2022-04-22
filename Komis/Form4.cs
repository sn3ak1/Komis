using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Komis
{
    public partial class Form4 : Form
    {
        public Form4()
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
            
            comboBox1.Items.AddRange(UsedCarDeserializer.Cars.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var car = (UsedCar) comboBox1.SelectedItem;
            car.Reservations.Add(
                new UsedCar.Reservation(monthCalendar1.SelectionStart, textBox1.Text, textBox2.Text));
            monthCalendar1.AddBoldedDate(monthCalendar1.SelectionStart);
            var temp = new List<DateTime>();
            temp.AddRange(monthCalendar1.BoldedDates);
            temp.Add(monthCalendar1.SelectionStart);
            monthCalendar1.BoldedDates = temp.ToArray();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var car = (UsedCar) comboBox1.SelectedItem;
            var dates = new List<DateTime>();
            car.Reservations.ForEach(r => dates.Add(r.Date));
            monthCalendar1.BoldedDates = dates.ToArray();
            monthCalendar1.Enabled = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var car = (UsedCar) comboBox1.SelectedItem;

            if (!monthCalendar1.BoldedDates.Contains(monthCalendar1.SelectionStart))
            {
                if(textBox1.Text != "" && textBox2.Text != "" )
                    button1.Enabled = true;
                else
                {
                    button1.Enabled = false;
                }
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                button1.Enabled = false;

                bool FindRes(UsedCar.Reservation r)
                {
                    if (r.Date == null) return false;
                    return r.Date == monthCalendar1.SelectionStart;
                }

                textBox1.Text = car.Reservations.Find(FindRes).Name;
                textBox2.Text = car.Reservations.Find(FindRes).Surname;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!monthCalendar1.BoldedDates.Contains(monthCalendar1.SelectionStart)
                &&textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}