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
    
    public partial class BOOK
    {
        public BOOK()
        {
            this.USER_BOOK = new HashSet<USER_BOOK>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string CONTENT { get; set; }
        public string AUTHOR { get; set; }
        public string PUBLISHER { get; set; }
        public Nullable<int> COST { get; set; }
        public Nullable<short> IN_LIB { get; set; }
        public Nullable<short> OUT_LIB { get; set; }
        public byte[] COVER { get; set; }
    
        public virtual ICollection<USER_BOOK> USER_BOOK { get; set; }
    }
}
