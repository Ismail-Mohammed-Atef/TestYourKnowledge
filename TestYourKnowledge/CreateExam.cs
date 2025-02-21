using Microsoft.IdentityModel.Tokens;
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

namespace TestYourKnowledge
{
    public partial class CreateExam : Form
    {
        public event EventHandler<string> DataSent;

        ExamContext context = new ExamContext();
        public Question[] Questions { get; set; } = new Question[5];
        public int index = 0;
        private readonly Exam exam;

        public CreateExam(Exam exam)
        {
            InitializeComponent();
            this.exam = exam;
        }
        public CreateExam()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateExam_Load(object sender, EventArgs e)
        {
            label5.Text = "1";
            button3.Visible = false;
            if (exam != null)
            {
                textBox1.Text = exam.Questions[index].question;
                textBox2.Text = exam.Questions[index].Answers[0].Answer;
                radioButton2.Checked = exam.Questions[index].Answers[0].RightAnswer;
                textBox3.Text = exam.Questions[index].Answers[1].Answer;
                radioButton1.Checked = exam.Questions[index].Answers[1].RightAnswer;
                textBox4.Text = exam.Questions[index].Answers[2].Answer;
                radioButton3.Checked = exam.Questions[index].Answers[2].RightAnswer;
               
            }
            
            if (index == 0)
            {
                button2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (exam == null)
            {
                
                if (Questions[index] is null)
                {

                    Questions[index] = new Question();
                    Questions[index].question = textBox1.Text;
                    textBox1.Text = string.Empty;

                    Questions[index].Answers = new List<Answers>();

                    Answers answer1 = new Answers()
                    {
                        Answer = textBox2.Text,

                        RightAnswer = radioButton2.Checked,
                    };
                    textBox2.Text = string.Empty;
                    radioButton2.Checked = false;
                    Questions[index].Answers.Add(answer1);

                    //Questions[index].Answers[0].Answer = textBox2.Text;
                    //Questions[index].Answers[0].RightAnswer = radioButton2.Checked;

                    Answers answer2 = new Answers()
                    {
                        Answer = textBox3.Text,
                        RightAnswer = radioButton1.Checked,
                    };
                    textBox3.Text = string.Empty;
                    radioButton1.Checked = false;

                    Questions[index].Answers.Add(answer2);

                    //Questions[index].Answers[1] = new Answers();
                    //Questions[index].Answers[1].Answer = textBox3.Text;
                    //Questions[index].Answers[1].RightAnswer = radioButton1.Checked;

                    Answers answer3 = new Answers()
                    {
                        Answer = textBox4.Text,
                        RightAnswer = radioButton3.Checked,
                    };
                    textBox4.Text = string.Empty;
                    radioButton3.Checked = false;

                    Questions[index].Answers.Add(answer3);

                    //Questions[index].Answers[2] = new Answers();
                    //Questions[index].Answers[2].Answer = textBox4.Text;
                    //Questions[index].Answers[2].RightAnswer = radioButton3.Checked;

                    index++;
                    if (index == 5)
                    {
                        button3.Visible = true;
                    }
                    if (index > 4)
                    {
                        index = 0;
                    }
                    label5.Text = (index + 1).ToString();

                    textBox1.Text = Questions[index]?.question ?? string.Empty;
                    textBox2.Text = Questions[index]?.Answers[0]?.Answer ??string.Empty;
                    radioButton2.Checked = Questions[index]?.Answers[0]?.RightAnswer??false;
                    textBox3.Text = Questions[index]?.Answers[1]?.Answer ??string.Empty;
                    radioButton1.Checked = Questions[index]?.Answers[1]?.RightAnswer??false;
                    textBox4.Text = Questions[index]?.Answers[2]?.Answer ?? string.Empty;
                    radioButton3.Checked = Questions[index]?.Answers[2]?.RightAnswer??false;

                }
                else
                {
                    Questions[index] = new Question();
                    Questions[index].question = textBox1.Text;
                    textBox1.Text = string.Empty;

                    Questions[index].Answers = new List<Answers>();

                    Answers answer1 = new Answers()
                    {
                        Answer = textBox2.Text,

                        RightAnswer = radioButton2.Checked,
                    };
                    textBox2.Text = string.Empty;

                    Questions[index].Answers.Add(answer1);

                    //Questions[index].Answers[0].Answer = textBox2.Text;
                    //Questions[index].Answers[0].RightAnswer = radioButton2.Checked;

                    Answers answer2 = new Answers()
                    {
                        Answer = textBox3.Text,
                        RightAnswer = radioButton1.Checked,
                    };
                    textBox3.Text = string.Empty;

                    Questions[index].Answers.Add(answer2);

                    //Questions[index].Answers[1] = new Answers();
                    //Questions[index].Answers[1].Answer = textBox3.Text;
                    //Questions[index].Answers[1].RightAnswer = radioButton1.Checked;

                    Answers answer3 = new Answers()
                    {
                        Answer = textBox4.Text,
                        RightAnswer = radioButton3.Checked,
                    };
                    textBox4.Text = string.Empty;

                    Questions[index].Answers.Add(answer3);

                    //Questions[index].Answers[2] = new Answers();
                    //Questions[index].Answers[2].Answer = textBox4.Text;
                    //Questions[index].Answers[2].RightAnswer = radioButton3.Checked;

                    index++;
                    if (index == 5)
                    {
                        button3.Visible = true;
                    }
                    if (index > 4)
                    {
                        index = 0;
                    }
                    label5.Text = (index + 1).ToString();

                    textBox1.Text = Questions[index]?.question;
                    textBox2.Text = Questions[index]?.Answers[0]?.Answer;
                    radioButton2.Checked = Questions[index]?.Answers[0]?.RightAnswer??false;
                    textBox3.Text = Questions[index]?.Answers[1]?.Answer;
                    radioButton1.Checked = Questions[index]?.Answers[1]?.RightAnswer??false;
                    textBox4.Text = Questions[index]?.Answers[2]?.Answer;
                    radioButton3.Checked = Questions[index]?.Answers[2]?.RightAnswer??false;
                }
                
                
                if (index > 0)
                {
                    button2.Visible = true;
                }
                else
                {

                    button2.Visible = false;
                }
            }
            else
            {
                if (radioButton2.Checked)
                {
                    exam.Questions[index].Answers[0].RightAnswer = true;
                    exam.Questions[index].Answers[1].RightAnswer = false;
                    exam.Questions[index].Answers[2].RightAnswer = false;

                }
                else if (radioButton1.Checked)
                {
                    exam.Questions[index].Answers[0].RightAnswer = false;
                    exam.Questions[index].Answers[1].RightAnswer = true;
                    exam.Questions[index].Answers[2].RightAnswer = false;
                }
                else if (radioButton3.Checked)
                {
                    exam.Questions[index].Answers[0].RightAnswer = false;
                    exam.Questions[index].Answers[1].RightAnswer = false;
                    exam.Questions[index].Answers[2].RightAnswer = true;
                }
                index++;
                if (index == 4)
                {
                    button3.Visible = true;
                }
                if (index > 4)
                {
                    index = 0;
                }
                if (index > 0)
                {
                    button2.Visible = true;
                }
                else
                {

                    button2.Visible = false;
                }
                label5.Text = (index + 1).ToString();

                textBox1.Text = exam.Questions[index].question ;
                textBox2.Text = exam.Questions[index].Answers[0].Answer ;
                radioButton2.Checked = exam.Questions[index].Answers[0].RightAnswer;
                textBox3.Text = exam.Questions[index].Answers[1].Answer ;
                radioButton1.Checked = exam.Questions[index].Answers[1].RightAnswer ;
                textBox4.Text = exam.Questions[index].Answers[2].Answer ;
                radioButton3.Checked = exam.Questions[index].Answers[2].RightAnswer;
               

                if (index == 4)
                {
                    button3.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (exam is null)
            {
                
                index--;
                if (index < 0)
                {
                    index = 4;
                }
                if (index > 0)
                {
                    button2.Visible = true;
                }
                else
                {

                    button2.Visible = false;
                }
                textBox1.Text = Questions[index].question ;
                textBox2.Text = Questions[index].Answers[0].Answer ;
                radioButton2.Checked = Questions[index].Answers[0].RightAnswer ;
                textBox3.Text = Questions[index].Answers[1].Answer;
                radioButton1.Checked = Questions[index].Answers[1].RightAnswer ;
                textBox4.Text = Questions[index].Answers[2].Answer ;
                radioButton3.Checked = Questions[index].Answers[2].RightAnswer ;
                label5.Text = (index +1).ToString();
                if (index == 4)
                {
                    button3.Visible = true;
                }
            }
            else
            {
                if (radioButton2.Checked)
                {
                    exam.Questions[index].Answers[0].RightAnswer = true;
                    exam.Questions[index].Answers[1].RightAnswer = false;
                    exam.Questions[index].Answers[2].RightAnswer = false;

                }
                else if (radioButton1.Checked)
                {
                    exam.Questions[index].Answers[0].RightAnswer = false;
                    exam.Questions[index].Answers[1].RightAnswer = true;
                    exam.Questions[index].Answers[2].RightAnswer = false;
                }
                else if (radioButton3.Checked)
                {
                    exam.Questions[index].Answers[0].RightAnswer = false;
                    exam.Questions[index].Answers[1].RightAnswer = false;
                    exam.Questions[index].Answers[2].RightAnswer = true;
                }
                index--;
                if (index < 0)
                {
                    index = 4;
                }
                if (index > 0)
                {
                    button2.Visible = true;
                }
                else
                {

                    button2.Visible = false;
                }
                textBox1.Text = exam.Questions[index].question ;
                textBox2.Text = exam.Questions[index].Answers[0].Answer ;
                radioButton2.Checked = exam.Questions[index].Answers[0].RightAnswer;
                textBox3.Text = exam.Questions[index].Answers[1].Answer ;
                radioButton1.Checked = exam.Questions[index].Answers[1].RightAnswer;
                textBox4.Text = exam.Questions[index].Answers[2].Answer ;
                radioButton3.Checked = exam.Questions[index].Answers[2].RightAnswer;
                
                label5.Text = (index + 1).ToString();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
