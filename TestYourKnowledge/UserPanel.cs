using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestYourKnowledge.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestYourKnowledge
{
    public partial class UserPanel : Form
    {
        private readonly Exam exam;
        private readonly Users user;
        private int index = 0;
        public int[] UserAnswers = new int[5];
        public UserPanel(Exam exam, Users user)
        {
            InitializeComponent();
            this.exam = exam;
            this.user = user;
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            label1.Text = exam.Questions[0].question;
            label2.Text = exam.Questions[0].Answers[0].Answer;
            label3.Text = exam.Questions[0].Answers[1].Answer;
            label4.Text = exam.Questions[0].Answers[2].Answer;
            label5.Text = "1";
            button1.Visible = false;
            button3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {

                UserAnswers[index] = 1;
                radioButton1.Checked = false;

            }
            else if (radioButton2.Checked)
            {
                UserAnswers[index] = 2;
                radioButton2.Checked = false;


            }
            else if (radioButton3.Checked)
            {
                UserAnswers[index] = 3;
                radioButton3.Checked = false;


            }

            

            index++;
            if (index == 5)
            {
                button3.Visible = true;
            }
            if (index > 4)
            {
                index = 0;
            }
            label5.Text = (index+1).ToString();
            if (index > 0)
            {
                button1.Visible = true;
            }
            else
            {

                button1.Visible = false;
            }

            label1.Text = exam.Questions[index].question;
            label2.Text = exam.Questions[index].Answers[0].Answer;
            label3.Text = exam.Questions[index].Answers[1].Answer;
            label4.Text = exam.Questions[index].Answers[2].Answer;
            if (UserAnswers[index] == 1)
            {

                radioButton1.Checked = true;

            }
            else if (UserAnswers[index] == 2)
            {
                radioButton2.Checked = true;


            }
            else if (UserAnswers[index] == 3)
            {
                radioButton3.Checked = true;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index--;
            if(index < 0)
            {
                index = 4;
            }
            label5.Text = (index + 1).ToString();
            if (index > 0)
            {
                button1.Visible = true;
            }
            else
            {

                button1.Visible = false;
            }

            label1.Text = exam.Questions[index].question;
            label2.Text = exam.Questions[index].Answers[0].Answer;
            label3.Text = exam.Questions[index].Answers[1].Answer;
            label4.Text = exam.Questions[index].Answers[2].Answer;
            if (UserAnswers[index] == 1)
            {

                radioButton1.Checked = true;

            }
            else if (UserAnswers[index] == 2)
            {
                radioButton2.Checked = true;


            }
            else if (UserAnswers[index] == 3)
            {
                radioButton3.Checked = true;

            }
        }
    }
}
