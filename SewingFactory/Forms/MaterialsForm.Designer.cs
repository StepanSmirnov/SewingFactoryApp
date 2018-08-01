namespace SawingFactory.Forms
{
    partial class MaterialsForm
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
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patternDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.consistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.patternDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.consistDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.widthUnitDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.lengthUnitDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materialBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(604, 370);
            this.dataGridView1.TabIndex = 1;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(SawingFactory.DAL.Entities.Material);
            // 
            // materialIdDataGridViewTextBoxColumn
            // 
            this.materialIdDataGridViewTextBoxColumn.DataPropertyName = "MaterialId";
            this.materialIdDataGridViewTextBoxColumn.HeaderText = "MaterialId";
            this.materialIdDataGridViewTextBoxColumn.Name = "materialIdDataGridViewTextBoxColumn";
            this.materialIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patternDataGridViewTextBoxColumn
            // 
            this.patternDataGridViewTextBoxColumn.DataPropertyName = "Pattern";
            this.patternDataGridViewTextBoxColumn.HeaderText = "Pattern";
            this.patternDataGridViewTextBoxColumn.Name = "patternDataGridViewTextBoxColumn";
            this.patternDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // consistDataGridViewTextBoxColumn
            // 
            this.consistDataGridViewTextBoxColumn.DataPropertyName = "Consist";
            this.consistDataGridViewTextBoxColumn.HeaderText = "Consist";
            this.consistDataGridViewTextBoxColumn.Name = "consistDataGridViewTextBoxColumn";
            this.consistDataGridViewTextBoxColumn.ReadOnly = true;
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
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(604, 461);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MaterialsForm";
            this.Load += new System.EventHandler(this.MaterialsForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patternDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}
