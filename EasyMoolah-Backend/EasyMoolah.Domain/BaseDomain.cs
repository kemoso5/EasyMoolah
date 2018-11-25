using EasyMoolah.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyMoolah.Domain
{
    public abstract class BaseDomain
    {
        //protected readonly ISecurity Security;
        //protected readonly ITimeZone TimeZone;
        //protected readonly ILastViewed LastViewed;
        //protected readonly IAuditLog AuditLog;

        //public string ViewPermission { get; set; }
        //public string EditPermission { get; set; }
        //public string AddPermission { get; set; }
        //public string RemovePermission { get; set; }

        //public class BaseDomain
        //{
        //    protected BaseDomain(ISecurity security, ITimeZone timeZone, ILastViewed lastViewed, IAuditLog auditLog)
        //    {
        //        Security = security;
        //        TimeZone = timeZone;
        //        LastViewed = lastViewed;
        //        AuditLog = auditLog;
        //    }
        //}

        protected async Task SetRemoveItemDetails<T>(Request request, T item) where T : BaseModel
        {
            item.IsActive = false;
            item.ChangeDate = DateTime.UtcNow;
        }

        protected async Task SetAddItemDetails<T>(Request request, T item) where T : BaseModel
        {
            item.IsActive = true;
            item.CreateDate = DateTime.UtcNow;
            item.ChangeDate = DateTime.UtcNow;
        }

        protected async Task SetEditItemDetails<T>(Request request, T item) where T : BaseModel
        {
            item.IsActive = true;
            item.ChangeDate = DateTime.UtcNow;
        }
    }
}