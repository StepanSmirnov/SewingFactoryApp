using SawingFactory.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SawingFactory.Forms
{
    public partial class MaterialStockForm : BaseNestedForm
    {
        public MaterialStockForm()
        {
            InitializeComponent();
        }

        public MaterialStockForm(BaseForm baseForm) : base(baseForm)
        {
            InitializeComponent();
        }

        private void MaterialsForm_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            var query = DbContext_.MaterialRolls
                .GroupBy(roll => roll.MaterialId).AsEnumerable()
                .Select(group => new { MaterialId = group.Key, Count = group.Count(), Area = group.Sum(m => m.Area), Price = group.Sum(m => m.Price) });
            dataGridView1.DataSource = query.ToList();
        }

    }
}
