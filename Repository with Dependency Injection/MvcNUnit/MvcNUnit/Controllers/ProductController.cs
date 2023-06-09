using MvcNUnit.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcNUnit.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            this._repository = repository;
        }

        // GET: Product
        public ActionResult Index()
        {
            var data = _repository.GetAll();
            return View(data);
        }
    }
}