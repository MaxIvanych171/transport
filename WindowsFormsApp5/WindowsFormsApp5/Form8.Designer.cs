namespace WindowsFormsApp5
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDзаказчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDполучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDгрузаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датазаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датадоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьдоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakazyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transportDBDataSet = new WindowsFormsApp5.transportDBDataSet();
            this.zakazyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakazyTableAdapter = new WindowsFormsApp5.transportDBDataSetTableAdapters.zakazyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDзаказаDataGridViewTextBoxColumn,
            this.iDзаказчикаDataGridViewTextBoxColumn,
            this.iDполучателяDataGridViewTextBoxColumn,
            this.iDгрузаDataGridViewTextBoxColumn,
            this.датазаказаDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.датадоставкиDataGridViewTextBoxColumn,
            this.стоимостьдоставкиDataGridViewTextBoxColumn,
            this.статусзаказаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zakazyBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(920, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDзаказаDataGridViewTextBoxColumn
            // 
            this.iDзаказаDataGridViewTextBoxColumn.DataPropertyName = "ID_заказа";
            this.iDзаказаDataGridViewTextBoxColumn.HeaderText = "ID_заказа";
            this.iDзаказаDataGridViewTextBoxColumn.Name = "iDзаказаDataGridViewTextBoxColumn";
            this.iDзаказаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDзаказаDataGridViewTextBoxColumn.Width = 70;
            // 
            // iDзаказчикаDataGridViewTextBoxColumn
            // 
            this.iDзаказчикаDataGridViewTextBoxColumn.DataPropertyName = "ID_заказчика";
            this.iDзаказчикаDataGridViewTextBoxColumn.HeaderText = "ID_заказчика";
            this.iDзаказчикаDataGridViewTextBoxColumn.Name = "iDзаказчикаDataGridViewTextBoxColumn";
            this.iDзаказчикаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDзаказчикаDataGridViewTextBoxColumn.Width = 82;
            // 
            // iDполучателяDataGridViewTextBoxColumn
            // 
            this.iDполучателяDataGridViewTextBoxColumn.DataPropertyName = "ID_получателя";
            this.iDполучателяDataGridViewTextBoxColumn.HeaderText = "ID_получателя";
            this.iDполучателяDataGridViewTextBoxColumn.Name = "iDполучателяDataGridViewTextBoxColumn";
            this.iDполучателяDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDполучателяDataGridViewTextBoxColumn.Width = 85;
            // 
            // iDгрузаDataGridViewTextBoxColumn
            // 
            this.iDгрузаDataGridViewTextBoxColumn.DataPropertyName = "ID_груза";
            this.iDгрузаDataGridViewTextBoxColumn.HeaderText = "ID_груза";
            this.iDгрузаDataGridViewTextBoxColumn.Name = "iDгрузаDataGridViewTextBoxColumn";
            this.iDгрузаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDгрузаDataGridViewTextBoxColumn.Width = 75;
            // 
            // датазаказаDataGridViewTextBoxColumn
            // 
            this.датазаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата_заказа";
            this.датазаказаDataGridViewTextBoxColumn.HeaderText = "Дата_заказа";
            this.датазаказаDataGridViewTextBoxColumn.Name = "датазаказаDataGridViewTextBoxColumn";
            this.датазаказаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датазаказаDataGridViewTextBoxColumn.Width = 82;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            this.адресDataGridViewTextBoxColumn.Width = 130;
            // 
            // датадоставкиDataGridViewTextBoxColumn
            // 
            this.датадоставкиDataGridViewTextBoxColumn.DataPropertyName = "Дата_доставки";
            this.датадоставкиDataGridViewTextBoxColumn.HeaderText = "Дата_доставки";
            this.датадоставкиDataGridViewTextBoxColumn.Name = "датадоставкиDataGridViewTextBoxColumn";
            this.датадоставкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьдоставкиDataGridViewTextBoxColumn
            // 
            this.стоимостьдоставкиDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_доставки";
            this.стоимостьдоставкиDataGridViewTextBoxColumn.HeaderText = "Стоимость_доставки";
            this.стоимостьдоставкиDataGridViewTextBoxColumn.Name = "стоимостьдоставкиDataGridViewTextBoxColumn";
            this.стоимостьдоставкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.стоимостьдоставкиDataGridViewTextBoxColumn.Width = 120;
            // 
            // статусзаказаDataGridViewTextBoxColumn
            // 
            this.статусзаказаDataGridViewTextBoxColumn.DataPropertyName = "Статус_заказа";
            this.статусзаказаDataGridViewTextBoxColumn.HeaderText = "Статус_заказа";
            this.статусзаказаDataGridViewTextBoxColumn.Name = "статусзаказаDataGridViewTextBoxColumn";
            this.статусзаказаDataGridViewTextBoxColumn.ReadOnly = true;
            this.статусзаказаDataGridViewTextBoxColumn.Width = 130;
            // 
            // zakazyBindingSource1
            // 
            this.zakazyBindingSource1.DataMember = "zakazy";
            this.zakazyBindingSource1.DataSource = this.transportDBDataSet;
            // 
            // transportDBDataSet
            // 
            this.transportDBDataSet.DataSetName = "transportDBDataSet";
            this.transportDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zakazyBindingSource
            // 
            this.zakazyBindingSource.DataMember = "zakazy";
            this.zakazyBindingSource.DataSource = this.transportDBDataSet;
            // 
            // zakazyTableAdapter
            // 
            this.zakazyTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1028, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private transportDBDataSet transportDBDataSet;
        private System.Windows.Forms.BindingSource zakazyBindingSource;
        private transportDBDataSetTableAdapters.zakazyTableAdapter zakazyTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDзаказчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDполучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDгрузаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датазаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датадоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьдоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zakazyBindingSource1;
        private System.Windows.Forms.Button button1;
    }
}