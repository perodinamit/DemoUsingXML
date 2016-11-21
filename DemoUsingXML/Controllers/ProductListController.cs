using Demo.Helper;
using System.Linq;
using System.Web.Mvc;

namespace DemoUsingXML.Controllers
{
    public class ProductListController : Controller
    {
        // GET: ProductList  
        public ActionResult Index()
        {
            XMLReader readXML = new XMLReader();
            var data = readXML.RetrunListOfProducts();
            return View(data.ToList());
        }
    }
}