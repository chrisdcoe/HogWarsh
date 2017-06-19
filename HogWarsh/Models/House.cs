using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HogWarsh.Models
{
    public class House
    {
        public int Id { get; set; }
        public Name Name { get; set; }
        public string Description { get; set; }
    }

    public enum Name
    {
        Griffinwindow,
        Slitherout,
        Pufflestuff,
        Crowbeak
    }
}