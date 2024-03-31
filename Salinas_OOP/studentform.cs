using OOP_Project;
namespace OOP_Project
{
    public partial class studForm : Form
    {
        public studForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateNoNumbers(txtFirstName.Text, "First Name");
                ValidateNoNumbers(txtMiddleName.Text, "Middle Name");
                ValidateNoNumbers(txtSurname.Text, "Surname");
                ValidateNoLetters(txtContact.Text, "Contact");
                ValidateNoNumbers(txtBrgy.Text, "Barangay");
                ValidateNoNumbers(txtMuni.Text, "Municipality");
                ValidateNoNumbers(txtCountry.Text, "Country");
                ValidateNoLetters(txtPostal.Text, "Postal Code");
                ValidateNoNumbers(txtCourse.Text, "Course");
                ValidateNoNumbers(txtReligion.Text, "Religion");
                ValidateNoLetters(txtContact.Text, "Contact Number");
                ValidateNoNumbers(txtfName.Text, "Father's Name");
                ValidateNoNumbers(txtmName.Text, "Mothers's Name");
                ValidateNoLetters(txtFcontact.Text, "Father's Contact Number");
                ValidateNoLetters(txtMcontact.Text, "Mothers's Contact Number");
                ValidateNoNumbers(txtfOccupation.Text, "Father's Occupation");
                ValidateNoNumbers(txtmOccupation.Text, "Mother's Occupation");
                ValidateNoNumbers(txtElem.Text, "Elementary");
                ValidateNoNumbers(txtElemAdv.Text, "Elementary's Adviser");
                ValidateNoNumbers(txtHighS.Text, "High School");
                ValidateNoNumbers(txtHighSAdv.Text, "High School's Adviser");
                ValidateNoLetters(txtCampus.Text, "Campus");


                MessageBox.Show("Successfully Registered", "Registering", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            void ValidateNoNumbers(string input, string fieldName)
            {
                foreach (char c in input)
                {
                    if (char.IsDigit(c))
                        throw new ArgumentException(fieldName + " cannot contain numbers");
                }
            }

            void ValidateNoLetters(string input, string fieldName)
            {
                foreach (char c in input)
                {
                    if (char.IsLetter(c))
                        throw new ArgumentException(fieldName + " cannot contain letters");
                }
            }


        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMiddle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}