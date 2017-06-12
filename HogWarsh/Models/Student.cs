using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HogWarsh.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Species Species { get; set; }
        public House House { get; set; }
    }

    public enum Species
    {
        Badger,
        Cat,
        Deer,
        Fox,
        Lizard,
        Mouse,
        Otter,
        Parrot,
        Rabbit,
        Skunk,
        Wolf
    }
}