using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09CodeFirst
{
    public class UserInfo
    {
        public UserInfo()
        {
            this.OrderInfo = new HashSet<OrderInfo>();
        }
        [Key]
        public int Id { get; set; }
        public String UName { get; set; }
        public int UAge { get; set; }
        public virtual ICollection<OrderInfo> OrderInfo { get; set; }
    }
}
