using KahootInfrastructure.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootInfrastructure.Data.Mapping
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(q => q.Quiz).WithMany(q => q.Questions).HasForeignKey(x => x.QuizId).OnDelete(DeleteBehavior.NoAction);
            
        }
    }
}
