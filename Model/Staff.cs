//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarberShop.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        public Staff()
        {
            this.Services = new HashSet<Services>();
        }
    
        public int IDMaster { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Post { get; set; }
        public int WorkExperience { get; set; }
        public string PhoneNumber { get; set; }
        public int AuthorizationData { get; set; }
    
        public virtual ICollection<Services> Services { get; set; }
        public virtual User User { get; set; }
    }
}
