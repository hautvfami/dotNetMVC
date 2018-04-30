using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPdotNetMVC.Models
{
    public class CustomMenu{
        public CustomMenu(){
            sub_menu = new List<SUB_MENU>();
        }
        public MENU menu;
        public List<SUB_MENU> sub_menu;
    }

    public class MenuDAO
    {
        public WFEntities db = null;
        List<CustomMenu> listCustomMenu = new List<CustomMenu>();
        public MenuDAO()
        {
            db = new WFEntities();
        }

        public List<CustomMenu> getMenu(int CODE)
        {
            List<MENU> listMenu = db.MENUs.Where(x=>x.CODE >= CODE).OrderBy(x => x.NO).ToList();
            foreach(MENU MenuItem in listMenu){
                CustomMenu customMenu = new CustomMenu();
                customMenu.menu = MenuItem;
                if (MenuItem.LINK == null)
                {
                    customMenu.sub_menu = db.SUB_MENU.Where(x => x.IDMAIN == MenuItem.ID).ToList();
                }

                listCustomMenu.Add(customMenu);
            }
            return listCustomMenu;
        }
    }
}