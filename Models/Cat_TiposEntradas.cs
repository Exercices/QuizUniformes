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
    
    public partial class Cat_TiposEntradas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cat_TiposEntradas()
        {
            this.EntradaAlmacen = new HashSet<EntradaAlmacen>();
        }
    
        public int Id_TipoEntrada { get; set; }
        public string Tipo { get; set; }
        public int Id_Estatus { get; set; }
    
        public virtual Cat_Estatus Cat_Estatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntradaAlmacen> EntradaAlmacen { get; set; }
    }
}
