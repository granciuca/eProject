using eProject.BusinessLogic.Core;
using eProject.BusinessLogic.Interfaces;
using eProject.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProject.BusinessLogic
{
    public class ProductsBL : UserApi, IProduct
    {
        public List<string> GetProductsList()
        {
            return ProductListLogic();
        }

        public ProductsResp SetProductsList(ProductsDatas prod)
        {
            return AddProducts(prod);
        }
    }
}
