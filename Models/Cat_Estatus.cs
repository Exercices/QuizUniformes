//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizUniformes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cat_Estatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cat_Estatus()
        {
            this.Cat_Articulos = new HashSet<Cat_Articulos>();
            this.Cat_Tallas = new HashSet<Cat_Tallas>();
            this.Cat_TiposArticulos = new HashSet<Cat_TiposArticulos>();
            this.Cat_TiposEntradas = new HashSet<Cat_TiposEntradas>();
            this.Cat_TiposTallas = new HashSet<Cat_TiposTallas>();
        }
    
        public int Id_Estatus { get; set; }
        public string Estatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cat_Articulos> Cat_Articulos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cat_Tallas> Cat_Tallas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cat_TiposArticulos> Cat_TiposArticulos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cat_TiposEntradas> Cat_TiposEntradas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cat_TiposTallas> Cat_TiposTallas { get; set; }
    }
}
