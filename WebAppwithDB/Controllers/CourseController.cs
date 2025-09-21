using Microsoft.AspNetCore.Mvc;
using WebAppwithDB.Models;
using WebAppwithDB.Services;

namespace WebAppwithDB.Controllers
{
    public class CourseController : Controller
    {
        private readonly CourseService _course_service;
        private readonly IConfiguration _configuration;
        public CourseController(CourseService _svc, IConfiguration configuration)
        {
            _course_service = _svc;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            IEnumerable<Course> _course_list = _course_service.GetCourses(_configuration.GetConnectionString("SQLConnection"));
            return View(_course_list);
        }
    }
}
