﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAADLPC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ReportsEntities : DbContext
    {
        public ReportsEntities()
            : base("name=ReportsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Breakdown_Maintenance> Breakdown_Maintenance { get; set; }
        public virtual DbSet<Component_Information> Component_Information { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<usertable> usertables { get; set; }
        public virtual DbSet<Maintenance_services> Maintenance_services { get; set; }
        public virtual DbSet<systranschema> systranschemas { get; set; }
        public virtual DbSet<SysLogEvent> SysLogEvents { get; set; }
    }
}