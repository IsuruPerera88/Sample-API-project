namespace CompanyStaffContact
{
    partial class FrmAddEditContact
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.RbtEmployee = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbtManager = new System.Windows.Forms.RadioButton();
            this.LblFName = new System.Windows.Forms.Label();
            this.TxtFName = new System.Windows.Forms.TextBox();
            this.LblLName = new System.Windows.Forms.Label();
            this.TxtLName = new System.Windows.Forms.TextBox();
            this.LblMName = new System.Windows.Forms.Label();
            this.TxtInitial = new System.Windows.Forms.TextBox();
            this.LblHPone = new System.Windows.Forms.Label();
            this.TxtHPhone = new System.Windows.Forms.TextBox();
            this.TxtCellPhone = new System.Windows.Forms.TextBox();
            this.LblCellPhone = new System.Windows.Forms.Label();
            this.TxtOfzPhone = new System.Windows.Forms.TextBox();
            this.LblOfzExtension = new System.Windows.Forms.Label();
            this.TxtIRDNumber = new System.Windows.Forms.TextBox();
            this.LblIRDNumber = new System.Windows.Forms.Label();
            this.LblManager = new System.Windows.Forms.Label();
            this.CmbManager = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbtPending = new System.Windows.Forms.RadioButton();
            this.RbtInactive = new System.Windows.Forms.RadioButton();
            this.RbtActive = new System.Windows.Forms.RadioButton();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(12, 53);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(33, 16);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Title";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(115, 50);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(232, 22);
            this.TxtTitle.TabIndex = 1;
            // 
            // RbtEmployee
            // 
            this.RbtEmployee.AutoSize = true;
            this.RbtEmployee.Location = new System.Drawing.Point(6, 31);
            this.RbtEmployee.Name = "RbtEmployee";
            this.RbtEmployee.Size = new System.Drawing.Size(90, 20);
            this.RbtEmployee.TabIndex = 2;
            this.RbtEmployee.TabStop = true;
            this.RbtEmployee.Text = "Employee";
            this.RbtEmployee.UseVisualStyleBackColor = true;
            this.RbtEmployee.CheckedChanged += new System.EventHandler(this.RbtEmployee_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbtManager);
            this.groupBox1.Controls.Add(this.RbtEmployee);
            this.groupBox1.Location = new System.Drawing.Point(475, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 69);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Type";
            // 
            // RbtManager
            // 
            this.RbtManager.AutoSize = true;
            this.RbtManager.Location = new System.Drawing.Point(104, 31);
            this.RbtManager.Name = "RbtManager";
            this.RbtManager.Size = new System.Drawing.Size(82, 20);
            this.RbtManager.TabIndex = 2;
            this.RbtManager.TabStop = true;
            this.RbtManager.Text = "Manager";
            this.RbtManager.UseVisualStyleBackColor = true;
            this.RbtManager.CheckedChanged += new System.EventHandler(this.RbtManager_CheckedChanged);
            // 
            // LblFName
            // 
            this.LblFName.AutoSize = true;
            this.LblFName.Location = new System.Drawing.Point(12, 85);
            this.LblFName.Name = "LblFName";
            this.LblFName.Size = new System.Drawing.Size(72, 16);
            this.LblFName.TabIndex = 4;
            this.LblFName.Text = "First Name";
            // 
            // TxtFName
            // 
            this.TxtFName.Location = new System.Drawing.Point(115, 82);
            this.TxtFName.Name = "TxtFName";
            this.TxtFName.Size = new System.Drawing.Size(232, 22);
            this.TxtFName.TabIndex = 5;
            // 
            // LblLName
            // 
            this.LblLName.AutoSize = true;
            this.LblLName.Location = new System.Drawing.Point(12, 124);
            this.LblLName.Name = "LblLName";
            this.LblLName.Size = new System.Drawing.Size(72, 16);
            this.LblLName.TabIndex = 6;
            this.LblLName.Text = "Last Name";
            // 
            // TxtLName
            // 
            this.TxtLName.Location = new System.Drawing.Point(115, 121);
            this.TxtLName.Name = "TxtLName";
            this.TxtLName.Size = new System.Drawing.Size(232, 22);
            this.TxtLName.TabIndex = 7;
            // 
            // LblMName
            // 
            this.LblMName.AutoSize = true;
            this.LblMName.Location = new System.Drawing.Point(12, 161);
            this.LblMName.Name = "LblMName";
            this.LblMName.Size = new System.Drawing.Size(84, 16);
            this.LblMName.TabIndex = 8;
            this.LblMName.Text = "Middle Initial ";
            // 
            // TxtInitial
            // 
            this.TxtInitial.Location = new System.Drawing.Point(115, 158);
            this.TxtInitial.Name = "TxtInitial";
            this.TxtInitial.Size = new System.Drawing.Size(232, 22);
            this.TxtInitial.TabIndex = 9;
            // 
            // LblHPone
            // 
            this.LblHPone.AutoSize = true;
            this.LblHPone.Location = new System.Drawing.Point(12, 202);
            this.LblHPone.Name = "LblHPone";
            this.LblHPone.Size = new System.Drawing.Size(86, 16);
            this.LblHPone.TabIndex = 10;
            this.LblHPone.Text = "Home Phone";
            // 
            // TxtHPhone
            // 
            this.TxtHPhone.Location = new System.Drawing.Point(115, 199);
            this.TxtHPhone.Name = "TxtHPhone";
            this.TxtHPhone.Size = new System.Drawing.Size(232, 22);
            this.TxtHPhone.TabIndex = 11;
            this.TxtHPhone.TextChanged += new System.EventHandler(this.TxtHPhone_TextChanged);
            // 
            // TxtCellPhone
            // 
            this.TxtCellPhone.Location = new System.Drawing.Point(115, 242);
            this.TxtCellPhone.Name = "TxtCellPhone";
            this.TxtCellPhone.Size = new System.Drawing.Size(232, 22);
            this.TxtCellPhone.TabIndex = 13;
            this.TxtCellPhone.TextChanged += new System.EventHandler(this.TxtCellPhone_TextChanged);
            // 
            // LblCellPhone
            // 
            this.LblCellPhone.AutoSize = true;
            this.LblCellPhone.Location = new System.Drawing.Point(12, 245);
            this.LblCellPhone.Name = "LblCellPhone";
            this.LblCellPhone.Size = new System.Drawing.Size(72, 16);
            this.LblCellPhone.TabIndex = 12;
            this.LblCellPhone.Text = "Cell Phone";
            // 
            // TxtOfzPhone
            // 
            this.TxtOfzPhone.Location = new System.Drawing.Point(115, 283);
            this.TxtOfzPhone.Name = "TxtOfzPhone";
            this.TxtOfzPhone.Size = new System.Drawing.Size(232, 22);
            this.TxtOfzPhone.TabIndex = 15;
            this.TxtOfzPhone.TextChanged += new System.EventHandler(this.TxtOfzPhone_TextChanged);
            // 
            // LblOfzExtension
            // 
            this.LblOfzExtension.AutoSize = true;
            this.LblOfzExtension.Location = new System.Drawing.Point(12, 286);
            this.LblOfzExtension.Name = "LblOfzExtension";
            this.LblOfzExtension.Size = new System.Drawing.Size(102, 16);
            this.LblOfzExtension.TabIndex = 14;
            this.LblOfzExtension.Text = "Office Extension";
            // 
            // TxtIRDNumber
            // 
            this.TxtIRDNumber.Location = new System.Drawing.Point(115, 325);
            this.TxtIRDNumber.Name = "TxtIRDNumber";
            this.TxtIRDNumber.Size = new System.Drawing.Size(232, 22);
            this.TxtIRDNumber.TabIndex = 17;
            this.TxtIRDNumber.TextChanged += new System.EventHandler(this.TxtIRDNumber_TextChanged);
            // 
            // LblIRDNumber
            // 
            this.LblIRDNumber.AutoSize = true;
            this.LblIRDNumber.Location = new System.Drawing.Point(12, 328);
            this.LblIRDNumber.Name = "LblIRDNumber";
            this.LblIRDNumber.Size = new System.Drawing.Size(81, 16);
            this.LblIRDNumber.TabIndex = 16;
            this.LblIRDNumber.Text = "IRD Number";
            // 
            // LblManager
            // 
            this.LblManager.AutoSize = true;
            this.LblManager.Location = new System.Drawing.Point(12, 369);
            this.LblManager.Name = "LblManager";
            this.LblManager.Size = new System.Drawing.Size(61, 16);
            this.LblManager.TabIndex = 18;
            this.LblManager.Text = "Manager";
            this.LblManager.Visible = false;
            // 
            // CmbManager
            // 
            this.CmbManager.FormattingEnabled = true;
            this.CmbManager.Location = new System.Drawing.Point(115, 366);
            this.CmbManager.Name = "CmbManager";
            this.CmbManager.Size = new System.Drawing.Size(232, 24);
            this.CmbManager.TabIndex = 19;
            this.CmbManager.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RbtPending);
            this.groupBox2.Controls.Add(this.RbtInactive);
            this.groupBox2.Controls.Add(this.RbtActive);
            this.groupBox2.Location = new System.Drawing.Point(475, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 153);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // RbtPending
            // 
            this.RbtPending.AutoSize = true;
            this.RbtPending.Location = new System.Drawing.Point(6, 109);
            this.RbtPending.Name = "RbtPending";
            this.RbtPending.Size = new System.Drawing.Size(78, 20);
            this.RbtPending.TabIndex = 3;
            this.RbtPending.TabStop = true;
            this.RbtPending.Text = "Pending";
            this.RbtPending.UseVisualStyleBackColor = true;
            this.RbtPending.CheckedChanged += new System.EventHandler(this.RbtPending_CheckedChanged);
            // 
            // RbtInactive
            // 
            this.RbtInactive.AutoSize = true;
            this.RbtInactive.Location = new System.Drawing.Point(6, 71);
            this.RbtInactive.Name = "RbtInactive";
            this.RbtInactive.Size = new System.Drawing.Size(74, 20);
            this.RbtInactive.TabIndex = 2;
            this.RbtInactive.TabStop = true;
            this.RbtInactive.Text = "Inactive";
            this.RbtInactive.UseVisualStyleBackColor = true;
            this.RbtInactive.CheckedChanged += new System.EventHandler(this.RbtInactive_CheckedChanged);
            // 
            // RbtActive
            // 
            this.RbtActive.AutoSize = true;
            this.RbtActive.Location = new System.Drawing.Point(6, 31);
            this.RbtActive.Name = "RbtActive";
            this.RbtActive.Size = new System.Drawing.Size(65, 20);
            this.RbtActive.TabIndex = 2;
            this.RbtActive.TabStop = true;
            this.RbtActive.Text = "Active";
            this.RbtActive.UseVisualStyleBackColor = true;
            this.RbtActive.CheckedChanged += new System.EventHandler(this.RbtActive_CheckedChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(597, 429);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(149, 37);
            this.BtnSave.TabIndex = 21;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(442, 429);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 37);
            this.BtnCancel.TabIndex = 21;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmAddEditContact
            // 
            this.AcceptButton = this.BtnSave;
            this.ClientSize = new System.Drawing.Size(758, 478);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CmbManager);
            this.Controls.Add(this.LblManager);
            this.Controls.Add(this.TxtIRDNumber);
            this.Controls.Add(this.LblIRDNumber);
            this.Controls.Add(this.TxtOfzPhone);
            this.Controls.Add(this.LblOfzExtension);
            this.Controls.Add(this.TxtCellPhone);
            this.Controls.Add(this.LblCellPhone);
            this.Controls.Add(this.TxtHPhone);
            this.Controls.Add(this.LblHPone);
            this.Controls.Add(this.TxtInitial);
            this.Controls.Add(this.LblMName);
            this.Controls.Add(this.TxtLName);
            this.Controls.Add(this.LblLName);
            this.Controls.Add(this.TxtFName);
            this.Controls.Add(this.LblFName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "FrmAddEditContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Contact";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddEditContact_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.RadioButton RbtEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbtManager;
        private System.Windows.Forms.Label LblFName;
        private System.Windows.Forms.TextBox TxtFName;
        private System.Windows.Forms.Label LblLName;
        private System.Windows.Forms.TextBox TxtLName;
        private System.Windows.Forms.Label LblMName;
        private System.Windows.Forms.TextBox TxtInitial;
        private System.Windows.Forms.Label LblHPone;
        private System.Windows.Forms.TextBox TxtHPhone;
        private System.Windows.Forms.TextBox TxtCellPhone;
        private System.Windows.Forms.Label LblCellPhone;
        private System.Windows.Forms.TextBox TxtOfzPhone;
        private System.Windows.Forms.Label LblOfzExtension;
        private System.Windows.Forms.TextBox TxtIRDNumber;
        private System.Windows.Forms.Label LblIRDNumber;
        private System.Windows.Forms.Label LblManager;
        private System.Windows.Forms.ComboBox CmbManager;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RbtInactive;
        private System.Windows.Forms.RadioButton RbtActive;
        private System.Windows.Forms.RadioButton RbtPending;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
    }
}