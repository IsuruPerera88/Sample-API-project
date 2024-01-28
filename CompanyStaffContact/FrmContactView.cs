using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Data.SqlClient;
using CompanyStaffContact.UIDataModel;
using CompanyStaffContact.UIDataModel.Enum;
using System.IO;
using System.Drawing.Printing;

namespace CompanyStaffContact
{
    public partial class FrmContactView : Form
    {
        public List<ContactDetailDTO> contactDetail;
        public ContactDetailDTO contactdetailData;
        public int selectedId = 0;
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrinted = 0;
        public FrmContactView()
        {
            InitializeComponent();
            RefreshData();
        }

        public void RefreshData()
        {
          
                try
                {
                    List<ContactDetailDTO> empobj = null;
                    HttpClient hc = new HttpClient();
                    hc.BaseAddress = new Uri("http://localhost:5230/api/StaffContact/");
                    var consumeapi = hc.GetAsync("Index");
                    consumeapi.Wait();

                    //Read the data
                    var readdata = consumeapi.Result;
                    if (readdata.IsSuccessStatusCode)
                    {
                        var displaydata = readdata.Content.ReadAsAsync<List<ContactDetailDTO>>();
                        displaydata.Wait();

                        empobj = displaydata.Result;
                        contactDetail = empobj.ToList();

                    foreach (ContactDetailDTO item in empobj)
                    {
                        item.StaffCategory = ((EnumStaffType)item.StaffType).ToString();
                        item.StatusDesCription = ((EnumStatus)item.Status).ToString();
                    }

                        if (empobj.Count > 0)
                        {
                            dataGridViewContactData.DataSource = empobj;
                            dataGridViewContactData.Rows[0].Selected = true;
                        }
                        
                    }
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ContactDetailDTO contactdetail = new ContactDetailDTO();
                FrmAddEditContact frmAddEditContact = new FrmAddEditContact(contactdetail,this);
                frmAddEditContact.ShowDialog();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void dataGridViewContactData_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewContactData.SelectedRows)
                {
                    int Id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    selectedId = Id;
                    contactdetailData = contactDetail?.FirstOrDefault(x => x.Id == Id);

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddEditContact frmAddEditContact = new FrmAddEditContact(contactdetailData,this);
                frmAddEditContact.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("Do you really want to delete?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    HttpClient hc = new HttpClient();
                    hc.BaseAddress = new Uri("http://localhost:5230/api/StaffContact/");
                    var consumeapi = hc.DeleteAsync("Delete?id=" + selectedId);
                    consumeapi.Wait();

                    //Read the data
                    var readdata = consumeapi.Result;
                    if (readdata.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Successfully Updated", "Update", MessageBoxButtons.OK);
                        RefreshData();
                    }
                }
               
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnExport_CSV_Click(object sender, EventArgs e)
        {
            if (dataGridViewContactData.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV (*.csv)|*.csv";
                saveFileDialog.FileName="";
                bool fileError = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        try
                        {
                            File.Delete(saveFileDialog.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Cannot Save." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridViewContactData.Columns.Count;
                            string columnNames = "";
                            string[] csvFileData = new string[dataGridViewContactData.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                if (dataGridViewContactData.Columns[i].Visible)
                                {
                                    columnNames += dataGridViewContactData.Columns[i].HeaderText.ToString() + ",";
                                }
                                
                            }
                            csvFileData[0] += columnNames;

                            for (int i = 1; (i - 1) < dataGridViewContactData.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    if (dataGridViewContactData.Rows[i - 1].Cells[j].Visible)
                                    {
                                        csvFileData[i] += dataGridViewContactData.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                    
                                }
                            }

                            File.WriteAllLines(saveFileDialog.FileName, csvFileData, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.PrintDialog printDialog = new PrintDialog();
                printDialog.AllowSomePages = true;
                printDialog.ShowHelp = true;
                printDialog.Document = printDocument;
                DialogResult result = printDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string head = "Company Staff Contact";
            e.Graphics.DrawString(head, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 350, 50);

            string l1 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 0, 100);

            string g1 = "Title ";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 20, 140);

            string g2 = "First Name";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 60, 140);

            string g3 = "Last Name";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 150, 140);

            string g4 = "Middle Initial";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 230, 140);

            string g5 = "Home Phone";
            e.Graphics.DrawString(g5, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 330, 140);

            string g6 = "Cell Phone";
            e.Graphics.DrawString(g6, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 410, 140);

            string g7 = "Office Extension";
            e.Graphics.DrawString(g7, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 490, 140);

            string g8 = "IRD Number";
            e.Graphics.DrawString(g8, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 600, 140);

            string g9 = "Staff Type";
            e.Graphics.DrawString(g9, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 690, 140);

            string g10 = "Status";
            e.Graphics.DrawString(g10, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 770, 140);

            string l2 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 0, 160);

            int height = 165;
            for (int i = numberOfItemsPrinted; i < dataGridViewContactData.Rows.Count; i++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrinted++;

                    if (numberOfItemsPrinted <= dataGridViewContactData.Rows.Count)
                    {

                        height += dataGridViewContactData.Rows[0].Height;
                        e.Graphics.DrawString(dataGridViewContactData.Rows[i].Cells[1].FormattedValue.ToString(), dataGridViewContactData.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(20, height, dataGridViewContactData.Columns[0].Width, dataGridViewContactData.Rows[0].Height));
                        e.Graphics.DrawString(dataGridViewContactData.Rows[i].Cells[2].FormattedValue.ToString(), dataGridViewContactData.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(60, height, dataGridViewContactData.Columns[0].Width, dataGridViewContactData.Rows[0].Height));
                        e.Graphics.DrawString(dataGridViewContactData.Rows[i].Cells[3].FormattedValue.ToString(), dataGridViewContactData.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(150, height, dataGridViewContactData.Columns[0].Width, dataGridViewContactData.Rows[0].Height));
                        e.Graphics.DrawString(dataGridViewContactData.Rows[i].Cells[4].FormattedValue.ToString(), dataGridViewContactData.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(230, height, dataGridViewContactData.Columns[0].Width, dataGridViewContactData.Rows[0].Height));
                        e.Graphics.DrawString(dataGridViewContactData.Rows[i].Cells[5].FormattedValue.ToString(), dataGridViewContactData.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(330, height, dataGridViewContactData.Columns[0].Width, dataGridViewContactData.Rows[0].Height));
                        e.Graphics.DrawString(dataGridViewContactData.Rows[i].Cells[6].FormattedValue.ToString(), dataGridViewContactData.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(410, height, dataGridViewContactData.Columns[0].Width, dataGridViewContactData.Rows[0].Height));
                        e.Graphics.DrawString(dataGridViewContactData.Rows[i].Cells[7].FormattedValue.ToString(), dataGridViewContactData.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(490, height, dataGridViewContactData.Columns[0].Width, dataGridViewContactData.Rows[0].Height));
                        e.Graphics.DrawString(dataGridViewContactData.Rows[i].Cells[8].FormattedValue.ToString(), dataGridViewContactData.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(600, height, dataGridViewContactData.Columns[0].Width, dataGridViewContactData.Rows[0].Height));
                        e.Graphics.DrawString(dataGridViewContactData.Rows[i].Cells[13].FormattedValue.ToString(), dataGridViewContactData.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(690, height, dataGridViewContactData.Columns[0].Width, dataGridViewContactData.Rows[0].Height));
                        e.Graphics.DrawString(dataGridViewContactData.Rows[i].Cells[12].FormattedValue.ToString(), dataGridViewContactData.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(770, height, dataGridViewContactData.Columns[0].Width, dataGridViewContactData.Rows[0].Height));
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }

                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;

                }


            }
            numberOfItemsPerPage = 0;
            numberOfItemsPrinted = 0;
        }
    }
}
