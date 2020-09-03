using System;
using System.Collections.Generic;

namespace ConsoleApp1.Data.Model
{
    public class Blog : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Blog(string name)
        {
            Name = name;
        }
    }
}
