//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASPdotNetMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MENU
    {
        public MENU()
        {
            this.SUB_MENU = new HashSet<SUB_MENU>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string LINK { get; set; }
        public Nullable<int> CODE { get; set; }
        public string ICON { get; set; }
        public Nullable<short> NO { get; set; }
    
        public virtual ICollection<SUB_MENU> SUB_MENU { get; set; }
    }
}