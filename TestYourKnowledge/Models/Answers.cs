using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Models
{
    public class Answers
    {
        public int Id { get; set; }
        public string Answer { get; set; }

        public int QuestionId { get; set; }
        public bool RightAnswer { get; set; }
        public Question Question { get; set; }
    }
}
