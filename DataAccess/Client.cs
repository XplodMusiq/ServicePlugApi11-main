//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicePlugApi11.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        public string user_id { get; set; }
        public string client_address { get; set; }
        public string CardNumber { get; set; }
        
        public virtual BankingDetail BankingDetail { get; set;}
      
    
        public virtual User User { get; set; }
    
        
    }
}
