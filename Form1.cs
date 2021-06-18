using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuziGame
{
    public partial class Form1 : Form
    {

        // quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 9;

        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {


            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)

            {

                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)

        {

            switch (qnum)
            {



                case 1:
                    pictureBox.Image = Properties.Resources.questionMark;

                    Question.Text = "Who is the Facilitator at CapeNexis Data Solution";

                    button1.Text = "Wisdom";
                    button2.Text = "Chesan";
                    button3.Text = "Mr Mametsa";
                    button4.Text = "Jacksom";

                    correctAnswer = 1;

                    break;

                case 2:
                    pictureBox.Image = Properties.Resources.DECO;

                    Question.Text = "Who is the direct Manager at CapeNexis Data Solution?";

                    button1.Text = "Willam";
                    button2.Text = "Wisdom";
                    button3.Text = "Chesan";
                    button4.Text = "Sonti";

                    correctAnswer = 3;

                    break;

                case 3:
                    pictureBox.Image = Properties.Resources.DECO;

                    Question.Text = "How many candidate attending at CapeNexis Data Solution?";

                    button1.Text = "15";
                    button2.Text = "10";
                    button3.Text = "20";
                    button4.Text = "50";

                    correctAnswer = 2;

                    break;

                case 4:
                    pictureBox.Image = Properties.Resources.DECO;

                    Question.Text = "Where learnship located ?";

                    button1.Text = "Sebayeng";
                    button2.Text = "Turf Loop";
                    button3.Text = "Ga Dikgale";
                    button4.Text = "Makotopong";

                    correctAnswer = 4;

                    break;

                case 5:
                    pictureBox.Image = Properties.Resources.DECO;

                    Question.Text = "What is the aim of the program?";

                    button1.Text = "Learning about Enterpreneurship";
                    button2.Text = "Developing or Creating Website and Application";
                    button3.Text = "Marking";
                    button4.Text = "Gain konwledge";

                    correctAnswer = 2;

                    break;

                case 6:
                    pictureBox.Image = Properties.Resources.DECO;

                    Question.Text = "When did you heared about CapeNexis Data Solution";

                    button1.Text = "2015";
                    button2.Text = "2011";
                    button3.Text = "2017";
                    button4.Text = "2014";

                    correctAnswer = 3;

                    break;

                case 7:
                    pictureBox.Image = Properties.Resources.DECO;

                    Question.Text = "When did this program start";

                    button1.Text = "2021 ";
                    button2.Text = "2019";
                    button3.Text = "2018";
                    button4.Text = "2020";

                    correctAnswer = 1;

                    break;

                case 8:
                    pictureBox.Image = Properties.Resources.DECO;

                    Question.Text = " How many boys are in the program";

                    button1.Text = "24 boys";
                    button2.Text = "15 boys";
                    button3.Text = "4 boys";
                    button4.Text = "2 boys";

                    correctAnswer = 4;

                    break;

                case 9:
                    pictureBox.Image = Properties.Resources.DECO;

                    Question.Text = "How many girls are in the program";

                    button1.Text = "14 girls";
                    button2.Text = "8 girls";
                    button3.Text = "6 girls";
                    button4.Text = "20 girls";

                    correctAnswer = 2;

                    break;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
