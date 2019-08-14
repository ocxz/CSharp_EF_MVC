using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            DataModel dbContext = new DataModel();

            // 数据库不存在时，根据app.config里的连接字符串来创建
            dbContext.Database.CreateIfNotExists();

            // 创建视图对象
            UserInfo user = new UserInfo { UName = "张三丰", UAge = 18 };
            OrderInfo order1 = new OrderInfo { Content = "绿茶", UserInfo = user };
            OrderInfo order2 = new OrderInfo { Content = "红茶", UserInfo = user };

            // 将order1对象加入到User导航对象集中
            user.OrderInfo.Add(order1);
            user.OrderInfo.Add(order2);

            // 将对象加入到dbContext中的UserInfo和OrderInfo的DBSet中
            dbContext.UserInfo.Add(user);
            dbContext.OrderInfo.Add(order1);
            dbContext.OrderInfo.Add(order2);

            // 保存修改
            dbContext.SaveChanges();
            Console.WriteLine("成功"); 
            Console.ReadKey();
        }
    }
}
