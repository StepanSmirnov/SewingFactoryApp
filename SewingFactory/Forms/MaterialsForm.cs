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
    public partial class MaterialsForm : BaseNestedForm
    {
        public MaterialsForm()
        {
            InitializeComponent();
        }

        public MaterialsForm(BaseForm baseForm) : base(baseForm)
        {
            InitializeComponent();
        }

        private void MaterialsForm_Load(object sender, EventArgs e)
        {
            DbContext_.Materials.Load();
            dataGridView1.DataSource = DbContext_.Materials.Local.ToBindingList(); ;
        }
    }
}
