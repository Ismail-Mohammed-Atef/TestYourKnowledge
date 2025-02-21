using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Models
{
    public class UserAnswersHistory
    {
        public int Id { get; set; }
        public int RightAnswers { get; set; }
        public int WrongAnswers { get; set; }
        public double Percentage { get; set; }
        public int UserOfExamId { get; set; }
        public Users UserOfExam { get; set; }
        //public List<Exam> Exam { get; set; }
    }
}
