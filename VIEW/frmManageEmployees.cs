using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace VIEW
{
    public partial class frmManageEmployees : Form
    {
        public frmManageEmployees()
        {
            InitializeComponent();
        }
        #region Properties
        List<EmployeesDTO> employeesDTOs = new List<EmployeesDTO>();
        List<EmployeesOfTypeDTO> employeesOfTypeDTOs = new List<EmployeesOfTypeDTO>();
        // List<EmployeesOfTypeDTO> employeesOfTypeInput = new List<EmployeesOfTypeDTO>();
        EmployeesDTO employeesDTO = null;
        #endregion
        #region methods
        void loadListEmp()
        {
            employeesDTOs = EmployeesDAO.loadListEmployDAO();
            gcEmployee.DataSource = employeesDTOs;
        }
        void loadEmployeesOfType()
        {
            employeesOfTypeDTOs = EmployeesOfTypeDAO.loadListEmployeesOfTypeDAO();
            gvcmbRules.DataSource = employeesOfTypeDTOs;
            gvcmbRules.Columns[0].FieldName = "StrID";
            gvcmbRules.Columns[1].FieldName = "StrName";

            //employeesOfTypeDTOs = EmployeesOfTypeDAO.loadListEmployeesOfTypeDAO();
            cmbRule.Properties.DataSource = employeesOfTypeDTOs;
            cmbRule.Properties.Columns[0].FieldName = "StrID";
            cmbRule.Properties.Columns[1].FieldName = "StrName";
        }
        private void frmGridView_Load(object sender, EventArgs e)
        {
            loadListEmp();
            loadEmployeesOfType();
        }

        void loadFromToEmp()
        {
            if(employeesDTO != null)
            {
                txtID.Text = employeesDTO.StrID;
                txtName.Text = em
            }    
        }
        #endregion
        #region Event
        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            EmployeesDTO Emp = new EmployeesDTO();
            Emp.StrID = txtID.Text;
            Emp.StrFullName = txtName.Text;
            Emp.StrNumberPhone = txtPhone.Text;
            Emp.DTBirthDay = dtBirthday.DateTime;
            if (radNam.Checked)
            {
                Emp.StrGender = "Nam";
            }
            if (radNu.Checked)
            {
                Emp.StrGender = "Nữ";
            }
            Emp.StrEmail = txtEmail.Text;
            Emp.StrPassword = txtPassword.Text;
            Emp.StrIDCard = txtIDCard.Text;
            Emp.DecSalary = Convert.ToDecimal(txtSalary.Text);
            Emp.StrEmployTypeID = cmbRule.GetColumnValue("StrID").ToString();

            //ADD IN SQL

            if (EmployeesDAO.addEmployeesDAO(Emp))
            {
                MessageBox.Show("Thêm thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo!");
            }
        }

        private void btnLoadNew_Click(object sender, EventArgs e)
        {
            frmGridView_Load(sender, e);
        }
        #endregion

        private void gvEmployee_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if(gvEmployee.SelectedRowsCount > 0)
            {
                employeesDTO = (EmployeesDTO)gvEmployee.GetRow(gvEmployee.FocusedRowHandle);
            }  
            else
            {
                employeesDTO = null;
            }
            loadFromToEmp();
        }
    }
}
