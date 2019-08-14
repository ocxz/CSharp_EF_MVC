using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _03使用EF进行增删改
{
    /// <summary>
    /// Add 的摘要说明
    /// </summary>
    public class Add : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            response.ContentType = "text/plain";

            #region 利用EF向数据库添加记录

            //// 创建EF上下文对象
            //dbTest4Entities dbContext = new dbTest4Entities();

            //// 创建实体对象
            //UserInfo user = new UserInfo();
            //user.UserName = "张思思";
            //user.UserPwd = "123456";

            //// 将实体对象加入到数据Set中
            //dbContext.UserInfo.Add(user);

            //// 保存数据Set的改变，映射到数据库中
            //dbContext.SaveChanges();

            #endregion

            #region 利用EF向数据库修改

            //dbTest4Entities dbContext = new dbTest4Entities();

            //UserInfo user = new UserInfo { UserId = 9, UserName = "王大圣", UserPwd = "998101" };

            //// 告诉上下文 对此实体进行跟新操作
            //dbContext.Entry<UserInfo>(user).State = EntityState.Modified;

            //// 将实体变化保存到数据库中  执行sql脚本
            //dbContext.SaveChanges();
            //response.Write("修改完成");

            #endregion

            #region 利用EF向数据库修改指定列数据

            //// 先验证，在到sql 所以生成的对象必须要通过验证（跟数据库约束保存一致）
            //dbTest4Entities dbContext = new dbTest4Entities();

            //string newName = "张灵";

            //UserInfo user = new UserInfo { UserId = 8, UserName = newName, UserPwd = "fdsa" };

            //// 将实体添加到dbContext管理
            //dbContext.UserInfo.Attach(user);

            //// 指定UserName的修改模式为true
            //dbContext.Entry<UserInfo>(user).Property<string>(u => u.UserName).IsModified = true;

            //dbContext.SaveChanges();
            //response.Write("修改名字成功");


            #endregion

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}