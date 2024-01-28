using CompanyStaffContact.UIDataModel;
using CompanyStaffContact.UIDataModel.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CompanyStaffContact
{
    public partial class FrmAddEditContact : Form
    {
        public int empRadioButton = 0;
        public int empStatusButton = 0;
        public int managerId = 0;
        public ContactDetailDTO contactDetail;
        FrmContactView _parent;
        public FrmAddEditContact(ContactDetailDTO contactDetailDTO, FrmContactView parent)
        {
            _parent = parent;
            InitializeComponent();
            LoadManagerList();

            if (contactDetailDTO.Id > 0)
            {
                contactDetail = contactDetailDTO;
                TxtTitle.Text = contactDetailDTO.Title;
                TxtFName.Text = contactDetailDTO.FirstName;
                TxtLName.Text = contactDetailDTO.LastName;
                TxtInitial.Text = contactDetailDTO.MiddleInitial;
                TxtHPhone.Text = contactDetailDTO.HomePhone;
                TxtCellPhone.Text = contactDetailDTO.CellPhone;
                TxtIRDNumber.Text = contactDetailDTO.IrdNumber;
                TxtOfzPhone.Text = contactDetailDTO.OfficeExtension;
                if (contactDetailDTO.Status == (int)EnumStatus.Active)
                {
                    RbtActive.Checked = true;
                }
                if (contactDetailDTO.Status == (int)EnumStatus.Pending)
                {
                    RbtPending.Checked = true;
                }
                if(contactDetailDTO.Status == (int)EnumStatus.Inactive)
                {
                    RbtInactive.Checked = true;
                }
                if (contactDetailDTO.StaffType == (int)EnumStaffType.Employee)
                {
                    RbtEmployee.Checked = true;
                }
                if (contactDetailDTO.StaffType == (int)EnumStaffType.Manager)
                {
                    RbtManager.Checked = true;
                    LblManager.Visible = true;
                    CmbManager.Visible = true;
                    CmbManager.SelectedIndex = managerId;

                }
            }
        }

        private void LoadManagerList()
        {
            try
            {
                List<ContactDetailDTO> empobj = null;
                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("http://localhost:5230/api/StaffContact/");
                var consumeapi = hc.GetAsync("GetManagerList");
                consumeapi.Wait();

                //Read the data
                var readdata = consumeapi.Result;
                if (readdata.IsSuccessStatusCode)
                {
                    var displaydata = readdata.Content.ReadAsAsync<List<ContactDetailDTO>>();
                    displaydata.Wait();

                    empobj = displaydata.Result;

                    CmbManager.DataSource = empobj;

                    CmbManager.DisplayMember = "FirstName";
                    CmbManager.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name != "FrmContactView")
                        {
                            f.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValidate())
                {
                    if (contactDetail != null && contactDetail.Id > 0) {

                        contactDetail.Title = TxtTitle.Text.ToString();
                        contactDetail.FirstName = TxtFName.Text.ToString();
                        contactDetail.LastName = TxtLName.Text.ToString();
                        contactDetail.MiddleInitial = TxtInitial.Text.ToString();
                        contactDetail.HomePhone = TxtHPhone.Text.ToString();
                        contactDetail.CellPhone = TxtCellPhone.Text.ToString();
                        contactDetail.IrdNumber = TxtIRDNumber.Text.ToString();
                        contactDetail.OfficeExtension = TxtOfzPhone.Text.ToString();
                        contactDetail.StaffType = empRadioButton;
                        contactDetail.Status = empStatusButton;
                        contactDetail.ManagerId = managerId != 0 ? managerId : (int)CmbManager.SelectedValue;

                        HttpClient hc = new HttpClient();
                        hc.BaseAddress = new Uri("http://localhost:5230/api/StaffContact/");
                        var data = JsonConvert.SerializeObject(contactDetail);
                        var content = new StringContent(data, Encoding.UTF8, "application/json");
                        var consumeapi = hc.PutAsync("Edit", content);
                        consumeapi.Wait();

                        //Read the data
                        var readdata = consumeapi.Result;
                        if (readdata.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Successfully Updated", "Update", MessageBoxButtons.OK);
                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name != "FrmContactView")
                                {
                                    f.Close();
                                }
                            }

                        }
                    }
                    else
                    {

                        ContactDetailDTO contactDetailDTO = new ContactDetailDTO();
                        contactDetailDTO.Title = TxtTitle.Text.ToString();
                        contactDetailDTO.FirstName = TxtFName.Text.ToString();
                        contactDetailDTO.LastName = TxtLName.Text.ToString();
                        contactDetailDTO.MiddleInitial = TxtInitial.Text.ToString();
                        contactDetailDTO.HomePhone = TxtHPhone.Text.ToString();
                        contactDetailDTO.CellPhone = TxtCellPhone.Text.ToString();
                        contactDetailDTO.IrdNumber = TxtIRDNumber.Text.ToString();
                        contactDetailDTO.OfficeExtension = TxtOfzPhone.Text.ToString();
                        contactDetailDTO.StaffType = empRadioButton;
                        contactDetailDTO.Status = empStatusButton;
                        contactDetailDTO.ManagerId = managerId != 0 ? managerId : (int)CmbManager.SelectedValue;

                        HttpClient hc = new HttpClient();
                        hc.BaseAddress = new Uri("http://localhost:5230/api/StaffContact/");
                        var data = JsonConvert.SerializeObject(contactDetailDTO);
                        var content = new StringContent(data, Encoding.UTF8, "application/json");
                        var consumeapi = hc.PostAsync("Creates", content);
                        consumeapi.Wait();

                        //Read the data
                        var readdata = consumeapi.Result;
                        if (readdata.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Successfully Saved", "Save", MessageBoxButtons.OK);
                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name != "FrmContactView")
                                {
                                    f.Close();
                                }
                            }

                        }

                    }

                    
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private bool CheckValidate()
        {
            try
            {
                bool IsValidate = false;
                if (!string.IsNullOrEmpty(TxtTitle.Text.ToString()) && !string.IsNullOrEmpty(TxtFName.Text.ToString()) && !string.IsNullOrEmpty(TxtLName.Text.ToString())
                    && !string.IsNullOrEmpty(TxtInitial.Text.ToString()) && !string.IsNullOrEmpty(TxtHPhone.Text.ToString()) && !string.IsNullOrEmpty(TxtCellPhone.Text.ToString())
                    && !string.IsNullOrEmpty(TxtOfzPhone.Text.ToString()) && !string.IsNullOrEmpty(TxtCellPhone.Text.ToString()) && empRadioButton != 0 && empStatusButton !=0)
                {

                    IsValidate = true;
                }

                return IsValidate;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void RbtEmployee_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        empRadioButton = (int)EnumStaffType.Employee;
                        LblManager.Visible = true;
                        CmbManager.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
         
        }

        private void RbtManager_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        empRadioButton = (int)EnumStaffType.Manager;
                        LblManager.Visible = false;
                        CmbManager.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        private void RbtActive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        empStatusButton = (int)EnumStatus.Active;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
         
        }

        private void RbtInactive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        empStatusButton = (int)EnumStatus.Inactive;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void RbtPending_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton rb = sender as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        empStatusButton = (int)EnumStatus.Pending;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FrmAddEditContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            _parent.RefreshData();
        }

        private void TxtHPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtHPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                TxtHPhone.Text = TxtHPhone.Text.Remove(TxtHPhone.Text.Length - 1);
            }
        }

       

        private void TxtCellPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtCellPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                TxtCellPhone.Text = TxtCellPhone.Text.Remove(TxtCellPhone.Text.Length - 1);
            }
        }

        private void TxtOfzPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtOfzPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                TxtOfzPhone.Text = TxtOfzPhone.Text.Remove(TxtOfzPhone.Text.Length - 1);
            }
        }

        private void TxtIRDNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtIRDNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                TxtIRDNumber.Text = TxtIRDNumber.Text.Remove(TxtIRDNumber.Text.Length - 1);
            }
        }
    }
}
