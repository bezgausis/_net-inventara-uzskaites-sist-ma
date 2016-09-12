namespace wfp_2prd
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
            this.datorklaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarsDataSet = new wfp_2prd.inventarsDataSet();
            this.inventarsTableAdapter = new wfp_2prd.inventarsDataSetTableAdapters.inventarsTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kodsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nosaukumsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventaranrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzskaitesvalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iegadesvalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nosaukumsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventaranrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzskaitesvalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iegadesvalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datorklaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarsDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datorklaseBindingSource
            // 
            this.datorklaseBindingSource.DataSource = typeof(wfp_2prd.Form1.Datorklase);
            // 
            // inventarsBindingSource
            // 
            this.inventarsBindingSource.DataMember = "inventars";
            this.inventarsBindingSource.DataSource = this.inventarsDataSet;
            // 
            // inventarsDataSet
            // 
            this.inventarsDataSet.DataSetName = "inventarsDataSet";
            this.inventarsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarsTableAdapter
            // 
            this.inventarsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(692, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 257);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "pievienot RAM";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(23, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "pievienot";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.FormattingEnabled = true;
            this.textBox2.Location = new System.Drawing.Point(22, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 40;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "kods";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(22, 195);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "nosaukums";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "iegādes_val";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "inventāra nr";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(22, 155);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 37;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "uzskaites_val";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(677, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DB";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodsDataGridViewTextBoxColumn1,
            this.nosaukumsDataGridViewTextBoxColumn1,
            this.inventaranrDataGridViewTextBoxColumn1,
            this.uzskaitesvalDataGridViewTextBoxColumn1,
            this.iegadesvalDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.inventarsBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(671, 385);
            this.dataGridView2.TabIndex = 0;
            // 
            // kodsDataGridViewTextBoxColumn1
            // 
            this.kodsDataGridViewTextBoxColumn1.DataPropertyName = "kods";
            this.kodsDataGridViewTextBoxColumn1.HeaderText = "kods";
            this.kodsDataGridViewTextBoxColumn1.Name = "kodsDataGridViewTextBoxColumn1";
            // 
            // nosaukumsDataGridViewTextBoxColumn1
            // 
            this.nosaukumsDataGridViewTextBoxColumn1.DataPropertyName = "nosaukums";
            this.nosaukumsDataGridViewTextBoxColumn1.HeaderText = "nosaukums";
            this.nosaukumsDataGridViewTextBoxColumn1.Name = "nosaukumsDataGridViewTextBoxColumn1";
            // 
            // inventaranrDataGridViewTextBoxColumn1
            // 
            this.inventaranrDataGridViewTextBoxColumn1.DataPropertyName = "inventara_nr";
            this.inventaranrDataGridViewTextBoxColumn1.HeaderText = "inventara_nr";
            this.inventaranrDataGridViewTextBoxColumn1.Name = "inventaranrDataGridViewTextBoxColumn1";
            // 
            // uzskaitesvalDataGridViewTextBoxColumn1
            // 
            this.uzskaitesvalDataGridViewTextBoxColumn1.DataPropertyName = "uzskaites_val";
            this.uzskaitesvalDataGridViewTextBoxColumn1.HeaderText = "uzskaites_val";
            this.uzskaitesvalDataGridViewTextBoxColumn1.Name = "uzskaitesvalDataGridViewTextBoxColumn1";
            // 
            // iegadesvalDataGridViewTextBoxColumn1
            // 
            this.iegadesvalDataGridViewTextBoxColumn1.DataPropertyName = "iegades_val";
            this.iegadesvalDataGridViewTextBoxColumn1.HeaderText = "iegades_val";
            this.iegadesvalDataGridViewTextBoxColumn1.Name = "iegadesvalDataGridViewTextBoxColumn1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(677, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RAM";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodsDataGridViewTextBoxColumn,
            this.nosaukumsDataGridViewTextBoxColumn,
            this.inventaranrDataGridViewTextBoxColumn,
            this.uzskaitesvalDataGridViewTextBoxColumn,
            this.iegadesvalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.datorklaseBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 385);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // kodsDataGridViewTextBoxColumn
            // 
            this.kodsDataGridViewTextBoxColumn.DataPropertyName = "kods";
            this.kodsDataGridViewTextBoxColumn.HeaderText = "kods";
            this.kodsDataGridViewTextBoxColumn.Name = "kodsDataGridViewTextBoxColumn";
            // 
            // nosaukumsDataGridViewTextBoxColumn
            // 
            this.nosaukumsDataGridViewTextBoxColumn.DataPropertyName = "nosaukums";
            this.nosaukumsDataGridViewTextBoxColumn.HeaderText = "nosaukums";
            this.nosaukumsDataGridViewTextBoxColumn.Name = "nosaukumsDataGridViewTextBoxColumn";
            // 
            // inventaranrDataGridViewTextBoxColumn
            // 
            this.inventaranrDataGridViewTextBoxColumn.DataPropertyName = "inventara_nr";
            this.inventaranrDataGridViewTextBoxColumn.HeaderText = "inventara_nr";
            this.inventaranrDataGridViewTextBoxColumn.Name = "inventaranrDataGridViewTextBoxColumn";
            // 
            // uzskaitesvalDataGridViewTextBoxColumn
            // 
            this.uzskaitesvalDataGridViewTextBoxColumn.DataPropertyName = "uzskaites_val";
            this.uzskaitesvalDataGridViewTextBoxColumn.HeaderText = "uzskaites_val";
            this.uzskaitesvalDataGridViewTextBoxColumn.Name = "uzskaitesvalDataGridViewTextBoxColumn";
            // 
            // iegadesvalDataGridViewTextBoxColumn
            // 
            this.iegadesvalDataGridViewTextBoxColumn.DataPropertyName = "iegades_val";
            this.iegadesvalDataGridViewTextBoxColumn.HeaderText = "iegades_val";
            this.iegadesvalDataGridViewTextBoxColumn.Name = "iegadesvalDataGridViewTextBoxColumn";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 417);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(692, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 120);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ieraksti";
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(17, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "pievienotRAM";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(16, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "pievienotDB";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(16, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "dzēst";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(389, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(446, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "datorklases inventāra uzskaites sistēma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(836, 419);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "inventara uzskaite";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datorklaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarsDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource datorklaseBindingSource;
        private inventarsDataSet inventarsDataSet;
        private System.Windows.Forms.BindingSource inventarsBindingSource;
        private inventarsDataSetTableAdapters.inventarsTableAdapter inventarsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nosaukumsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventaranrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzskaitesvalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iegadesvalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nosaukumsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventaranrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzskaitesvalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iegadesvalDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}