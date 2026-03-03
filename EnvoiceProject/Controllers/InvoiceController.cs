using Microsoft.AspNetCore.Mvc;
using EnvoiceProject.Models;

namespace EnvoiceProject.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCompany()
        {
            var company = new CompanyDTO
            {
                name = "ABC Company",
                phone = "123-456-7890",
                email = "info@abccompany.com",
                location = "123 Main St, City, Country"
            };
            return Json(company);
        }
        public IActionResult GetCustomer()
        {
            var customer = new List<CustomerDTO>()
            {
               new  CustomerDTO {  id = 1,
                name = "Gebeyehu Tilahun",
                phone = "+2519260000",
                address = "King George IV, Addis Ababa, Ethiopia",
                tinNo="0000000000000-01"
                },
                new  CustomerDTO {  id = 2,
                name = "Ayida Simon",
                phone = "+119250000",
                address = "Fifth Avenue, ny, USA",
                tinNo="0000000000000-01"
                },  
                new  CustomerDTO {  id = 3,
                name = "Abraham Lincon",
                phone = "+519250000",
                address = "Ave Maria Lane, london, USA",
                tinNo="0000000000000-02"
                },
                   new  CustomerDTO {  id = 4,
                name = "Chala Gemechu",
                phone = "+2519240000",
                address = "Russia St, Addis ababa, ethiopia",
                tinNo="0000000000000-02"
                },

            };
            return Json(customer);
        }
        public IActionResult GetItems()
        {
            var items = new List<ItemDTO>() {
                new ItemDTO { sn = 1, id = 1, code = "IT-01", name = "Large Toilet paper", price = 105 },
                new ItemDTO { sn = 2, id = 2, code = "IT-02", name = "PLASTIC GLOVES", price = 25 } ,
                new ItemDTO { sn = 3, id = 3, code = "IT-03", name = "Dril Machine", price = 1225 } ,
                new ItemDTO { sn = 4, id = 4, code = "IT-04", name = "PIPE VICE", price = 2225 },
                new ItemDTO { sn = 4, id = 4, code = "IT-04", name = "PHOTOCOPY MACHINE", price = 26225 }
            };
            return Json(items);
        }
    }
}
