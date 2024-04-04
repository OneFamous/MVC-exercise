using exercise.Models;
using System.Linq;
using System.Web.Mvc;
using exercise.ViewModels;

namespace exercise.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Customer/List
        public ActionResult List()
        {
            var customers = db.Customers.Include("MembershipType").ToList();
            //var customers = db.Customers.ToList();
            var headers = new Headers() { Name = "Customers" };

            var viewModel = new CustomersViewModel
            {
                header = headers,
                customers = customers
            };

            return View(viewModel);
        }

        // GET: Customer/Details/{id}
        public ActionResult Details(int id)
        {
            var customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            var genre = db.Customers.Include("MembershipType").ToList();
            return View(customer);
        }

        public ActionResult New() 
        {
            var membershipTypes = db.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes

            };

        
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)    
        {
            db.Customers.Add(customer);
            db.SaveChanges();

            return RedirectToAction("List");
        }
    }
}
