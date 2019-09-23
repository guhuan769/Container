using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Company.Model;


namespace Company.DAL
{
    public partial class DbContextFactory
    {
        //创建EF 上下文对象,已经存在就直接取 ,不存在就创建,保证线程内是唯一
        public static DbContext Create()
        {
            DbContext dbContext = CallContext.GetData("DbContext") as DbContext;
            if (dbContext == null)
            {
                dbContext = new CompanyEntities4();
                CallContext.SetData("DbContext", dbContext);
            }
            return dbContext;
        }


    }
}
