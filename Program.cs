using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                // CREATE
                // var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
                // context.Tags.Add(tag);


                // UPDATE
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 2);
                // tag.Name = ".NET";
                // tag.Slug = "dotnet";
                // context.Update(tag);


                // DELETE
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 2);
                // context.Remove(tag);

                // context.SaveChanges();


                // READ
                // var tags = context.Tags
                //     .AsNoTracking()
                //     .ToList();

                // foreach (var tag in tags)
                // {
                //     Console.WriteLine(tag.Name);
                // }

                var tag = context.Tags
                    .AsNoTracking()
                    .FirstOrDefault(x => x.Id == 1);

                Console.WriteLine(tag?.Name);
            }
        }
    }
}
