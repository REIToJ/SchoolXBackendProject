using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using SchoolXAPI.Models.Image;
using SchoolXAPI.Models.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SchoolXAPI.Authentication;

namespace SchoolXAPI.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<UserItem> User { get; set; }
        public DbSet<Image> Image { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            for (int i = 1; i <=10; i++)
            {
                 using (WebClient client = new WebClient())
                 {
                     client.DownloadFile(new Uri(new Bogus.DataSets.Images().PlaceImgUrl()), @$"c:\temp\image{i}.png");

                 }
                modelBuilder.Entity<UserItem>().HasData(
                    new UserItem
                    {

                        Id = i,
                        Name = new Bogus.DataSets.Name().FullName(),
                        DateCreate = new Bogus.DataSets.Date().Past(),
                        Email = new Bogus.DataSets.Internet().Email(),
                        Phone = new Bogus.Randomizer().Number(100000, 999999).ToString(),
                        Password = new Bogus.DataSets.Internet().Password(),

                    });
                modelBuilder.Entity<Image>().HasData(
                new Image
                {
                    Id = i,
                    Name = new Bogus.DataSets.Internet().Password(),
                    Path = @$"c:\temp\image{i}.png",
                    Size = SixLabors.ImageSharp.Image.Load(@$"c:\temp\image{i}.png").Width + "x" + SixLabors.ImageSharp.Image.Load(@$"c:\temp\image{i}.png").Height,
                    DateCreate = new Bogus.DataSets.Date().Past(),
                }
                );
             
            }
           // modelBuilder.Entity<UserItem>(e => e.Property(o => o.Age).HasColumnType("tinyint(1)").HasConversion<short>());
            //modelBuilder.Entity<UserItem>(e => e.Property(o => 0.IsPlayer).HasColumnType("bit"));
        }

     
    }
}
