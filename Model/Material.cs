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
    
    public partial class Material
    {
        public Material()
        {
            this.PriceList = new HashSet<PriceList>();
        }
    
        public int IDMaterial { get; set; }
        public string Material1 { get; set; }
        public string Manufacturer { get; set; }
        public string Supplier { get; set; }
    
        public virtual ICollection<PriceList> PriceList { get; set; }
    }
}
