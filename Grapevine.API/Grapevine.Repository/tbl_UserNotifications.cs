//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grapevine.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_UserNotifications
    {
        public int iNotificationId { get; set; }
        public Nullable<int> iUserId { get; set; }
        public string vDescription { get; set; }
        public Nullable<int> iByUserId { get; set; }
        public string vType { get; set; }
        public Nullable<System.DateTime> dNotifyDate { get; set; }
    }
}