using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SawingFactory.Forms
{
    public partial class UnitsWidget : UserControl
    {
        public UnitsWidget()
        {
            InitializeComponent();
        }

        public object Items
        {
            get
            {
                return unitsComboBox.DataSource;
            }
            set
            {
                unitsComboBox.DataSource = value;
            }
        }

        public object CurrentUnit()
        {
            return unitsComboBox.SelectedItem;
        }

        public event EventHandler OnRecalc;

        private void button2_Click(object sender, EventArgs e)
        {
            OnRecalc?.Invoke(sender, e);
        }
    }
}
