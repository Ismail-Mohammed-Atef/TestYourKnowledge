using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Models
{
    public class ExamCategory
    {
        public int Id { get; set; }
        public string Category { get; set; }

        public List<Exam> Exams { get; set; }

    }
}
