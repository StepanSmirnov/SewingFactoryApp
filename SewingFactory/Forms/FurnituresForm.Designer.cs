namespace SawingFactory.Forms
{
    partial class FurnituresForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnitureIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.furnitureIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.widthUnitDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.lengthUnitDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.weightUnitDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.furnitureBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(604, 370);
            this.dataGridView1.TabIndex = 1;
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataSource = typeof(SawingFactory.DAL.Entities.Furniture);
            // 
            // furnitureIdDataGridViewTextBoxColumn
            // 
            this.furnitureIdDataGridViewTextBoxColumn.DataPropertyName = "FurnitureId";
            this.furnitureIdDataGridViewTextBoxColumn.HeaderText = "FurnitureId";
            this.furnitureIdDataGridViewTextBoxColumn.Name = "furnitureIdDataGridViewTextBoxColumn";
            this.furnitureIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // widthUnitDataGridViewTextBoxColumn
            // 
            this.widthUnitDataGridViewTextBoxColumn.DataPropertyName = "WidthUnit";
            this.widthUnitDataGridViewTextBoxColumn.HeaderText = "WidthUnit";
            this.widthUnitDataGridViewTextBoxColumn.Name = "widthUnitDataGridViewTextBoxColumn";
            this.widthUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthUnitDataGridViewTextBoxColumn
            // 
            this.lengthUnitDataGridViewTextBoxColumn.DataPropertyName = "LengthUnit";
            this.lengthUnitDataGridViewTextBoxColumn.HeaderText = "LengthUnit";
            this.lengthUnitDataGridViewTextBoxColumn.Name = "lengthUnitDataGridViewTextBoxColumn";
            this.lengthUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightUnitDataGridViewTextBoxColumn
            // 
            this.weightUnitDataGridViewTextBoxColumn.DataPropertyName = "WeightUnit";
            this.weightUnitDataGridViewTextBoxColumn.HeaderText = "WeightUnit";
            this.weightUnitDataGridViewTextBoxColumn.Name = "weightUnitDataGridViewTextBoxColumn";
            this.weightUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FurnituresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(604, 461);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FurnituresForm";
            this.Load += new System.EventHandler(this.FurnituresForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource furnitureBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}
