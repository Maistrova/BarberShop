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
    
    public partial class PriceList
    {
        public PriceList()
        {
            this.Services = new HashSet<Services>();
        }
    
        public int IDList { get; set; }
        public string Prоcedure { get; set; }
        public decimal Price { get; set; }
        public int IDMaterial { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual ICollection<Services> Services { get; set; }
    }
}
