//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Breakdown_Maintenance
    {
        public int Equipment_ID { get; set; }
        public Nullable<System.DateTime> Maintainance_Date { get; set; }
        public string Service_provider_details { get; set; }
        public Nullable<System.TimeSpan> Equipment_down_time { get; set; }
        public Nullable<double> Maintenance_cost { get; set; }
        public Nullable<double> Shutdown_maintenance_cost { get; set; }
        public Nullable<double> Breakdown_maintenance_cost { get; set; }
        public string Equipment_name { get; set; }
    }
}