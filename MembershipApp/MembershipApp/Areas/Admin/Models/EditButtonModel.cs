using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace MembershipApp.Areas.Admin.Models
{
    public class EditButtonModel
    {
        public int ItemId { get; set; }
        public int ProductId { get; set; }
        public int SubscriptionId { get; set; }
        public string Link
        {
            get
            {
                var s = new StringBuilder("?");
                if (ItemId > 0)
                {
                    s.Append(String.Format("{0}={1}&", "id", ItemId));
                }
                if (ProductId > 0)
                {
                    s.Append(String.Format("{0}={1}&", "productId", ProductId));
                }
                if (SubscriptionId > 0)
                {
                    s.Append(String.Format("{0}={1}&", "id", SubscriptionId));
                }

                return s.ToString().Substring(0, s.Length - 1);
            }
        }
    }
}