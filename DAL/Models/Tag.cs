using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Tag
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public List<Article> Articles { get; set; }
    }
}
