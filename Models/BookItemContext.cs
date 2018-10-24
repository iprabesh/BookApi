using Microsoft.EntityFrameworkCore;
namespace BookApi.Models{
    public class BookItemContext : DbContext{
        public BookItemContext(DbContextOptions<BookItemContext>options)
            : base(options){
            }
            public DbSet<BookItem>BookItems{get; set;}
    }
}
