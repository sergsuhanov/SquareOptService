namespace TestApplication {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cutDepthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationSquareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOptimizedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lastDestinationHeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDestinationWidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxLenCuttingXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxLenCuttingYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateSquareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wastePercentADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wastePercentBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasteSquareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasteTrashSquareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasteWorkSquareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "new";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "generate random data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(444, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "opt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(525, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "edit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cutDepthDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.destinationCountDataGridViewTextBoxColumn,
            this.destinationSquareDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.isOptimizedDataGridViewCheckBoxColumn,
            this.lastDestinationHeightDataGridViewTextBoxColumn,
            this.lastDestinationWidthDataGridViewTextBoxColumn,
            this.maxLenCuttingXDataGridViewTextBoxColumn,
            this.maxLenCuttingYDataGridViewTextBoxColumn,
            this.plateCountDataGridViewTextBoxColumn,
            this.plateSquareDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.wastePercentADataGridViewTextBoxColumn,
            this.wastePercentBDataGridViewTextBoxColumn,
            this.wasteSquareDataGridViewTextBoxColumn,
            this.wasteTrashSquareDataGridViewTextBoxColumn,
            this.wasteWorkSquareDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1083, 362);
            this.dataGridView1.TabIndex = 5;
            // 
            // cutDepthDataGridViewTextBoxColumn
            // 
            this.cutDepthDataGridViewTextBoxColumn.DataPropertyName = "CutDepth";
            this.cutDepthDataGridViewTextBoxColumn.HeaderText = "CutDepth";
            this.cutDepthDataGridViewTextBoxColumn.Name = "cutDepthDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // destinationCountDataGridViewTextBoxColumn
            // 
            this.destinationCountDataGridViewTextBoxColumn.DataPropertyName = "DestinationCount";
            this.destinationCountDataGridViewTextBoxColumn.HeaderText = "DestinationCount";
            this.destinationCountDataGridViewTextBoxColumn.Name = "destinationCountDataGridViewTextBoxColumn";
            // 
            // destinationSquareDataGridViewTextBoxColumn
            // 
            this.destinationSquareDataGridViewTextBoxColumn.DataPropertyName = "DestinationSquare";
            this.destinationSquareDataGridViewTextBoxColumn.HeaderText = "DestinationSquare";
            this.destinationSquareDataGridViewTextBoxColumn.Name = "destinationSquareDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // isOptimizedDataGridViewCheckBoxColumn
            // 
            this.isOptimizedDataGridViewCheckBoxColumn.DataPropertyName = "IsOptimized";
            this.isOptimizedDataGridViewCheckBoxColumn.HeaderText = "IsOptimized";
            this.isOptimizedDataGridViewCheckBoxColumn.Name = "isOptimizedDataGridViewCheckBoxColumn";
            // 
            // lastDestinationHeightDataGridViewTextBoxColumn
            // 
            this.lastDestinationHeightDataGridViewTextBoxColumn.DataPropertyName = "LastDestinationHeight";
            this.lastDestinationHeightDataGridViewTextBoxColumn.HeaderText = "LastDestinationHeight";
            this.lastDestinationHeightDataGridViewTextBoxColumn.Name = "lastDestinationHeightDataGridViewTextBoxColumn";
            // 
            // lastDestinationWidthDataGridViewTextBoxColumn
            // 
            this.lastDestinationWidthDataGridViewTextBoxColumn.DataPropertyName = "LastDestinationWidth";
            this.lastDestinationWidthDataGridViewTextBoxColumn.HeaderText = "LastDestinationWidth";
            this.lastDestinationWidthDataGridViewTextBoxColumn.Name = "lastDestinationWidthDataGridViewTextBoxColumn";
            // 
            // maxLenCuttingXDataGridViewTextBoxColumn
            // 
            this.maxLenCuttingXDataGridViewTextBoxColumn.DataPropertyName = "MaxLenCuttingX";
            this.maxLenCuttingXDataGridViewTextBoxColumn.HeaderText = "MaxLenCuttingX";
            this.maxLenCuttingXDataGridViewTextBoxColumn.Name = "maxLenCuttingXDataGridViewTextBoxColumn";
            // 
            // maxLenCuttingYDataGridViewTextBoxColumn
            // 
            this.maxLenCuttingYDataGridViewTextBoxColumn.DataPropertyName = "MaxLenCuttingY";
            this.maxLenCuttingYDataGridViewTextBoxColumn.HeaderText = "MaxLenCuttingY";
            this.maxLenCuttingYDataGridViewTextBoxColumn.Name = "maxLenCuttingYDataGridViewTextBoxColumn";
            // 
            // plateCountDataGridViewTextBoxColumn
            // 
            this.plateCountDataGridViewTextBoxColumn.DataPropertyName = "PlateCount";
            this.plateCountDataGridViewTextBoxColumn.HeaderText = "PlateCount";
            this.plateCountDataGridViewTextBoxColumn.Name = "plateCountDataGridViewTextBoxColumn";
            // 
            // plateSquareDataGridViewTextBoxColumn
            // 
            this.plateSquareDataGridViewTextBoxColumn.DataPropertyName = "PlateSquare";
            this.plateSquareDataGridViewTextBoxColumn.HeaderText = "PlateSquare";
            this.plateSquareDataGridViewTextBoxColumn.Name = "plateSquareDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // wastePercentADataGridViewTextBoxColumn
            // 
            this.wastePercentADataGridViewTextBoxColumn.DataPropertyName = "WastePercentA";
            this.wastePercentADataGridViewTextBoxColumn.HeaderText = "WastePercentA";
            this.wastePercentADataGridViewTextBoxColumn.Name = "wastePercentADataGridViewTextBoxColumn";
            // 
            // wastePercentBDataGridViewTextBoxColumn
            // 
            this.wastePercentBDataGridViewTextBoxColumn.DataPropertyName = "WastePercentB";
            this.wastePercentBDataGridViewTextBoxColumn.HeaderText = "WastePercentB";
            this.wastePercentBDataGridViewTextBoxColumn.Name = "wastePercentBDataGridViewTextBoxColumn";
            // 
            // wasteSquareDataGridViewTextBoxColumn
            // 
            this.wasteSquareDataGridViewTextBoxColumn.DataPropertyName = "WasteSquare";
            this.wasteSquareDataGridViewTextBoxColumn.HeaderText = "WasteSquare";
            this.wasteSquareDataGridViewTextBoxColumn.Name = "wasteSquareDataGridViewTextBoxColumn";
            // 
            // wasteTrashSquareDataGridViewTextBoxColumn
            // 
            this.wasteTrashSquareDataGridViewTextBoxColumn.DataPropertyName = "WasteTrashSquare";
            this.wasteTrashSquareDataGridViewTextBoxColumn.HeaderText = "WasteTrashSquare";
            this.wasteTrashSquareDataGridViewTextBoxColumn.Name = "wasteTrashSquareDataGridViewTextBoxColumn";
            // 
            // wasteWorkSquareDataGridViewTextBoxColumn
            // 
            this.wasteWorkSquareDataGridViewTextBoxColumn.DataPropertyName = "WasteWorkSquare";
            this.wasteWorkSquareDataGridViewTextBoxColumn.HeaderText = "WasteWorkSquare";
            this.wasteWorkSquareDataGridViewTextBoxColumn.Name = "wasteWorkSquareDataGridViewTextBoxColumn";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(TestApplication.ServiceReference1.Document);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(606, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "export pdf";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(687, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "export hegla";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1001, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "delete";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(768, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(91, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "export intermac";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 414);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutDepthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationSquareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOptimizedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDestinationHeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDestinationWidthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLenCuttingXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLenCuttingYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateSquareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wastePercentADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wastePercentBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasteSquareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasteTrashSquareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasteWorkSquareDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

