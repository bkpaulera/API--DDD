using System;
using System.Collections.Generic;
using System.Text;

namespace Aps19.Infra.Data.Mapping
{

    public class UserMap : IEntityTypeConfiguration<User>

    {

        public void Configure(EntityTypeBuilder<Usuario> builder)

        {

            builder.ToTable("User");



            builder.HasKey(c => c.Id);



            builder.Property(c => c.Cpf)

                .IsRequired()

                .HasColumnName("Cpf");



            builder.Property(c => c.BirthDate)

                .IsRequired()

                .HasColumnName("BirthDate");



            builder.Property(c => c.Name)

                .IsRequired()

                .HasColumnName("Name");

        }

    }
}
