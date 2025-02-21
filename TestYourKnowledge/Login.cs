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
    public partial class Login : Form
    {
        Users user;
        ExamContext context = new ExamContext();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = context.Users.Where(u => u.Name == textBox1.Text).FirstOrDefault();
            if (user is null)
            {
                MessageBox.Show("Username not found please register !", "UnAuthunticated");
                return;
            }
            else
            {
                if (user.Password != textBox2.Text)
                {
                    MessageBox.Show("Password is wrong please try again !!", "UnAuthunticated");
                    return;
                }
                if (user.Role == "User")
                {
                    UserChoosingExam userce = new UserChoosingExam(user);

                    userce.Show();
                    this.Hide();
                }
                else
                {
                    AdminPanel adminPanel = new AdminPanel(user);
                    adminPanel.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }
    }
}
