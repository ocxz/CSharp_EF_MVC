using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_2ModelFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            #region 一对多的添加

            //// 创建上下文
            //DataModelContainer dbContext = new DataModelContainer();

            //// 创建一个用户对象
            //UserInfo user = new UserInfo { UName = "张三" };

            //// 将用户对象添加到上下文进行管理
            //dbContext.UserInfo.Add(user);

            //// 添加两个订单对象
            //OrderInfo order1 = new OrderInfo() { Content = "哇哈哈" };
            //OrderInfo order2 = new OrderInfo() { Content = "加多宝" };

            //// 将两个订单对象添加上下文进行管理
            //dbContext.OrderInfoSet.Add(order1);
            //dbContext.OrderInfoSet.Add(order2);

            ////// 将用户和订单关联起来 由少的一方管理
            ////user.OrderInfo.Add(order1);
            ////user.OrderInfo.Add(order2);

            //// 由多的一方管理
            //order1.UserInfo = user;
            //order2.UserInfo = user;

            //// 保存改变
            //dbContext.SaveChanges();

            //Console.WriteLine("操作完成"); 

            #endregion

            #region 一对多的修改

            //DataModelContainer dbContext = new DataModelContainer();

            //UserInfo user = new UserInfo() { Id = 1};
            //user.UName = "张珊珊" + DateTime.Now.Second.ToString();

            //// 给整个都修改了
            ////dbContext.Entry(user).State = System.Data.Entity.EntityState.Modified;

            //// 修改指定列
            //// 将user对象放于dbContext管理
            //dbContext.UserInfo.Attach(user);
            //// 设值user属性中的UName属性为可修改模式
            //dbContext.Entry(user).Property(u=>u.UName).IsModified = true;

            //// 保存改变
            //dbContext.SaveChanges();
            //Console.WriteLine("修改完成");

            #endregion

            #region Linq to EF查询 第一次延迟加载用时查 不适合缓存

            //DataModelContainer dbContext = new DataModelContainer();

            //var temp = from u in dbContext.UserInfo
            //           where u.Id > 0
            //           select u;

            //foreach (var user in temp)
            //{
            //    Console.Write(user.Id + "  " + user.UName + "  ");
            //    foreach (var order in user.OrderInfo)
            //    {
            //        Console.Write(order.Content + "  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            #region 两种延迟加载 用时查(加载)

            //var temp2 = from u in temp
            //            where u.UName.Contains("张")
            //            select u;

            //foreach (var user in temp2)
            //{
            //    Console.Write(user.Id + "  " + user.UName + "  ");
            //    foreach (var order in user.OrderInfo)
            //    {
            //        Console.Write(order.Content + "  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            #endregion

            #endregion

            #region Linq to List 查询

            //DataModelContainer dbContext = new DataModelContainer();

            //var temp = from u in dbContext.UserInfo.ToList()
            //                  where u.Id > 0
            //                  select u;

            //foreach (var user in temp)
            //{
            //    Console.Write(user.UName+"  ");
            //    foreach (var order in user.OrderInfo)
            //    {
            //        Console.Write(order.Content+"  ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();

            #endregion



            #region linq 连接查询 Include

            //DataModelContainer dbContext = new DataModelContainer();

            //var temp = from u in dbContext.UserInfo.Include("OrderInfo")
            //           where u.Id > 0
            //           select u;

            //foreach (var user in temp)
            //{
            //    Console.Write(user.UName + "  ");
            //    foreach (var order in user.OrderInfo)
            //    {
            //        Console.Write(order.Content + "  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            #endregion

            #region lambda查询

            //DataModelContainer dbContext = new DataModelContainer();

            //var temp = dbContext.UserInfo.Where(u => u.Id > 0);

            //foreach (var user in temp)
            //{
            //    Console.Write(user.Id+"  "+user.UName);
            //    foreach (var order in user.OrderInfo)
            //    {
            //        Console.Write("  "+order.Content);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            #endregion

            #region lambda分页查询

            //DataModelContainer dbContext = new DataModelContainer();

            //// 默认升序  降序：OrderByDescending(u=>u.Id)
            //// 越过多少条，去多少条 一页5条 去第三页  就是越过5*（3-1） 去5条
            //var pageData = dbContext.UserInfo.Where(u => u.Id > 0).OrderBy(u => u.Id).Skip(5 * (3 - 1)).Take(5);

            //foreach (var user in pageData)
            //{
            //    Console.Write(user.Id + "  " + user.UName);
            //    foreach (var order in user.OrderInfo)
            //    {
            //        Console.Write("  " + order.Content);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();


            #endregion

            #region linq做分页查询

            //DataModelContainer dbContext = new DataModelContainer();
            //var temp = (from u in dbContext.UserInfo
            //            where u.Id > 0
            //            orderby u.Id descending  // 降序，默认升序  
            //            select u).Skip(5 * (1 - 1)).Take(5);


            //foreach (var user in temp)
            //{
            //    Console.Write(user.Id + "  " + user.UName);
            //    foreach (var order in user.OrderInfo)
            //    {
            //        Console.Write("  " + order.Content);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            #endregion

            #region linq查询部分列的数据


            //DataModelContainer dbContext = new DataModelContainer();

            //var temp = from u in dbContext.UserInfo
            //           where u.Id > 0
            //           select new { MyId = u.Id, u.UName, OrderCount = u.OrderInfo.Count };

            //foreach (var uInfo in temp)
            //{
            //    Console.WriteLine(uInfo.MyId);
            //    Console.WriteLine(uInfo.UName);
            //    Console.WriteLine(uInfo.OrderCount);
            //}

            //Console.ReadKey();

            #endregion

            #region lambda查询部分列数据

            //DataModelContainer dbContext = new DataModelContainer();

            //var temp = dbContext.UserInfo.Where(u => u.Id > 0).Select(u => new { u.Id, u.UName, OrderCount = u.OrderInfo.Count });

            //foreach (var uInfo in temp)
            //{
            //    Console.WriteLine(uInfo.Id);
            //    Console.WriteLine(uInfo.UName);
            //    Console.WriteLine(uInfo.OrderCount);
            //}

            //Console.ReadKey();

            #endregion



        }
    }
}
