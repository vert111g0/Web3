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
    public class UserCorrectConfiguration : IEntityTypeConfiguration<UserCorrect>
    {
        public void Configure(EntityTypeBuilder<UserCorrect> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Question);
            builder.HasOne(x => x.Answer);
            builder.HasOne(x => x.User);
            builder.ToTable("Users_With_Correct_Answers");            
        }
    }
}
