using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string question { get; set; }

        public int ExamId { get; set; }

        public Exam Exam { get; set; }

        public List<Answers> Answers { get; set; }
    }
}
