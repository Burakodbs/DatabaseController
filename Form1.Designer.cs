namespace DatabaseController
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            npgsqlConnectionBindingSource = new BindingSource(components);
            dataGrid = new DataGridView();
            typeText = new TextBox();
            namesurnameText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)npgsqlConnectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 57);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 0;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 86);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 2;
            button2.Text = "SİL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 115);
            button3.Name = "button3";
            button3.Size = new Size(99, 23);
            button3.TabIndex = 3;
            button3.Text = "GÜNCELLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 144);
            button4.Name = "button4";
            button4.Size = new Size(99, 23);
            button4.TabIndex = 4;
            button4.Text = "ARAMA";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(406, 386);
            button5.Name = "button5";
            button5.Size = new Size(99, 23);
            button5.TabIndex = 6;
            button5.Text = "LİSTELE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // npgsqlConnectionBindingSource
            // 
            npgsqlConnectionBindingSource.DataSource = typeof(Npgsql.NpgsqlConnection);
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(175, 12);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(585, 368);
            dataGrid.TabIndex = 7;
            // 
            // typeText
            // 
            typeText.Location = new Point(69, 214);
            typeText.Name = "typeText";
            typeText.Size = new Size(100, 23);
            typeText.TabIndex = 8;
            // 
            // namesurnameText
            // 
            namesurnameText.Location = new Point(110, 243);
            namesurnameText.Name = "namesurnameText";
            namesurnameText.Size = new Size(59, 23);
            namesurnameText.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 217);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 10;
            label1.Text = "ID/TYPEID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 246);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 11;
            label2.Text = "NAMESURNAME";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(772, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(namesurnameText);
            Controls.Add(typeText);
            Controls.Add(dataGrid);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)npgsqlConnectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Button button5;
        private DataGridViewTextBoxColumn typeMapperDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn connectionStringDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn providePasswordCallbackDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn portDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn connectionTimeoutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commandTimeoutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataSourceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn canCreateBatchDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn provideClientCertificatesCallbackDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userCertificateValidationCallbackDataGridViewTextBoxColumn;
        private BindingSource npgsqlConnectionBindingSource;
        private DataGridView dataGrid;
        private TextBox typeText;
        private TextBox namesurnameText;
        private Label label1;
        private Label label2;
    }
}
