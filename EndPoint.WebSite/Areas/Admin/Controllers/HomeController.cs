using Microsoft.AspNetCore.Mvc;
using Shop2.Appliction.Servises.Users.Queries.GetUsers;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetUserServise _getUserServise;
        public HomeController(IGetUserServise getUserServise)
        {
            _getUserServise=getUserServise;
        }
        [Area("Admin")]
        public IActionResult Index(string Searchkey, int page = 1)
        {
            return View(_getUserServise.Execute(new RequestGetUserDto
            {
                Page = page,
                SearchKey = Searchkey 
            }));
        }

    }
}
