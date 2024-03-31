using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace Salinas_OOP
{

    public partial class Quiz : Form
    {
        int correctAnswer, score, totalQuestion, percentage, questionNumber = 1;
        public Quiz()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestion = 10;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestion)
            {
                DialogResult result = MessageBox.Show("Quiz Ended!" + Environment.NewLine + "You have answered " + score + " questions correctly. ");

                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {
            btnAns1.Tag = 1;
            btnAns2.Tag = 2;
            btnAns3.Tag = 3;
            btnAns4.Tag = 4;
            switch (qnum)
            {
                case 1:

                    lblQuestion.Text = "Hiding complexity can also be termed as";
                    btnAns1.Text = "Encapsualtion";
                    btnAns2.Text = "Overloading";
                    btnAns3.Text = "Abstraction";
                    btnAns4.Text = "Overriding";

                    correctAnswer = 2;
                    break;
                case 2:
                    lblQuestion.Text = "Which one of the following is the process where an object of one class receives the properties of objects of another class?";
                    btnAns1.Text = "Encapsulation";
                    btnAns2.Text = "Inheritance";
                    btnAns3.Text = "Polymorphism";
                    btnAns4.Text = "Modularity";

                    correctAnswer = 2;
                    break;
                case 3:
                    lblQuestion.Text = "An object that has more than one form is referred to as";
                    btnAns1.Text = "Polymorphism";
                    btnAns2.Text = "Inheritance";
                    btnAns3.Text = "Interface";
                    btnAns4.Text = "Abstract Class";

                    correctAnswer = 1;
                    break;
                case 4:
                    lblQuestion.Text = "Attributes of an object are also known as";

                    btnAns1.Text = "Methods";
                    btnAns2.Text = "Properties";
                    btnAns3.Text = "Classes";
                    btnAns4.Text = "Function";

                    correctAnswer = 3;
                    break;
                case 5:
                    lblQuestion.Text = "Polymorphism related to";
                    btnAns1.Text = "Datu Puti";
                    btnAns2.Text = "MISS NA KITA";
                    btnAns3.Text = "OOP";
                    btnAns4.Text = "halimawmagselos";

                    correctAnswer = 3;
                    break;
                case 6:
                    lblQuestion.Text = "Method that is called when an object is instantiated from a class to initialise the object....";
                    btnAns1.Text = "Class";
                    btnAns2.Text = "InheritanceA";
                    btnAns3.Text = "Object";
                    btnAns4.Text = "Constructor";

                    correctAnswer = 4;
                    break;
                case 7:
                    lblQuestion.Text = "The wrapping up of data and functions into a single unit is called?";
                    btnAns1.Text = "Overloading";
                    btnAns2.Text = "Class";
                    btnAns3.Text = "Encapsulation ";
                    btnAns4.Text = "Object";

                    correctAnswer = 3;
                    break;
                case 8:
                    lblQuestion.Text = "When sub class declares a method that has the same type of arguments as a method declared by one of its superclasses, it is termed as:";
                    btnAns1.Text = "Method Overriding";
                    btnAns2.Text = "Method Overloading";
                    btnAns3.Text = "Overdabakod";
                    btnAns4.Text = "Overpass";

                    correctAnswer = 1;
                    break;
                case 9:
                    lblQuestion.Text = "What type of naming convention is this hindiNyakoMahal";
                    btnAns1.Text = "Pascal Case";
                    btnAns2.Text = "Camel Case";
                    btnAns3.Text = "Brief Case ";
                    btnAns4.Text = "Pa Case";

                    correctAnswer = 2;
                    break;
                case 10:
                    lblQuestion.Text = "What index is the number 5 [1,2,3,4,5]";
                    btnAns1.Text = "Index 5";
                    btnAns2.Text = "Index 4";
                    btnAns3.Text = "Index 2";
                    btnAns4.Text = "Index 1";

                    correctAnswer = 2;
                    break;
            }
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }

}
