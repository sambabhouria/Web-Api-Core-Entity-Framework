using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api_Core_Entity_Framework.Context;
using Web_Api_Core_Entity_Framework.Models;

namespace Web_Api_Core_Entity_Framework.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {

        private CompanyContext _companyContext;

        public EmployeeController(CompanyContext companyContext)
        {
            _companyContext = companyContext;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _companyContext.Employees;
        }


        // GET: EmployeeController
        // public ActionResult Index()
        // {
        //     return View();
        // }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _companyContext.Employees.FirstOrDefault(s => s.EmployeeId == id);
        }

        // GET: EmployeeController/Details/5
        //  public ActionResult Details(int id)
        //  {
        //    return View();
        //  }


        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee value)
        {
            _companyContext.Employees.Add(value);
            _companyContext.SaveChanges();
        }

        // GET: EmployeeController/Create
        // public ActionResult Create()
        // {
        //     return View();
        //  }

        // POST: EmployeeController/Create
        // [HttpPost]
        //  [ValidateAntiForgeryToken]
        //  public ActionResult Create(IFormCollection collection)
        //  {
        //      try
        //      {
        //          return RedirectToAction(nameof(Index));
        //      }
        //     catch
        //     {
        //          return View();
        //     }
        //  }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee value)
        {
            var employee = _companyContext.Employees.FirstOrDefault(s => s.EmployeeId == id);
            if (employee != null)
            {
                _companyContext.Entry<Employee>(employee).CurrentValues.SetValues(value);
                _companyContext.SaveChanges();
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var student = _companyContext.Employees.FirstOrDefault(s => s.EmployeeId == id);
            if (student != null)
            {
                _companyContext.Employees.Remove(student);
                _companyContext.SaveChanges();
            }
        }

        // GET: EmployeeController/Edit/5
      //  public ActionResult Edit(int id)
      //  {
      //      return View();
      //  }




        // POST: EmployeeController/Edit/5
      //  [HttpPost]
      //  [ValidateAntiForgeryToken]
      //  public ActionResult Edit(int id, IFormCollection collection)
      //  {
        //    try
         //   {
        //        return RedirectToAction(nameof(Index));
       //     }
        //    catch
       //     {
      //          return View();
            }
     //   }

        // GET: EmployeeController/Delete/5
       // public ActionResult Delete(int id)
      //  {
       //     return View();
      //  }

        // POST: EmployeeController/Delete/5
     //   [HttpPost]
    //    [ValidateAntiForgeryToken]
     //   public ActionResult Delete(int id, IFormCollection collection)
     //   {
     //       try
     //       {
     //           return RedirectToAction(nameof(Index));
     //       }
     //       catch
     //       {
      //          return View();
      //      }
      //  }
   // }
}
