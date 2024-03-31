using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP_Project
{
    public partial class regPrint : Form
    {
        Registration register;
        public regPrint(Registration register)
        {
            InitializeComponent();
            this.register = register;
        }

        private void Fnameresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Registration newBack = new Registration();
            newBack.Show();
        }

        private void Fnameresult_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void RegFormWithInformation_Load(object sender, EventArgs e)
        {
            label2_fname.Text = register.Fname.Text;
            label_midname.Text = register.Midname.Text;
            label4_lname.Text = register.Lname.Text;
            label_email.Text = register.Email.Text;
            label_age.Text = register.Age.Text;
            label5_month.Text = register.mm.Text;
            label6_day.Text = register.dd.Text;
            label7_year.Text = register.year.Text;
            label_cellno.Text = register.Cell.Text;
            label_addnum.Text = register.Address.Text;
            label_addstreet.Text = register.Street.Text;
            label_addbarangay.Text = register.Barangay.Text;
            label_school.Text = register.School.Text;
            label_zip.Text = register.Zip.Text;

           
        }   
        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {

            Registration registration = new Registration();
            registration.Show();



        }

        private void OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information has been Successfully Saved!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Registration registrationForm = new Registration();
            registrationForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label_cellno_Click(object sender, EventArgs e)
        {

        }

        private void addressNumresult_Click(object sender, EventArgs e)
        {

        }

        private void Monthresult_Click(object sender, EventArgs e)
        {

        }

        private void Dayresult_Click(object sender, EventArgs e)
        {

        }

        private void YearResult_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
