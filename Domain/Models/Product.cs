using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        static int id_no = 0;

        public Product()
        {
            id_no++;
            Id = id_no;
        }
    }
}
