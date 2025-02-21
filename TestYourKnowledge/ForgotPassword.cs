using Microsoft.IdentityModel.Tokens;
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
    public partial class ForgotPassword : Form
    {
        ExamContext context = new ExamContext();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var user = context.Users.Where(u => u.Name == textBox1.Text).FirstOrDefault();
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text = "This field cannot be empty !";
            }
           
            buttonValidate();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out _))
            {
                label2.Text = "Please enter numbers !";
            }
            if (textBox2.Text.IsNullOrEmpty())
            {
                label2.Text = "This field Cannot be empty !";
            }
            buttonValidate();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text = "This field cannot be empty !";
            }
            buttonValidate();
        }
        private void buttonValidate()
        {
            button1.Enabled = !string.IsNullOrEmpty(textBox1.Text) && int.TryParse(textBox2.Text, out _) && !string.IsNullOrEmpty(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = context.Users.Where(u => u.Name == textBox1.Text).FirstOrDefault();
            if (user is null)
            {
                MessageBox.Show("No User with current username !");
            }
            else
            {
                if (user.PhoneNumber == textBox2.Text)
                {
                    user.Password = textBox3.Text;
                    context.Users.Update(user);
                    context.SaveChanges();
                    MessageBox.Show("Password changed correctly !");
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong phone number ! ");
                }
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
