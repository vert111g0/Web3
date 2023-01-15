using KahootInfrastructure.Data.Mapping;
using KahootInfrastructure.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootInfrastructure.Data
{
    public class KahootContext : DbContext
    {
        public DbSet<KahootContracts.DTO.Quiz> Quizes { get; set; }
        public DbSet<KahootContracts.DTO.User> Users { get; set; }
        public DbSet<KahootContracts.DTO.Role> Roles { get; set; }
        public DbSet<KahootContracts.DTO.Answer> Answers { get; set; }
        public DbSet<KahootContracts.DTO.Question> Questions { get; set; }
        public DbSet<KahootContracts.DTO.Topic> Topics { get; set; }
        public DbSet<KahootContracts.DTO.UserCorrect> userCorrect{ get; set; }

        public KahootContext(DbContextOptions<KahootContext> options) : base(options)
        {

        }

        // public KahootContext() { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPR;Initial Catalog=Kahoot;Integrated Security=True; TrustServerCertificate=True");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AnswerConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new QuizConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new TopicConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserCorrectConfiguration());

        }
    }

    
}
