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
    
    public partial class OperationType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OperationType()
        {
            this.Operations = new HashSet<Operation>();
            this.OperationTypeAttributes = new HashSet<OperationTypeAttribute>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string SavedAttributes { get; set; }
        public string NameRus { get; set; }
        public int GroupId { get; set; }
        public string FileName { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public string FileMD5 { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
        public Nullable<bool> Visible { get; set; }
    
        public virtual OperationGroup OperationGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation> Operations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationTypeAttribute> OperationTypeAttributes { get; set; }
    }
}
