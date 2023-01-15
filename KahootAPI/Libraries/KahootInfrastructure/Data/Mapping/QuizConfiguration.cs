using KahootInfrastructure.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace KahootInfrastructure.Data.Mapping
{
    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(t => t.Topic).WithMany(q => q.Quizes).HasForeignKey(x =>x.TopicId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(u => u.Users).WithOne(x => x.Quiz).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
