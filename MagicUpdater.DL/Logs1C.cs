//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagicUpdater.DL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Logs1C
    {
        public int Id { get; set; }
        public int ComputerId { get; set; }
        public Nullable<int> OperationId { get; set; }
        public Nullable<bool> IsError { get; set; }
        public string LogMessage { get; set; }
        public System.DateTime LogDate { get; set; }
    
        public virtual ShopComputer ShopComputer { get; set; }
    }
}