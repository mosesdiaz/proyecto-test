﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SistemaNominaEntities : DbContext
    {
        public SistemaNominaEntities()
            : base("name=SistemaNominaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<departamento> departamento { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<nomina> nomina { get; set; }
        public virtual DbSet<puesto> puesto { get; set; }
        public virtual DbSet<tipo_deduccion> tipo_deduccion { get; set; }
        public virtual DbSet<tipo_ingreso> tipo_ingreso { get; set; }
        public virtual DbSet<empleado_deduccion> empleado_deduccion { get; set; }
        public virtual DbSet<empleado_ingreso> empleado_ingreso { get; set; }
    }
}
