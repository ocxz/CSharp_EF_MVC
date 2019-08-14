namespace _09CodeFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    public class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<OrderInfo> OrderInfo { set; get; }
    }
}