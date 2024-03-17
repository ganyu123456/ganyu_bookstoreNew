using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BookStoreAbpProject.Authorization.Roles;
using BookStoreAbpProject.Authorization.Users;
using BookStoreAbpProject.MultiTenancy;
using BookStoreAbpProject.BookWeb;

namespace BookStoreAbpProject.EntityFrameworkCore
{
    public class BookStoreAbpProjectDbContext : AbpZeroDbContext<Tenant, Role, User, BookStoreAbpProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BookStoreAbpProjectDbContext(DbContextOptions<BookStoreAbpProjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<LoginUser> LoginUsers { get; set; }
    }
}
