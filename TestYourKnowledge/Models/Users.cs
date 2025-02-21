using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
        public List<UserAnswersHistory> UserHistory { get; set; }
        public List<Exam> Exams { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
