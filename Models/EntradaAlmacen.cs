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
    
    public partial class EntradaAlmacen
    {
        public int Id_EntradaAlmacen { get; set; }
        public System.DateTime FechaEntrada { get; set; }
        public int Id_TipoEntrada { get; set; }
        public Nullable<int> Id_Empleado { get; set; }
        public Nullable<int> Id_OrdenCompra { get; set; }
        public Nullable<int> Id_Reconteo { get; set; }
        public int Id_Almacen { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    
        public virtual Almacen Almacen { get; set; }
        public virtual Cat_Empleados Cat_Empleados { get; set; }
        public virtual Cat_TiposEntradas Cat_TiposEntradas { get; set; }
    }
}