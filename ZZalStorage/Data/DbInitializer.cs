using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZZalStorage.Models;

namespace ZZalStorage.Data
{
    public class DbInitializer
    {
        public static void Initialize(ImagesContext context)
        {
            context.Database.EnsureCreated();

            if (context.Images.Any()) return;

            var tags = new Tag[]
            {
                new Tag{ID=1,Cata=Cata.emotion,Name="LoL"},
                new Tag{ID=2,Cata=Cata.gif,Name="BlackBox"}
            };
            foreach(Tag t in tags)
            {
                context.Tags.Add(t);
            }
            context.SaveChanges();

            var images = new Image[]
            {
                new Image{FileName="test1",AddDate=DateTime.Parse("2017-01-01")},
                new Image{FileName="test2",AddDate=DateTime.Parse("2017-01-02")}
            };
            foreach(Image i in images)
            {
                context.Images.Add(i);
            }
            context.SaveChanges();
        }
    }
}
