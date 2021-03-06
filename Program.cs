﻿using ConsoleApp1.Data;
using ConsoleApp1.Data.Model;
using System;
using System.Linq;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();

                if (!context.Blogs.Any())
                {
                    context.Blogs.Add(new Blog("Blog A"));
                    context.Blogs.Add(new Blog("Blog B"));

                    context.SaveChanges();
                }
            }

            using (var context = new AppDbContext())
            {
                foreach( var blog in context.Blogs)
                {
                    Console.WriteLine((object) blog.Name);
                }
            }

            Console.ReadKey();
        }
    }
}
