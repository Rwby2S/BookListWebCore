using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BookListWebCore.EntityFrameworkCore
{
    public static class BookListWebCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BookListWebCoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BookListWebCoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
