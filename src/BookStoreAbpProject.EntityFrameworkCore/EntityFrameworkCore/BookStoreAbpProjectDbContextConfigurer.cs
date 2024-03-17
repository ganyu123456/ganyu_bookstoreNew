using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAbpProject.EntityFrameworkCore
{
    public static class BookStoreAbpProjectDbContextConfigurer
    {
        const string MySqlVersion = "5.7";
        public static void Configure(DbContextOptionsBuilder<BookStoreAbpProjectDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString,ServerVersion.Parse(MySqlVersion));
        }

        public static void Configure(DbContextOptionsBuilder<BookStoreAbpProjectDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection, ServerVersion.Parse(MySqlVersion));
        }
    }
}
