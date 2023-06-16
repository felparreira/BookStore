﻿using Volo.Abp.Data;
using Volo.Abp.MongoDB;
using Acme.BookStore.Books;
using MongoDB.Driver;
using Acme.BookStore.Authors;

namespace Acme.BookStore.MongoDB;

[ConnectionStringName("Default")]
public class BookStoreMongoDbContext : AbpMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */
        public IMongoCollection<Book> Books => Collection<Book>();
        //...
        public IMongoCollection<Author> Authors => Collection<Author>();

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        //modelBuilder.Entity<YourEntity>(b =>
        //{
        //    //...
        //});
    }
}
