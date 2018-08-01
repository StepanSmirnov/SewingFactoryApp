using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SawingFactory.Forms
{
    public partial class ProductsConstructorForm : SawingFactory.Forms.BaseNestedForm
    {
        private bool drag_started;

        public ProductsConstructorForm()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            pictureBox2.Width = (int)numericUpDown2.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pictureBox2.Height = (int)numericUpDown1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ProductsConstructorForm_Load(object sender, EventArgs e)
        {
            pictureBox2_Resize(sender, e);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            var diff = Point.Subtract(e.Location, pictureBox2.Size);
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
            var diff = Point.Subtract(e.Location, pictureBox2.Size);
            if (!drag_started && diff.X * diff.X + diff.Y * diff.Y < 15 * 15)
            {
                Cursor.Current = Cursors.SizeNWSE;
            }
            else if (drag_started && e.X > 0 && e.Y > 0)
            {
                pictureBox2.Width = e.X;
                pictureBox2.Height = e.Y;
            }
        }

        private void ProductsConstructorForm_Paint(object sender, PaintEventArgs e)
        {
            //if (drag_started)
            //{
            //    var rect = new Rectangle(pictureBox2.Location + pictureBox2.Size, new Size(20, 20));
            //    //rect.Offset(-5, -5);
            //    e.Graphics.FillEllipse(Brushes.Red, rect);
            //    e.Graphics.Flush();
            //}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Resize(object sender, EventArgs e)
        {
            numericUpDown2.Value = pictureBox2.Width;
            numericUpDown1.Value = pictureBox2.Height;
        }
    }
}
