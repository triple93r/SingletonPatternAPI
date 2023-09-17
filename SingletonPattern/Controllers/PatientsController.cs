using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SingletonPattern;
using SingletonPattern.Data;
using SingletonPattern.Models;
using System.Transactions;

namespace SingletonPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : Controller
    {
        private readonly ApplicationDBContext _context;
        public string v;
        public PatientsController(ApplicationDBContext db)
        {
            _context = db;
        }

        [HttpPost]
        public IActionResult PrintPatient()
        {
            pthread1.Start();
            pthread2.Start();
            pthread3.Start();

            pthread1.Join();
            pthread2.Join();
            pthread3.Join();

            return Ok("done");
        }

        Thread pthread1 = new Thread(() =>
        {
            var inst = PatientService.Instance(1);
        });

        Thread pthread2 = new Thread(() =>
        {
            var inst = PatientService.Instance(2);
        });

        Thread pthread3 = new Thread(() =>
        {
            var inst = PatientService.Instance(3);
        });

    }
}
