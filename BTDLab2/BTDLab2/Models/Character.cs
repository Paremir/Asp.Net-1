using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTDLab2.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int PlaceId { get; set; }
        public virtual Place Place { get; set; }

        public int? WordId { get; set; }
        public virtual Word Word { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

    }
}