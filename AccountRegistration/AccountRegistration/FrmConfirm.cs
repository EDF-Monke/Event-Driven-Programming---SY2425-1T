using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmConfirm : Form
    {
       
        private delegate string DelegateText();
        private delegate long DelegateNumber();

   
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent(); 

      
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

            this.Load += new System.EventHandler(this.FrmConfirm_Load);
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
           
            lblFirstName.Text = "First Name: " + DelFirstName();
            lblLastName.Text = "Last Name: " + DelLastName();
            lblMiddleName.Text = "Middle Name: " + DelMiddleName();
            lblAddress.Text = "Address: " + DelAddress();
            lblProgram.Text = "Program: " + DelProgram();
            lblAge.Text = "Age: " + DelNumAge().ToString();
            lblContactNo.Text = "Contact Number: " + DelNumContactNo().ToString();
            lblStudentNo.Text = "Student Number: " + DelStudNo().ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
          
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
       
            if (this.DialogResult != DialogResult.OK)
            {
           
            }
        }
    }
}