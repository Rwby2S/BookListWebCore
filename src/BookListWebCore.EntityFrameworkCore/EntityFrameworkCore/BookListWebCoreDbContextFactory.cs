using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using BookListWebCore.Configuration;
using BookListWebCore.Web;

namespace BookListWebCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BookListWebCoreDbContextFactory : IDesignTimeDbContextFactory<BookListWebCoreDbContext>
    {
        public BookListWebCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BookListWebCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BookListWebCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BookListWebCoreConsts.ConnectionStringName));

            return new BookListWebCoreDbContext(builder.Options);
        }
    }
}
