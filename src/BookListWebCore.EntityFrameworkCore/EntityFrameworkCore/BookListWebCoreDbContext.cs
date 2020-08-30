using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BookListWebCore.Authorization.Roles;
using BookListWebCore.Authorization.Users;
using BookListWebCore.MultiTenancy;

namespace BookListWebCore.EntityFrameworkCore
{
    public class BookListWebCoreDbContext : AbpZeroDbContext<Tenant, Role, User, BookListWebCoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BookListWebCoreDbContext(DbContextOptions<BookListWebCoreDbContext> options)
            : base(options)
        {
        }
    }
}
