namespace WinFormsApp_28_11_2025
{
    partial class Form1
    {
        // ... (phần mã khởi tạo component)
        private void InitializeComponent()
        {
            labelName = new Label();
            txtName = new TextBox();
            numQuantity = new NumericUpDown();
            chkOption = new CheckBox();
            rdoOption = new RadioButton();
            cboSelection = new ComboBox();
            dtpDate = new DateTimePicker();
            lstOptions = new ListBox();
            btnOK1 = new Button();
            btnOK2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(30, 38);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(85, 34);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(205, 27);
            txtName.TabIndex = 1;
            txtName.Text = "Nguyen Tuan";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(300, 34);
            numQuantity.Margin = new Padding(3, 4, 3, 4);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(109, 27);
            numQuantity.TabIndex = 2;
            // 
            // chkOption
            // 
            chkOption.AutoSize = true;
            chkOption.Location = new Point(30, 88);
            chkOption.Margin = new Padding(3, 4, 3, 4);
            chkOption.Name = "chkOption";
            chkOption.Size = new Size(101, 24);
            chkOption.TabIndex = 3;
            chkOption.Text = "checkBox1";
            chkOption.UseVisualStyleBackColor = true;
            // 
            // rdoOption
            // 
            rdoOption.AutoSize = true;
            rdoOption.Location = new Point(173, 87);
            rdoOption.Margin = new Padding(3, 4, 3, 4);
            rdoOption.Name = "rdoOption";
            rdoOption.Size = new Size(117, 24);
            rdoOption.TabIndex = 4;
            rdoOption.TabStop = true;
            rdoOption.Text = "radioButton1";
            rdoOption.UseVisualStyleBackColor = true;
            // 
            // cboSelection
            // 
            cboSelection.FormattingEnabled = true;
            cboSelection.Location = new Point(30, 138);
            cboSelection.Margin = new Padding(3, 4, 3, 4);
            cboSelection.Name = "cboSelection";
            cboSelection.Size = new Size(379, 28);
            cboSelection.TabIndex = 5;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(30, 191);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(230, 27);
            dtpDate.TabIndex = 6;
            dtpDate.Value = new DateTime(2017, 9, 11, 0, 0, 0, 0);
            // 
            // lstOptions
            // 
            lstOptions.FormattingEnabled = true;
            lstOptions.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F" });
            lstOptions.Location = new Point(30, 238);
            lstOptions.Margin = new Padding(3, 4, 3, 4);
            lstOptions.Name = "lstOptions";
            lstOptions.Size = new Size(379, 144);
            lstOptions.TabIndex = 7;
            // 
            // btnOK1
            // 
            btnOK1.Location = new Point(200, 412);
            btnOK1.Margin = new Padding(3, 4, 3, 4);
            btnOK1.Name = "btnOK1";
            btnOK1.Size = new Size(120, 38);
            btnOK1.TabIndex = 8;
            btnOK1.Text = "OK";
            btnOK1.UseVisualStyleBackColor = true;
            btnOK1.Click += btnOK_Click;
            // 
            // btnOK2
            // 
            btnOK2.Location = new Point(326, 412);
            btnOK2.Margin = new Padding(3, 4, 3, 4);
            btnOK2.Name = "btnOK2";
            btnOK2.Size = new Size(109, 38);
            btnOK2.TabIndex = 9;
            btnOK2.Text = "OK";
            btnOK2.UseVisualStyleBackColor = true;
            btnOK2.Click += btnOK_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 475);
            Controls.Add(btnOK2);
            Controls.Add(btnOK1);
            Controls.Add(lstOptions);
            Controls.Add(dtpDate);
            Controls.Add(cboSelection);
            Controls.Add(rdoOption);
            Controls.Add(chkOption);
            Controls.Add(numQuantity);
            Controls.Add(txtName);
            Controls.Add(labelName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            KeyUp += From1_Keyup;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.CheckBox chkOption;
        private System.Windows.Forms.RadioButton rdoOption;
        private System.Windows.Forms.ComboBox cboSelection;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ListBox lstOptions;
        private System.Windows.Forms.Button btnOK1;
        private System.Windows.Forms.Button btnOK2;
    }
}