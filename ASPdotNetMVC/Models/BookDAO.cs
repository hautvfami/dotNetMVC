using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPdotNetMVC.Models
{
    public class BookDAO
    {
        public WFEntities db = null;
        public BookDAO()
        {
            db = new WFEntities();
        }

        public List<BOOK> getAllBooks()
        {
            return db.BOOKS.OrderBy(x => x.ID).ToList();
        }
        public BOOK getBookById(int Id)
        {
            return db.BOOKS.Find(Id);
        }

        public void handleInsert(BOOK entity)
        {
            try
            {
                db.BOOKS.Add(entity);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: \n" + e);
            }
        }

        public void handleDelete(int Id)
        {
            var rmObj = db.BOOKS.SingleOrDefault(x => x.ID == Id);
            try
            {
                db.BOOKS.Remove(rmObj);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:\n" + e);
            }
        }

        public void handleUpdate(BOOK entity)
        {
            var udObj = db.BOOKS.SingleOrDefault(x => x.ID == entity.ID);
            udObj.IN_LIB = entity.IN_LIB;
            udObj.OUT_LIB = entity.OUT_LIB;
            udObj.NAME = entity.NAME;
            udObj.PUBLISHER = entity.PUBLISHER;
            udObj.AUTHOR = entity.AUTHOR;
            udObj.CONTENT = entity.CONTENT;
            udObj.COST = entity.COST;
            udObj.COVER = entity.COVER != null ? entity.COVER : udObj.COVER;
            db.SaveChanges();
        }
    }
}