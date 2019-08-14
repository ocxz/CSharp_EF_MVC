using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04使用EF进行查询操作
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 利用EF查询所有

            //dbTest4Entities dbContext = new dbTest4Entities();
            //foreach (UserInfo user in dbContext.UserInfo)
            //{
            //    Console.WriteLine(user.UserId + " " + user.UserName + "  " + user.UserPwd);
            //}

            //Console.ReadKey();

            #endregion

            #region linq查询 linq to ef 查询是在数据库端进行过滤的

            //dbTest4Entities dbContext = new dbTest4Entities();

            //// 初始化了一下IQueryable接口里的三个参数
            //// 1、linq表达式转化为Expression类型
            //// 2、给Type ElementType 赋值
            //// 3、生成对应的Provider  此处是efProvider  类似于工厂设计模式
            //// 4、使用temp时，利用efProvider解析Expression，生成sql脚本，从数据库中加载数据，然后进行遍历执行
            //IQueryable<UserInfo> temp = from user in dbContext.UserInfo
            //                  where user.UserId > 8
            //                  select user;


            //foreach (var u in temp)
            //{
            //    Console.WriteLine(u.UserId + "  " + u.UserName + "  " + u.UserPwd);
            //}

            #endregion

            #region 协变和逆变

            //List<string> intList = new List<string>() { "1", "2", "3" };
            //Func<int, bool> delFunc;

            //// 
            //Func<object, bool> delParent = a => { return true; };

            #endregion

            #region 内存里面过滤，将数据库中所有数据查询加载进来，然后进行过滤

            //// List集合 跟 IQueryable接口的不同
            //// List集合  包括 array、dictionary,hashtable等经典集合

            //dbTest4Entities dbContext = new dbTest4Entities();

            //// linq to object 将数据库数据表的数据全部加载，转化为List集合，然后遍历集合，进行过滤
            //var demoList = from u in dbContext.UserInfo.ToList()
            //               where u.UserId > 8
            //               select u;

            //foreach (var user in demoList)
            //{
            //    Console.WriteLine(user.UserId+"  "+user.UserName+"  "+user.UserPwd);
            //}

            #endregion
        }
    }
}
