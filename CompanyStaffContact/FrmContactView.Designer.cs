namespace CompanyStaffContact
{
    partial class FrmContactView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewContactData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Middle_Initial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Home_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Office_Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IRD_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Navi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Nav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnExport_CSV = new System.Windows.Forms.Button();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewContactData
            // 
            this.dataGridViewContactData.AllowUserToAddRows = false;
            this.dataGridViewContactData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewContactData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewContactData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContactData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewContactData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContactData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.First_Name,
            this.Last_Name,
            this.Middle_Initial,
            this.Home_Phone,
            this.Cell_Phone,
            this.Office_Extension,
            this.IRD_Number,
            this.Staff_Type,
            this.Status,
            this.StatusId,
            this.StaffId,
            this.Status_Navi,
            this.Staff_Nav,
            this.ManagerId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewContactData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewContactData.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewContactData.Name = "dataGridViewContactData";
            this.dataGridViewContactData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContactData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewContactData.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(210)))), ((int)(((byte)(189)))));
            this.dataGridViewContactData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewContactData.RowTemplate.Height = 24;
            this.dataGridViewContactData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContactData.Size = new System.Drawing.Size(1130, 616);
            this.dataGridViewContactData.TabIndex = 0;
            this.dataGridViewContactData.SelectionChanged += new System.EventHandler(this.dataGridViewContactData_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // First_Name
            // 
            this.First_Name.DataPropertyName = "FirstName";
            this.First_Name.HeaderText = "First Name";
            this.First_Name.MinimumWidth = 6;
            this.First_Name.Name = "First_Name";
            this.First_Name.ReadOnly = true;
            this.First_Name.Width = 125;
            // 
            // Last_Name
            // 
            this.Last_Name.DataPropertyName = "LastName";
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.MinimumWidth = 6;
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.ReadOnly = true;
            this.Last_Name.Width = 125;
            // 
            // Middle_Initial
            // 
            this.Middle_Initial.DataPropertyName = "MiddleInitial";
            this.Middle_Initial.HeaderText = "Middle Initial";
            this.Middle_Initial.MinimumWidth = 6;
            this.Middle_Initial.Name = "Middle_Initial";
            this.Middle_Initial.ReadOnly = true;
            this.Middle_Initial.Width = 125;
            // 
            // Home_Phone
            // 
            this.Home_Phone.DataPropertyName = "HomePhone";
            this.Home_Phone.HeaderText = "Home Phone";
            this.Home_Phone.MinimumWidth = 6;
            this.Home_Phone.Name = "Home_Phone";
            this.Home_Phone.ReadOnly = true;
            this.Home_Phone.Width = 125;
            // 
            // Cell_Phone
            // 
            this.Cell_Phone.DataPropertyName = "CellPhone";
            this.Cell_Phone.HeaderText = "Cell Phone";
            this.Cell_Phone.MinimumWidth = 6;
            this.Cell_Phone.Name = "Cell_Phone";
            this.Cell_Phone.ReadOnly = true;
            this.Cell_Phone.Width = 125;
            // 
            // Office_Extension
            // 
            this.Office_Extension.DataPropertyName = "OfficeExtension";
            this.Office_Extension.HeaderText = "Office Extension";
            this.Office_Extension.MinimumWidth = 6;
            this.Office_Extension.Name = "Office_Extension";
            this.Office_Extension.ReadOnly = true;
            this.Office_Extension.Width = 125;
            // 
            // IRD_Number
            // 
            this.IRD_Number.DataPropertyName = "IrdNumber";
            this.IRD_Number.HeaderText = "IRD Number";
            this.IRD_Number.MinimumWidth = 6;
            this.IRD_Number.Name = "IRD_Number";
            this.IRD_Number.ReadOnly = true;
            this.IRD_Number.Width = 125;
            // 
            // Staff_Type
            // 
            this.Staff_Type.DataPropertyName = "StaffCategory";
            this.Staff_Type.HeaderText = "Staff Type";
            this.Staff_Type.MinimumWidth = 6;
            this.Staff_Type.Name = "Staff_Type";
            this.Staff_Type.ReadOnly = true;
            this.Staff_Type.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "StatusDesCription";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // StatusId
            // 
            this.StatusId.DataPropertyName = "Status";
            this.StatusId.HeaderText = "Status Id";
            this.StatusId.MinimumWidth = 6;
            this.StatusId.Name = "StatusId";
            this.StatusId.ReadOnly = true;
            this.StatusId.Visible = false;
            this.StatusId.Width = 125;
            // 
            // StaffId
            // 
            this.StaffId.DataPropertyName = "StaffType";
            this.StaffId.HeaderText = "Staff Id";
            this.StaffId.MinimumWidth = 6;
            this.StaffId.Name = "StaffId";
            this.StaffId.ReadOnly = true;
            this.StaffId.Visible = false;
            this.StaffId.Width = 125;
            // 
            // Status_Navi
            // 
            this.Status_Navi.DataPropertyName = "StatusNavigation";
            this.Status_Navi.HeaderText = "Status Navi";
            this.Status_Navi.MinimumWidth = 6;
            this.Status_Navi.Name = "Status_Navi";
            this.Status_Navi.ReadOnly = true;
            this.Status_Navi.Visible = false;
            this.Status_Navi.Width = 125;
            // 
            // Staff_Nav
            // 
            this.Staff_Nav.DataPropertyName = "StaffTypeNavigation";
            this.Staff_Nav.HeaderText = "Staff Nav";
            this.Staff_Nav.MinimumWidth = 6;
            this.Staff_Nav.Name = "Staff_Nav";
            this.Staff_Nav.ReadOnly = true;
            this.Staff_Nav.Visible = false;
            this.Staff_Nav.Width = 125;
            // 
            // ManagerId
            // 
            this.ManagerId.DataPropertyName = "ManagerId";
            this.ManagerId.HeaderText = "Manager Id";
            this.ManagerId.MinimumWidth = 6;
            this.ManagerId.Name = "ManagerId";
            this.ManagerId.ReadOnly = true;
            this.ManagerId.Visible = false;
            this.ManagerId.Width = 125;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(898, 31);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(212, 42);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(680, 31);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(212, 42);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(462, 31);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(212, 42);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnExport_CSV
            // 
            this.BtnExport_CSV.Location = new System.Drawing.Point(244, 31);
            this.BtnExport_CSV.Name = "BtnExport_CSV";
            this.BtnExport_CSV.Size = new System.Drawing.Size(212, 42);
            this.BtnExport_CSV.TabIndex = 1;
            this.BtnExport_CSV.Text = "Export";
            this.BtnExport_CSV.UseVisualStyleBackColor = true;
            this.BtnExport_CSV.Click += new System.EventHandler(this.BtnExport_CSV_Click);
            // 
            // Btn_Print
            // 
            this.Btn_Print.Location = new System.Drawing.Point(26, 31);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(212, 42);
            this.Btn_Print.TabIndex = 1;
            this.Btn_Print.Text = "Print";
            this.Btn_Print.UseVisualStyleBackColor = true;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Btn_Print);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.BtnExport_CSV);
            this.panel1.Location = new System.Drawing.Point(14, 647);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 100);
            this.panel1.TabIndex = 2;
            // 
            // FrmContactView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewContactData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FrmContactView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContactData;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Middle_Initial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Home_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Office_Extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn IRD_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Navi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Nav;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerId;
        private System.Windows.Forms.Button BtnExport_CSV;
        private System.Windows.Forms.Button Btn_Print;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Panel panel1;
    }
}

