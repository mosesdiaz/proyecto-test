//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyecto_test
{
    using System;
    using System.Collections.Generic;
    
    public partial class empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empleado()
        {
            this.departamento2 = new HashSet<departamento>();
            this.empleado_deduccion = new HashSet<empleado_deduccion>();
            this.empleado_ingreso = new HashSet<empleado_ingreso>();
        }
    
        public int id_empleado { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public Nullable<int> departamento { get; set; }
        public Nullable<int> puesto { get; set; }
        public Nullable<int> nomina { get; set; }
        public Nullable<decimal> salario { get; set; }
    
        public virtual departamento departamento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<departamento> departamento2 { get; set; }
        public virtual nomina nomina1 { get; set; }
        public virtual puesto puesto1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<empleado_deduccion> empleado_deduccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<empleado_ingreso> empleado_ingreso { get; set; }
    }
}