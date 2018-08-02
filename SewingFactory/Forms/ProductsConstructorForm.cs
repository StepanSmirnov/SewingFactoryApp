using SawingFactory.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SawingFactory.Forms
{
    public partial class ProductsConstructorForm : SawingFactory.Forms.BaseNestedForm
    {
        private const decimal scale = 0.25M;
        private bool drag_started;

        public ProductsConstructorForm()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            productPicture.Width = (int)(widthEdit.Value / scale);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            productPicture.Height = (int)(lengthEdit.Value / scale);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;
            using (var context = new FactoryContext())
            {
                Material material = context.Materials.Single(m => m.MaterialId == comboBox1.SelectedValue.ToString());
                var prod = new Product();
                prod.Materials.Add(material);
                prod.ProductId = DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss");
                prod.Width = (double)widthEdit.Value;
                prod.Length = (double)lengthEdit.Value;
                prod.WidthUnit = "см";
                prod.LengthUnit = "см";
                //Возможна ли здесь sql-инъекция?
                prod.Name = nameEdit.Text;
                context.Products.Add(prod);
                context.SaveChanges();
                MessageBox.Show("Новое изделие успешно создано");
            }
        }

        private void ProductsConstructorForm_Load(object sender, EventArgs e)
        {
            using (var context = new FactoryContext())
            {
                context.Materials.Load();
                materialBindingSource.DataSource = context.Materials.Local.ToBindingList();
            }
            comboBox1.SelectedIndex = 1;
            pictureBox2_Resize(sender, e);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            var diff = Point.Subtract(e.Location, productPicture.Size);
            if (diff.X * diff.X + diff.Y * diff.Y < 15 * 15)
            {
                drag_started = true;
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            drag_started = false;
            Cursor.Current = Cursors.Default;

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            var diff = Point.Subtract(e.Location, productPicture.Size);
            if (!drag_started && diff.X * diff.X + diff.Y * diff.Y < 15 * 15)
            {
                Cursor.Current = Cursors.SizeNWSE;
            }
            else if (drag_started && e.X > 0 && e.Y > 0)
            {
                productPicture.Width = (int)Math.Min(e.X , widthEdit.Maximum / scale);
                productPicture.Height = (int)Math.Min(e.Y , lengthEdit.Maximum / scale);
            }
        }

        private void pictureBox2_Resize(object sender, EventArgs e)
        {
            try
            {
            widthEdit.Value = productPicture.Width * scale;
            lengthEdit.Value = productPicture.Height * scale;
            }
            catch (ArgumentOutOfRangeException)
            {
                CropImage();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            using (var context = new FactoryContext())
            {
                if (comboBox1.SelectedValue == null) return;
                Material material = context.Materials.Single(m => m.MaterialId == comboBox1.SelectedValue.ToString());
                widthEdit.Maximum = (decimal)material.Width;
                lengthEdit.Maximum = (decimal)material.Length;
                if (material.Image != null)
                {
                    MemoryStream s = new MemoryStream(material.Image);
                    productPicture.BackgroundImage = Image.FromStream(s);
                    CropImage();
                    Invalidate();
                }
                else
                {
                    MessageBox.Show("Для данной ткани нет изображения");
                }
            }
        }

        private void CropImage()
        {
            pictureBox1.Width = (int)Math.Min(pictureBox1.Width * scale, widthEdit.Maximum);
            pictureBox1.Height = (int)Math.Min(pictureBox1.Height * scale, lengthEdit.Maximum);
        }

    }
}
