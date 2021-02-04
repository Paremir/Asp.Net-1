using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTDLab2.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public ICollection<Character> Characters { get; set; }
        public Place()
        {
            Characters = new List<Character>();
        }
    }
}