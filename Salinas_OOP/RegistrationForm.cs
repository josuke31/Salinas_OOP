using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                string firstName = Fname.Text;
                string lastName = Lname.Text;
                string middleName = Midname.Text;
                string email = Email.Text;
                int age = Convert.ToInt32(Age.Text);
                int birthMonth = Convert.ToInt32(mm.Text);
                int birthDay = Convert.ToInt32(dd.Text);
                int birthYear = Convert.ToInt32(year.Text);
                double contactNo = Convert.ToDouble(Cell.Text);
                string schoolName = School.Text;
                string addressName = Address.Text;
                string streetName = Street.Text;
                string barangayName = Barangay.Text;
                int zipCode = Convert.ToInt32(Zip.Text);
                MessageBox.Show("Are you sure? Please double check your information", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                regPrint Form = new regPrint(this);
                Form.Show();

                



            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            
        }

        private void Close(object sender, EventArgs e)
        {
            
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
           
        }

        private void backbutton_Click_1(object sender, EventArgs e)
        {
 
        }

        private void Cell_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
