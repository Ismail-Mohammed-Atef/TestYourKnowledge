using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int examCategoryId { get; set; }
        public int CreatorId { get; set; }
        public Users? ExamAdmin { get; set; }
        public ExamCategory? ExamCategory { get; set; }
        public List<Question> Questions { get; set; }
        //public List<UserAnswersHistory> Users { get; set; }
    }
}
