using eProject.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProject.BusinessLogic.Interfaces
{
    public interface IProduct
    {
        List<string> GetProductsList();
        ProductsResp SetProductsList(ProductsDatas prod);
    }
}
