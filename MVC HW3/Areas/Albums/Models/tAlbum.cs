//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_HW3.Areas.Albums.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tAlbum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tAlbum()
        {
            this.tPhoto = new HashSet<tPhoto>();
        }
    
        public int fAl_ID { get; set; }
        public int fTC_ID { get; set; }
        public Nullable<System.DateTime> fAl_Date { get; set; }
    
        public virtual tTravelCase tTravelCase { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tPhoto> tPhoto { get; set; }
    }
}
