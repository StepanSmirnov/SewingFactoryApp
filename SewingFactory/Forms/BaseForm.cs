using SawingFactory.Entities;
using System;
using System.Windows.Forms;

namespace SawingFactory
{
    public partial class BaseForm : Form
    {
        protected FactoryContext DbContext_;
        public BaseForm()
        {
            InitializeComponent();
            DbContext_ = new FactoryContext();
        }

        public BaseForm(BaseForm baseForm)
        {
            InitializeComponent();
            PrevForm_ = baseForm;
            DbContext_ = new FactoryContext();
        }

        public void Back()
        {
            if (PrevForm_ == null) return;
            PrevForm_.Show();
            Hide();
        }

        public void Open()
        {
            if (PrevForm_ == null) return;
            Show();
            PrevForm_.Hide();
        }

        protected BaseForm PrevForm_ { get; set; }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (PrevForm_ == null) return;
            PrevForm_.Close();
        }
    }
}
