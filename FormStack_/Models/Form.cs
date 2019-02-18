using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormStack_.Models
{
    public class Form
    {
        public int FormId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}