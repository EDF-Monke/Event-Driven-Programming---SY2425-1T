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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Set values to StudentInfoClass
            StudentInfoClass.FirstName = txtFirstName.Text;
            StudentInfoClass.LastName = txtLastName.Text;
            StudentInfoClass.MiddleName = txtMiddleName.Text;
            StudentInfoClass.Address = txtAddress.Text;
            StudentInfoClass.Program = cbProgram.Text;

            try
            {
                // Parse the values from textboxes to long
                StudentInfoClass.Age = long.Parse(txtAge.Text);
                StudentInfoClass.ContactNo = long.Parse(txtContactNo.Text);
                StudentInfoClass.StudentNo = long.Parse(txtStudentNo.Text);
            }
            catch (FormatException)
            {
                // Show an error message if there's a format exception
                MessageBox.Show("Please enter valid numbers for Age, Contact No, and Student No.");
                return; // Exit the method if there's an error
            }

            // Create and show FrmConfirm
            using (FrmConfirm frmConfirm = new FrmConfirm())
            {
                // Check if FrmConfirm was closed with OK result
                if (frmConfirm.ShowDialog() == DialogResult.OK)
                {
                    // Reset the input fields
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtMiddleName.Text = "";
                    txtAddress.Text = "";
                    cbProgram.SelectedIndex = -1; // Deselect the selected item in the ComboBox
                    txtAge.Text = "";
                    txtContactNo.Text = "";
                    txtStudentNo.Text = "";
                }
            }
        }

        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //PROPERTIES -> LIGHTNING -> CLICK
        private void Form1_Load(object sender, EventArgs e)
        {
            cbProgram.Items.Add("BSIT");
            cbProgram.Items.Add("Comics");
            cbProgram.Items.Add("Puppetry");
            cbProgram.Items.Add("Ethical Hacking");
            cbProgram.Items.Add("Bakery Science");
            cbProgram.Items.Add("Fire Engineering");
        }
    }
}
