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
    
    public partial class User
    {
        public User()
        {
            this.Staff = new HashSet<Staff>();
        }
    
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<Staff> Staff { get; set; }
    }
}
