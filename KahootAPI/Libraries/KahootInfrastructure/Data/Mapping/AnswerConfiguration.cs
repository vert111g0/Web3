using KahootInfrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace KahootInfrastructure.Data.Mapping
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(q => q.Question).WithMany(a => a.Answers).OnDelete(DeleteBehavior.NoAction) ;

        }
    }
}
