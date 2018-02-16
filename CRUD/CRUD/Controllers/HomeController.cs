using CRUD.Models;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class HomeController : Controller
    {
        private ProjectContext dao = new ProjectContext();
        private Candidate Candidates = new Candidate();

        public JsonResult GetAllUsers()
        {
            List<Candidate> list = dao.candidates.ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SaveArray(Candidate Candidates)
        {
            var equalEmail = "";
            List<Candidate> list = dao.candidates.ToList();
            if (Candidates != null)
            {
                var testes = dao.candidates.FirstOrDefault(u => u.Email == Candidates.Email);
                if (testes == null)
                {
                    dao.candidates.Add(Candidates);
                    dao.SaveChanges();
                }
                else
                {
                    equalEmail = "email in use";
                }
            }
            else
            {
                Response.StatusCode = 400;
            }
            if (equalEmail != "email in use")
            {
                List<Candidate> ListPlus = dao.candidates.ToList();
                return Json(ListPlus, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(equalEmail, JsonRequestBehavior.AllowGet);
            }
        }
      
        public JsonResult Delete(int Id)
        {
            Candidates = dao.candidates.FirstOrDefault(c => c.ID == Id);
            if (Candidates != null)
            {
                Candidates.ID = Id;
                dao.candidates.Remove(Candidates);
                dao.SaveChanges();
            }
            else
            {
                Response.StatusCode = 400;
            }
            return Json("Response from Delete");
        }
        
        public JsonResult Update(Candidate Cand)
        {
            if (Cand != null)
            {
                dao.candidates.Attach(Cand);
                dao.Entry(Cand).State = EntityState.Modified;
                dao.SaveChanges();
            }
            else
            {
                Response.StatusCode = 400;
            }
            List<Candidate> ListPlus = dao.candidates.ToList();
            return Json(ListPlus, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetUsersById(int ID)
        {
            Candidates = dao.candidates.FirstOrDefault(c => c.ID == ID);
            return Json(Candidates, JsonRequestBehavior.AllowGet);
        }
    }
}