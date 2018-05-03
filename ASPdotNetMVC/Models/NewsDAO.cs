using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPdotNetMVC.Models
{
    public class NewsDAO
    {
        public WFEntities db = null;
        public NewsDAO()
        {
            db = new WFEntities();
        }

        public List<NEWS> getAllNews()
        {
            return db.NEWS.OrderByDescending(x => x.TIME).ToList();
        }

        public void insertNews(NEWS entity)
        {
            entity.TIME = DateTime.Now;
            db.NEWS.Add(entity);
            db.SaveChanges();
        }

        public void updateNews(NEWS entity)
        {
            var model = db.NEWS.Find(entity.ID);
            model.TITLE = entity.TITLE;
            model.CONTENT = entity.CONTENT;
            db.SaveChanges();
        }

        public void deleteNews(int Id)
        {
            var model = db.NEWS.Find(Id);
            db.NEWS.Remove(model);
            db.SaveChanges();
        }

        public NEWS getById(int Id)
        {
            return db.NEWS.Find(Id);
        }
    }
}