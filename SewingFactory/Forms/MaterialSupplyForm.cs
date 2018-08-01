using SawingFactory.DAL.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SawingFactory.Forms
{
    public partial class MaterialSupplyForm : BaseNestedForm
    {
        public MaterialSupplyForm()
        {
            InitializeComponent();
        }

        private void MaterialSupplyForm_Load(object sender, EventArgs e)
        {
            using (var context = new FactoryContext())
            {
                context.Materials.Load();
                materialBindingSource.DataSource = context.Materials.Local.ToBindingList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new FactoryContext())
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    MaterialSupply supply = null;
                    if (!ParseRow(row, out supply)) continue;
                    for (int i=0; i< supply.Quantity; ++i)
                    {
                        var roll = new MaterialRoll(context.Materials.Single(m => m.MaterialId == supply.MaterialId));
                        context.MaterialRolls.Add(roll);
                    }
                }
                context.SaveChanges();
                MessageBox.Show("Данные успешно сохранены");
            }
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex > -1)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                MaterialSupply supply = null;
                if (!ParseRow(row, out supply)) return;
                using (var context = new FactoryContext())
                {
                    var material = context.Materials.Single(m => m.MaterialId == supply.MaterialId);
                    row.Cells[3].Value = material.Price * supply.Quantity;
                }
            }
        }

        private bool ParseRow(DataGridViewRow row, out MaterialSupply supply)
        {
            supply = new MaterialSupply();
            var id = row.Cells[0].Value;
            if (id == null || id.ToString().Length == 0) return false;
            int count = 0;
            if (!Int32.TryParse(row.Cells[2].Value.ToString(), out count)) return false;
            supply.MaterialId = id.ToString();
            supply.Quantity = count;
            return true;
        }
    }
}
