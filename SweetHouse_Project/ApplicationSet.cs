//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SweetHouse_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApplicationSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApplicationSet()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdProduct { get; set; }
        public Nullable<int> Type { get; set; }
    
        public virtual ClientSet ClientSet { get; set; }
        public virtual ProductSet ProductSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
