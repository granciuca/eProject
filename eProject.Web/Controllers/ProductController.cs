using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using eProject.BusinessLogic.Interfaces;
using eProject.Domain.Entities.Product;
using eProject.Web.Extensions;
using eProject.Web.Models;

namespace eProject.Web.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProduct _product;
        public ProductController()
        {
            var bl = new BusinessLogic.BusinessLogic();
            _product = bl.GetProductsBL();
        }

        // GET: Product
        public ActionResult Index()
        {
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            if (user == null)
            {
                return View();
            }

            List<string> ProductList = _product.GetProductsList();

            var product = new UserData
            {
                Username = user.Username,
                Products = ProductList
            };

            return View(product);
        }


        [HttpPost]
        public ActionResult Index(string btn)
        {
            return RedirectToAction("Product", "Product", new {p = btn});
        }

        public ActionResult NewProduct(ProductsData productModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProductsData, ProductsDatas>());
            var mapper = new Mapper(config);
            var prod = mapper.Map<ProductsDatas>(productModel);

            ProductsResp product = _product.SetProductsList(prod);

            if (product.Status)
            {
                ModelState.AddModelError("", product.StatusMsg);
                return RedirectToAction("Index", "Product");
            }

            ModelState.AddModelError("", product.StatusMsg);
            return View();
        }
    }
}