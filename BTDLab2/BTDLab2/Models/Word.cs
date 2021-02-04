using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTDLab2.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiseaseId { get; set; }
        public virtual Disease Disease { get; set; }
    }
}