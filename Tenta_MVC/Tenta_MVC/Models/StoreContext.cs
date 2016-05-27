using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Tenta_MVC_Adriana.Models;

namespace Tenta_MVC.Models
{
    public class StoreContext:DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

        public StoreContext():base("StoreDataBase")
        {
            Database.SetInitializer(new StoreInitializer());
        }

        public class StoreInitializer:DropCreateDatabaseAlways<StoreContext>
        {
            protected override void Seed(StoreContext context)
            {
                var stores = new List<Store>()
                {
                    new Store()
                    {
                        StoreId = 1,
                        Name = "Store1",
                        Address = "5th Avenue 1",
                        Products = new List<Product>()
                        {
                            new Product() {ProductId = 1, Name = "Prod1", ProductText = "Something fantastic...", ProductNumber = "p-111", Price =30.55, ProductsInStock = 10},
                            new Product() {ProductId = 2, Name = "Prod2", ProductText = "Something more fantastic...", ProductNumber = "p-222", Price = 50.85, ProductsInStock = 12}
                        }

                    },
                    new Store()
                    {
                        StoreId = 2,
                        Name = "Store2",
                        Address = "Kensington Str. 10",
                        Products = new List<Product>()
                        {
                            new Product() {ProductId = 3, Name = "Prod3", ProductText = "Your new best friend", ProductNumber = "p-33333", Price =12.40, ProductsInStock = 20},
                            new Product() {ProductId = 4, Name = "Prod4", ProductText = "Your new best gadget", ProductNumber = "p-44444", Price = 7.74, ProductsInStock = 30}
                        }

                    }
                };
                context.Stores.AddRange(stores);
                context.SaveChanges();
            }
        }
    }

    
}