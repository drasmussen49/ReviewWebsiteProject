using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewWebsiteProject.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }

        public virtual Product Product { get; set; }
        public virtual int ProductId { get; set; }
    }
}
