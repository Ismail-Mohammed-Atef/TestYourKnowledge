using Microsoft.EntityFrameworkCore;
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
    public partial class UserChoosingExam : Form
    {
        ExamContext context = new ExamContext();
        private readonly Users user;

        public UserChoosingExam(Users user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UserChoosingExam_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = context.ExamCategories.ToList();
            comboBox1.DisplayMember = "Category";
            comboBox1.ValueMember = "Id";
            comboBox2.DataSource = context.Exams.Where(e => e.examCategoryId == (int)comboBox1.SelectedValue).ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            dataGridView1.DataSource = context.UserAnswersHistory.Where(u => u.UserOfExamId == user.Id).Select(uh => new { uh.UserOfExam.Name, uh.Percentage, uh.RightAnswers, uh.WrongAnswers }).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var exam = context.Exams.Where(e => e.Id == (int)comboBox2.SelectedValue).Include(e => e.Questions).ThenInclude(q => q.Answers).FirstOrDefault();
            UserPanel p = new UserPanel(exam, user);
            if (p.ShowDialog() == DialogResult.OK)
            {
                var data = p.UserAnswers;
                UserAnswersHistory userAnswersHistory = new UserAnswersHistory();

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        if (exam.Questions[i].Answers[j].RightAnswer == true)
                        {
                            if ((j + 1) == data[i])
                            {
                                userAnswersHistory.RightAnswers++;
                            }
                            else
                            {
                                userAnswersHistory.WrongAnswers++;
                            }
                        }
                    }
                }
                userAnswersHistory.Percentage = ((userAnswersHistory.RightAnswers / 5.0) * 100);
                userAnswersHistory.UserOfExamId = user.Id;
                MessageBox.Show("Congratulations You got " + userAnswersHistory.Percentage + "%");

                context.UserAnswersHistory.Add(userAnswersHistory);
                context.SaveChanges();
                dataGridView1.DataSource = context.UserAnswersHistory.Where(u => u.UserOfExamId == user.Id).Select(uh => new { uh.UserOfExam.Name, uh.Percentage, uh.RightAnswers, uh.WrongAnswers }).ToList();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                comboBox2.Text = "";
                comboBox2.DataSource = context.Exams.Where(e => e.examCategoryId == (int)comboBox1.SelectedValue).ToList();
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
