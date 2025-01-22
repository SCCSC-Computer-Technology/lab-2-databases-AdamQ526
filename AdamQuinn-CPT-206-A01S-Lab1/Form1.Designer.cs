namespace AdamQuinn_CPT_206_A01S_Lab1
{
    partial class Form1
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
            this.populationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.populationDataSet = new AdamQuinn_CPT_206_A01S_Lab1.PopulationDataSet();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAvgPop = new System.Windows.Forms.Button();
            this.btnTotalPop = new System.Windows.Forms.Button();
            this.btnMaxPop = new System.Windows.Forms.Button();
            this.btnMinPop = new System.Windows.Forms.Button();
            this.btnOderByPopAesc = new System.Windows.Forms.Button();
            this.btnOrderByCity = new System.Windows.Forms.Button();
            this.btnOrderByPopDesc = new System.Windows.Forms.Button();
            this.populationTableAdapter = new AdamQuinn_CPT_206_A01S_Lab1.PopulationDataSetTableAdapters.PopulationTableAdapter();
            this.tableAdapterManager = new AdamQuinn_CPT_206_A01S_Lab1.PopulationDataSetTableAdapters.TableAdapterManager();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.btnOrderByDefault = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.populationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // populationDataGridView
            // 
            this.populationDataGridView.AutoGenerateColumns = false;
            this.populationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.populationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.populationDataGridView.DataSource = this.populationBindingSource;
            this.populationDataGridView.Location = new System.Drawing.Point(22, 11);
            this.populationDataGridView.Name = "populationDataGridView";
            this.populationDataGridView.RowHeadersWidth = 62;
            this.populationDataGridView.RowTemplate.Height = 28;
            this.populationDataGridView.Size = new System.Drawing.Size(919, 327);
            this.populationDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CityID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CityID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn2.HeaderText = "City";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn3.HeaderText = "State";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn4.HeaderText = "Population";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // populationBindingSource
            // 
            this.populationBindingSource.DataMember = "Population";
            this.populationBindingSource.DataSource = this.populationDataSet;
            // 
            // populationDataSet
            // 
            this.populationDataSet.DataSetName = "PopulationDataSet";
            this.populationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(602, 648);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 61);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.toolTips.SetToolTip(this.btnExit, "exits the program.");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Location = new System.Drawing.Point(691, 365);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(116, 61);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "E&dit";
            this.toolTips.SetToolTip(this.btnEdit, "opens the Edit form.");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAvgPop
            // 
            this.btnAvgPop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAvgPop.Location = new System.Drawing.Point(518, 365);
            this.btnAvgPop.Name = "btnAvgPop";
            this.btnAvgPop.Size = new System.Drawing.Size(116, 61);
            this.btnAvgPop.TabIndex = 6;
            this.btnAvgPop.Text = "Average &Population";
            this.toolTips.SetToolTip(this.btnAvgPop, "Shows the Average Population.");
            this.btnAvgPop.UseVisualStyleBackColor = false;
            this.btnAvgPop.Click += new System.EventHandler(this.btnAvgPop_Click);
            // 
            // btnTotalPop
            // 
            this.btnTotalPop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTotalPop.Location = new System.Drawing.Point(691, 463);
            this.btnTotalPop.Name = "btnTotalPop";
            this.btnTotalPop.Size = new System.Drawing.Size(116, 61);
            this.btnTotalPop.TabIndex = 9;
            this.btnTotalPop.Text = "&Total Population";
            this.toolTips.SetToolTip(this.btnTotalPop, "Shows the total population.");
            this.btnTotalPop.UseVisualStyleBackColor = false;
            this.btnTotalPop.Click += new System.EventHandler(this.btnTotalPop_Click);
            // 
            // btnMaxPop
            // 
            this.btnMaxPop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMaxPop.Location = new System.Drawing.Point(366, 365);
            this.btnMaxPop.Name = "btnMaxPop";
            this.btnMaxPop.Size = new System.Drawing.Size(116, 61);
            this.btnMaxPop.TabIndex = 4;
            this.btnMaxPop.Text = "M&ax Population";
            this.toolTips.SetToolTip(this.btnMaxPop, "Shows the maximum population.");
            this.btnMaxPop.UseVisualStyleBackColor = false;
            this.btnMaxPop.Click += new System.EventHandler(this.btnMaxPop_Click);
            // 
            // btnMinPop
            // 
            this.btnMinPop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMinPop.Location = new System.Drawing.Point(518, 463);
            this.btnMinPop.Name = "btnMinPop";
            this.btnMinPop.Size = new System.Drawing.Size(116, 61);
            this.btnMinPop.TabIndex = 7;
            this.btnMinPop.Text = "M&in Population";
            this.toolTips.SetToolTip(this.btnMinPop, "Shows the Minimum population.");
            this.btnMinPop.UseVisualStyleBackColor = false;
            this.btnMinPop.Click += new System.EventHandler(this.btnMinPop_Click);
            // 
            // btnOderByPopAesc
            // 
            this.btnOderByPopAesc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOderByPopAesc.Location = new System.Drawing.Point(182, 354);
            this.btnOderByPopAesc.Name = "btnOderByPopAesc";
            this.btnOderByPopAesc.Size = new System.Drawing.Size(116, 83);
            this.btnOderByPopAesc.TabIndex = 2;
            this.btnOderByPopAesc.Text = "&Order By Population Aescending";
            this.toolTips.SetToolTip(this.btnOderByPopAesc, "Orders the table by aescending population.");
            this.btnOderByPopAesc.UseVisualStyleBackColor = false;
            this.btnOderByPopAesc.Click += new System.EventHandler(this.btnOderByPopAesc_Click);
            // 
            // btnOrderByCity
            // 
            this.btnOrderByCity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrderByCity.Location = new System.Drawing.Point(366, 463);
            this.btnOrderByCity.Name = "btnOrderByCity";
            this.btnOrderByCity.Size = new System.Drawing.Size(116, 61);
            this.btnOrderByCity.TabIndex = 5;
            this.btnOrderByCity.Text = "Order by &City ";
            this.toolTips.SetToolTip(this.btnOrderByCity, "Order the table alphabetically by City.");
            this.btnOrderByCity.UseVisualStyleBackColor = false;
            this.btnOrderByCity.Click += new System.EventHandler(this.btnOrderByCity_Click);
            // 
            // btnOrderByPopDesc
            // 
            this.btnOrderByPopDesc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrderByPopDesc.Location = new System.Drawing.Point(182, 452);
            this.btnOrderByPopDesc.Name = "btnOrderByPopDesc";
            this.btnOrderByPopDesc.Size = new System.Drawing.Size(116, 83);
            this.btnOrderByPopDesc.TabIndex = 3;
            this.btnOrderByPopDesc.Text = "Order By Population &Descending";
            this.toolTips.SetToolTip(this.btnOrderByPopDesc, "orders the table by descending population.");
            this.btnOrderByPopDesc.UseVisualStyleBackColor = false;
            this.btnOrderByPopDesc.Click += new System.EventHandler(this.btnOrderByPopDesc_Click);
            // 
            // populationTableAdapter
            // 
            this.populationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PopulationTableAdapter = this.populationTableAdapter;
            this.tableAdapterManager.UpdateOrder = AdamQuinn_CPT_206_A01S_Lab1.PopulationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnOrderByDefault
            // 
            this.btnOrderByDefault.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrderByDefault.Location = new System.Drawing.Point(35, 410);
            this.btnOrderByDefault.Name = "btnOrderByDefault";
            this.btnOrderByDefault.Size = new System.Drawing.Size(116, 61);
            this.btnOrderByDefault.TabIndex = 1;
            this.btnOrderByDefault.Text = "Order by &Default ";
            this.toolTips.SetToolTip(this.btnOrderByDefault, "Order the table alphabetically by City.");
            this.btnOrderByDefault.UseVisualStyleBackColor = false;
            this.btnOrderByDefault.Click += new System.EventHandler(this.btnOrderByDefault_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnOrderByDefault);
            this.panel1.Controls.Add(this.btnOrderByPopDesc);
            this.panel1.Controls.Add(this.btnOrderByCity);
            this.panel1.Controls.Add(this.btnOderByPopAesc);
            this.panel1.Controls.Add(this.btnMinPop);
            this.panel1.Controls.Add(this.btnMaxPop);
            this.panel1.Controls.Add(this.btnTotalPop);
            this.panel1.Controls.Add(this.btnAvgPop);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.populationDataGridView);
            this.panel1.Location = new System.Drawing.Point(158, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 555);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOrderByDefault;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1304, 763);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "City Population Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.populationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PopulationDataSet populationDataSet;
        private System.Windows.Forms.BindingSource populationBindingSource;
        private PopulationDataSetTableAdapters.PopulationTableAdapter populationTableAdapter;
        private PopulationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView populationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAvgPop;
        private System.Windows.Forms.Button btnTotalPop;
        private System.Windows.Forms.Button btnMaxPop;
        private System.Windows.Forms.Button btnMinPop;
        private System.Windows.Forms.Button btnOderByPopAesc;
        private System.Windows.Forms.Button btnOrderByCity;
        private System.Windows.Forms.Button btnOrderByPopDesc;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrderByDefault;
    }
}