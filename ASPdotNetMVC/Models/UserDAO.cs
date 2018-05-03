using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPdotNetMVC.Models
{
    public class UserDAO
    {
        public WFEntities db = null;
        public UserDAO()
        {
            db = new WFEntities();
        }

        public List<USER> getAllUsers()
        {
            return db.USERS.OrderBy(x => x.ID).ToList();
        }

        public USER getUserById(int Id)
        {
            return db.USERS.Find(Id);
        }

        public void handleInsert(USER a)
        {
            try
            {
                db.USERS.Add(a);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: \n" + e);
            }
        }

        public void handleDelete(int Id)
        {
            var rmObj = db.USERS.SingleOrDefault(x => x.ID == Id);
            try
            {
                db.USERS.Remove(rmObj);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:\n" + e);
            }
        }

        public void handleUpdate(USER entity)
        {
            try
            {
                var udObj = db.USERS.SingleOrDefault(x => x.ID == entity.ID);
                udObj.NAME = entity.NAME;
                udObj.PASSWORD = entity.PASSWORD;
                udObj.PHONE = entity.PHONE;
                udObj.ADDRESS = entity.ADDRESS;
                udObj.CODE = entity.CODE;
                udObj.EMAIL = entity.EMAIL;
                udObj.AVATAR = entity.AVATAR != null ? entity.AVATAR : udObj.AVATAR;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("======\n\n" + e);
            }
        }

        public USER handleLogin(string u, string p)
        {
            var user = db.USERS.FirstOrDefault(x => x.USERNAME == u && x.PASSWORD == p);
            return user;
        }
    }
}