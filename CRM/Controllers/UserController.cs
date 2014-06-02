using CRM.Business;
using CRM.Models;
using CRM.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using CRM.Common;

namespace CRM.Controllers
{
    public class UserController : Controller
    {
        UserBusiness userBiz = new UserBusiness();
        RoleBusiness roleBiz = new RoleBusiness();
        InterestingBusiness interBiz = new InterestingBusiness();
        ProvinceBusiness provinceBiz = new ProvinceBusiness();
        AddressBusiness addBiz = new AddressBusiness();
        User_InterestingBusiness userInterBiz = new User_InterestingBusiness();
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
                    Session["Id"] = getuser.First().ID;
                    return RedirectToAction("FirstLogin");
                    
                }
              
                    return View(user);
            
            //}
            //return View(user);
        }
        public ActionResult FirstLogin()
        {
            ViewBag.Interesting = interBiz.GetAll();
            ViewBag.Province = provinceBiz.GetAll();
            ViewBag.User = userBiz.Get(int.Parse(Session["Id"].ToString()));
            return View();
        }
        [HttpPost]
        public ActionResult FirstLogin(UserView useview,HttpPostedFileBase file)
        {
            if(ModelState.IsValid)
            {
                User user = new User();
                user = userBiz.Get(int.Parse(Session["Id"].ToString()));
                user.Gender = useview.Gender;
                user.FirstName = useview.FirstName;
                user.LastName = useview.LastName;
                
                user.Phone = useview.Phone;
                user.ImagieProfile = user.ID + ".jpg";




                Address add = new Address();
                add.ProvinceID = useview.ProvinceID;
                add.Street = useview.Street;
                add.ID=user.ID;
                if(addBiz.GetId(user.ID)!=null)
                {
                    Address ad = addBiz.GetId(user.ID);
                    ad.ProvinceID = useview.ProvinceID;
                    ad.Street = useview.Street;
                    addBiz.Update(ad);
                }
                else 
                {
                    addBiz.Create(add);
                }

                IEnumerable<User_Interesting> User_Inter = userInterBiz.GetAll().Where(model => model.UserID == user.ID);
                if (User_Inter.Count() > 0)
                {
                  foreach (var item in User_Inter)
                  {
                       userInterBiz.Remove(item);
                   }
                }
                List<User_Interesting> uiList = new List<User_Interesting>();
                if (useview.InterestingID.Count() > 0)
                {
                    foreach (var id in useview.InterestingID)
                   {
                       userInterBiz.Create(new User_Interesting {InterestingID=id,UserID=user.ID });
                    }
               
                }


               ///Upload-file
                if (file.ContentLength > 0)
                {
                    var fileName = user.ID + ".jpg";
                    var path = Path.Combine(Server.MapPath("~/Document/Profile"), fileName);
                    file.SaveAs(path);
                }



                userBiz.Update(user);

                return Redirect("/Profile/Index/"+user.ID);
            }
            return View();
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
                userdata.Password = /*FormatString.RandomString(8);*/"123456";
                userdata.Status = true;
                userdata.RoleID = user.RoleID;
                userdata.DateCreate = DateTime.Now;
                userBiz.Create(userdata);
                return Redirect("/User/Index");
            }
            ViewBag.RoleID = roleBiz.GetAll(); /*new SelectList(roleBiz.GetAll(), "ID", "Name", user.RoleID);*/
            return View(user);
        }
        [HttpPost]
        public ActionResult UpdateStatus()
        {
            
            string id = Request.Params["ID"];
            string stt = Request.Params["Status"];

            User user = new User();
            user = userBiz.Get(int.Parse(id));
            if (stt == "De")
            { user.Status = false; }
            else
            {
                user.Status = true;
            }
            userBiz.Update(user);
            return Content(user.ID.ToString());
        }

        //
        // GET: /User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /User/Edit/5
      

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
