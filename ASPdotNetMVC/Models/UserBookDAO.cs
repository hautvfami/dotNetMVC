using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPdotNetMVC.Models
{
    public class UserBookDAO
    {
        public WFEntities db = null;
        public UserBookDAO()
        {
            db = new WFEntities();
        }

        public List<USER_BOOK> getAllUserBook()
        {
            return db.USER_BOOK.OrderByDescending(x => x.BORROW_DATE).ToList();
        }
        public USER_BOOK getUserBookById(int Id)
        {
            return db.USER_BOOK.Find(Id);
        }

        public void handleInsert(USER_BOOK a)
        {
            try
            {
                db.USER_BOOK.Add(a);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: \n" + e);
            }
        }

        public void handleDelete(int Id)
        {
            var rmObj = db.USER_BOOK.SingleOrDefault(x => x.BOOKID == Id);
            try
            {
                db.USER_BOOK.Remove(rmObj);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:\n" + e);
            }
        }

        public void handleUpdate(USER_BOOK a)
        {
            var udObj = db.USER_BOOK.SingleOrDefault(x => x.BOOKID == a.BOOKID);
            udObj = a;
            db.SaveChanges();
        }
    }
}