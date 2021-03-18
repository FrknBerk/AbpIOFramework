using Acme.StudentStore.Students;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.StudentStore.EntityFrameworkCore
{
    public static class StudentStoreDbContextModelCreatingExtensions
    {
        public static void ConfigureStudentStore(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */
            builder.Entity<Student>(b =>
            {
                b.ToTable(StudentStoreConsts.DbTablePrefix + "Students", StudentStoreConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.FirstName).IsRequired();
                b.Property(x => x.LastName).IsRequired();
                b.Property(x => x.Phone).IsRequired();
            });

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(StudentStoreConsts.DbTablePrefix + "YourEntities", StudentStoreConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}