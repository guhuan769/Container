using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Company.IDAL;
using Company.DAL;

namespace Company.DALContainer
{
    public class Container
    {
        /// <summary>
        /// IOC 容器
        /// </summary>
        public static Autofac.IContainer container = null;

        public static T Resolve<T>()
        {
            try
            {
                if (container == null)
                {
                    Initialise();
                }
            }
            catch (Exception ex)
            {

                throw new System.Exception("IOC实例化出错!"+ ex.Message);
            }
            return container.Resolve<T>();
        }
        /// <summary>
        /// 初始化
        /// </summary>
        private static void Initialise()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<StaffDAL>().As<IStaffDAL>().InstancePerLifetimeScope();
            container = builder.Build();
        }
    }
}
