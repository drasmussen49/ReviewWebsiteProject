using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewWebsiteProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        public Product()
        {

        }

        public Product(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public Product(int id, string name, string description, string image)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
        }
    }
}
