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
    public partial class Register : Form
    {
        ExamContext context = new ExamContext();
        public Register()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new List<string>() { "User", "Admin" };
            button1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users()
            {
                Name = textBox1.Text,
                Password = textBox2.Text,
                PhoneNumber = textBox3.Text,
                Role = comboBox1.Text,
            };
            var userr = context.Users.Where(u=>u.Name == textBox1.Text).FirstOrDefault();
            if (userr is null)
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("User already exists");
            }
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text = "This field cannot be empty";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void Buttonvalidation()
        {
            button1.Enabled = !string.IsNullOrEmpty(textBox1.Text) && int.TryParse(textBox2.Text, out _) && int.TryParse(textBox3.Text, out _);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out _))
            {
                label2.Text = "Please Enter Numbers";
            }
            else
            {
                label2.Text = "";

            }
            Buttonvalidation();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out _))
            {
                label3.Text = "Please Enter Numbers";
            }
            else
            {
                label3.Text = "";

            }
            Buttonvalidation();
        }
    }
}