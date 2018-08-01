using SawingFactory.DAL.Entities;
using System;
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
    public partial class FurnitureSupplyForm : BaseNestedForm
    {
        public FurnitureSupplyForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                FurnitureStock supply = null;
                if (!ParseRow(row, out supply)) return;
                using (var context = new FactoryContext())
                {
                    var material = context.Furnitures.Single(m => m.FurnitureId == supply.FurnitureId);
                    row.Cells[4].Value = material.Price * supply.Quantity;
                }
            }
        }

        private bool ParseRow(DataGridViewRow row, out FurnitureStock supply)
        {
            supply = new FurnitureStock();
            var id = row.Cells[1].Value;
            if (id == null || id.ToString().Length == 0) return false;
            int count = 0;
            if (!Int32.TryParse(row.Cells[3].Value.ToString(), out count)) return false;
            supply.FurnitureId = id.ToString();
            supply.Quantity = count;
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new FactoryContext())
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    FurnitureStock supply = null;
                    if (!ParseRow(row, out supply)) continue;
                    for (int i = 0; i < supply.Quantity; ++i)
                    {
                        var stock = new FurnitureStock(context.Furnitures.Single(m => m.FurnitureId == supply.FurnitureId));
                        context.FurnitureStocks.Add(stock);
                    }
                }
                context.SaveChanges();
                MessageBox.Show("Данные успешно сохранены");
            }
        }

        private void FurnitureSupplyForm_Load(object sender, EventArgs e)
        {
            using (var context = new FactoryContext())
            {
                context.Furnitures.Load();
                furnitureBindingSource.DataSource = context.Furnitures.Local.ToBindingList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
