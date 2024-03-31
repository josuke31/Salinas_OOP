
using OOP_Project;
using OOPProjectSALINAS;
using System.Drawing;
using System;

namespace Salinas_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit the application?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculator calculator = new calculator();
            calculator.Show();
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }

        private void studenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studForm form = new studForm();
            form.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File As";
            saveFileDialog.Filter = "All Files (.)";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;


                    string dataToSave = saveAllToolStripMenuItem.Text;


                    File.WriteAllText(filePath, dataToSave);

                    MessageBox.Show("File Saved Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a File";
            openFileDialog.Filter = "All Files (.)";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;


                    string fileContent = File.ReadAllText(filePath);


                    openToolStripMenuItem.Text = fileContent;

                    MessageBox.Show("File Loaded Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void quizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Show();
        }
    }
}