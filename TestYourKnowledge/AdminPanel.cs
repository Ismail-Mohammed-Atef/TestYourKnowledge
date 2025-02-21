using Microsoft.EntityFrameworkCore;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestYourKnowledge
{
    public partial class AdminPanel : Form
    {
        ExamContext context = new ExamContext();
        private readonly Users user;

        public AdminPanel(Users User)
        {
            InitializeComponent();
            user = User;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

            comboBox2.DataSource = context.Exams.Where(e => e.CreatorId == user.Id).ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            comboBox1.DataSource = context.ExamCategories.ToList();
            comboBox1.DisplayMember = "Category";
            comboBox1.ValueMember = "Id";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var examCategory = new ExamCategory()
            {
                Category = textBox1.Text,
            };
            var category = context.ExamCategories.Where(c => c.Category == textBox1.Text).FirstOrDefault();
            if (category is null)
            {
                context.ExamCategories.Add(examCategory);
                context.SaveChanges();
                comboBox1.DataSource = context.ExamCategories.ToList();
                comboBox1.DisplayMember = "Category";
                comboBox1.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Category already exist");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CreateExam ex = new CreateExam();
            var exam = context.Exams.Where(e=>e.Name == textBox2.Text).FirstOrDefault();
            if (exam is null)
            {
                if (ex.ShowDialog() == DialogResult.OK)
                {
                    var data = ex.Questions;
                    MessageBox.Show("Exam " + ex.Name + " Created !");

                    Exam examm = new Exam()
                    {
                        Name = textBox2.Text,
                        Questions = data.ToList(),
                        CreatorId = user.Id,
                        examCategoryId = (int)comboBox1.SelectedValue,


                    };
                    context.Exams.Add(examm);
                    context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Exam name already exist !");
            }
            comboBox2.DataSource = context.Exams.Where(e => e.CreatorId == user.Id).ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ex = context.Exams.Where(e => e.Id == (int)comboBox2.SelectedValue).Include(e => e.Questions).ThenInclude(q => q.Answers).FirstOrDefault();
            CreateExam createExam = new CreateExam(ex);
            if (createExam.ShowDialog() == DialogResult.OK)
            {
                var data = ex.Questions;

                Exam exam = new Exam()
                {
                    Name = textBox2.Text,
                    Questions = data.ToList(),
                    CreatorId = user.Id,
                    examCategoryId = (int)comboBox1.SelectedValue,


                };
                var exm = context.Exams.Where(e => e.Id == (int)comboBox2.SelectedValue).FirstOrDefault();
                exm = exam;
                context.Exams.Update(exm);
                context.SaveChanges();
                MessageBox.Show("Exam " + ex.Name + " Updated !");
            }
            comboBox2.DataSource = context.Exams.Where(e => e.CreatorId == user.Id).ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var exam = context.Exams.Where(e => e.Id == (int)comboBox2.SelectedValue).FirstOrDefault();
            if (exam != null)
            {
                context.Exams.Remove(exam);
                context.SaveChanges();
                MessageBox.Show("Exam deleted successfully");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
