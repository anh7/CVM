using CRM.Business;
using CRM.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class UserController : Controller
    {
        UserBusiness userBiz = new UserBusiness();
        RoleBusiness roleBiz = new RoleBusiness();
        // GET: /User/
        public ActionResult Index()
        {
            var userlist = userBiz.GetAll();
            return View(userlist);
        }

        //
        // GET: /User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /User/Create
        public ActionResult Create()
        {
            ViewBag.RoleID = roleBiz.GetAll();
            return View();
        }
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(UserView user)
        {
            //if(ModelState.IsValid)
            //{
                var getuser = userBiz.GetAll().Where(model => model.Email == user.Email && model.Password == user.Password);
                if (getuser.Count() > 0)
                {
                    return RedirectToAction("Index");
                }
              
                    return View(user);
            
            //}
            //return View(user);
        }

        //
        // POST: /User/Create
        [HttpPost]
        public ActionResult Create(UserView user)
        {
            if(ModelState.IsValid)
            {
                CRM.Model.User userdata = new CRM.Model.User();
                userdata.Email = user.Email;
                userdata.FirstName = user.FirstName;
                userdata.LastName = user.LastName;
                userdata.Password = "123456";
                userdata.Status = false;
                userdata.RoleID = user.RoleID;
                userdata.DateCreate = DateTime.Now;
                userBiz.Create(userdata);
                return Redirect("/User/Index");
            }
            ViewBag.RoleID = roleBiz.GetAll(); /*new SelectList(roleBiz.GetAll(), "ID", "Name", user.RoleID);*/
            return View(user);
        }

        //
        // GET: /User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Profile(UserView user)
        {
            return View();
        }
    }
}
