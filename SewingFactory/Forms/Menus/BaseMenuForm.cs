using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SawingFactory.Forms
{
    public partial class BaseMenuForm : BaseForm
    {
        public BaseMenuForm()
        {
            InitializeComponent();
        }

        public BaseMenuForm(BaseForm baseForm) : base(baseForm)
        {
            InitializeComponent();
        }

        protected void AddMenuItem(string text, EventHandler handler)
        {
            var item = new ToolStripButton(text);
            item.Click += handler;
            toolStrip1.Items.Add(item);
        }

        protected void ShowNestedForm(BaseNestedForm form)
        {
            panel2.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            panel2.Controls.Add(form);
            form.Show();
        }
    }
}
