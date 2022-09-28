using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobsController : Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<Opening> allJobs = Opening.GetJobs();
      return View(allJobs);
    }
    [HttpPost("/jobs")]
    public ActionResult Create(string title, string desc, string email, string phone)
    {
      Opening myJob = new Opening(title, desc, email, phone);
      return RedirectToAction("Index");
    }
    [HttpGet("/jobs/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/jobs/delete")]
    public ActionResult DeleteAll()
    {
      Opening.ClearJobs();
      return View();
    }
    [HttpGet("/jobs/{id}")]
    public ActionResult Show(int id)
    {
      Opening foundJob = Opening.Find(id);
      return View(foundJob);
    }
  }
}