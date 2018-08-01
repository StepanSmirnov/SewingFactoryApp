﻿using SawingFactory.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SawingFactory.Forms
{
    public partial class MaterialsForm : SawingFactory.Forms.BaseNestedForm
    {
        public MaterialsForm()
        {
            InitializeComponent();
        }

        private void MaterialsForm_Load(object sender, EventArgs e)
        {
            using (var context = new FactoryContext())
            {
                materialBindingSource.DataSource = context.Materials.ToList();
            }
        }
    }
}
