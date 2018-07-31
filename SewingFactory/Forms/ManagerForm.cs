using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SawingFactory.Forms
{
    public partial class ManagerForm : BaseMenuForm
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        public ManagerForm(BaseForm baseForm) : base(baseForm)
        {
            InitializeComponent();
        }
    }
}
