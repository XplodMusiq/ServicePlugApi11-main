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
    
    public partial class BankingDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BankingDetail()
        {
            this.Users = new HashSet<User>();
        }
    
        public string CardNumber { get; set; }
        public string card_holdersname { get; set; }
        public string card_months { get; set; }
        public string card_year { get; set; }
        public string card_cvv { get; set; }
        
        public virtual User User { get; set; }
        public virtual Client Client { get; set; }
      
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection <User> Users { get; set; }
        public virtual ICollection <Client> Client { get; set; }
    }
}
