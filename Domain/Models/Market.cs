using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Market
    {
        public Product[] ProductList;

        public Market(int length)
        {
            ProductList = new Product[length];
        }

        #region` Get and set List  in a easy way
        public Product this[int productindex]
        {
            get { return ProductList[productindex]; }
            set { ProductList[productindex] = value; }
        }
        #endregion
    }
}
