using System;
using System.Windows.Forms;

namespace Komis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.DisplayMember = "Name";
            comboBox2.DisplayMember = "Name";
            comboBox4.DisplayMember = "Color";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            comboBox1.DataSource = BrandsBuilder.Brands;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var brand = (Brand) comboBox1.SelectedItem;
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(brand.Models);

            comboBox2.Enabled = true;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            pictureBox1.Image = null;
            comboBox4.Items.Clear();
            comboBox3.Items.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var model = (Brand.Model) comboBox2.SelectedItem;
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(model.Engines);
            
            pictureBox1.Image = null;
            comboBox3.Enabled = true;
            comboBox4.Enabled = false;
            comboBox4.Items.Clear();
        }
        
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var model = (Brand.Model) comboBox2.SelectedItem;
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(model.Cars);
            
            pictureBox1.Image = null;
            comboBox4.Enabled = true;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var car = (Brand.Model.Car) comboBox4.SelectedItem;
            pictureBox1.Image = car.Img;
        }

        
    }
}
