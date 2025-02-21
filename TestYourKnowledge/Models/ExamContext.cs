using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Models
{
    public class ExamContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<ExamCategory> ExamCategories { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<UserAnswersHistory> UserAnswersHistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-O0QCD23\\SQLDEVELOPER;Database=Exams;TrustServerCertificate=true;trusted_connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>().HasOne(e => e.ExamCategory).WithMany(ec=>ec.Exams).HasForeignKey(e => e.examCategoryId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Exam>().HasOne(e => e.ExamAdmin).WithMany(u => u.Exams).HasForeignKey(e => e.CreatorId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Question>().HasOne(q=>q.Exam).WithMany(e=>e.Questions).HasForeignKey(e=>e.ExamId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Answers>().HasOne(a=>a.Question).WithMany(q=>q.Answers).HasForeignKey(a=>a.QuestionId).OnDelete(DeleteBehavior.NoAction);
            //modelBuilder.Entity<UserAnswersHistory>().HasMany(u => u.Exam).WithMany(e => e.Users);
            modelBuilder.Entity<UserAnswersHistory>().HasOne(u => u.UserOfExam).WithMany(u=>u.UserHistory).HasForeignKey(u=>u.UserOfExamId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
