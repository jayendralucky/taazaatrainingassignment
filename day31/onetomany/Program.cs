using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace onetomany
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
    public class Publisher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<Publisher> Publisher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;User ID=postgres;Password=luckysingh@666;Database=onetomanydatabase;Pooling=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //well structured with fluent api

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired();
            });


            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.ISBN);
                entity.Property(e => e.Title).IsRequired();
                entity.HasOne(d => d.Publisher)
                .WithMany(p => p.Books);
            });
        }
    }
    public class Controller
    {
        public static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            publisher.Name = "rabindranath tagore";

            LibraryContext context = new LibraryContext();
            context.Add(publisher);
            context.SaveChanges();

            // context.Book.Add(new Book
            // {
            //     ISBN = "978-0544003415",
            //     Title = "The Lord of the Rings",
            //     Author = "J.R.R. Tolkien",
            //     Language = "English",
            //     Pages = 1216,
            //     Publisher = publisher
            // });
            // context.Book.Add(new Book
            // {
            //     ISBN = "978-0547247762",
            //     Title = "The Sealed Letter",
            //     Author = "Emma Donoghue",
            //     Language = "English",
            //     Pages = 416,
            //     Publisher = publisher
            // });

            // Saves changes
            context.SaveChanges();
            var books = context.Book.Include(p => p.Publisher);
            foreach (var book in books)
            {
                Console.WriteLine(book.ISBN + " " + book.Title + " " + book.Publisher.ID + " " + book.Publisher.Name);
            }
        }
    }
}
