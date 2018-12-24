using System.Data.Entity;
using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MAD.Models;
using MAD.Service;
using MDA.IService;

namespace MAD.WebSite.Config
{
    public class AutoFacConfig
    {
        /// <summary>
        /// 注册AutoFac方法
        /// </summary>
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired(); //将所有Controller注入到MVC中

            //Assembly controllerAss = Assembly.Load("Wchl.WMBlog.WebUI");
            //builder.RegisterControllers(controllerAss);

            //告诉autofac框架注册数据仓储层所在程序集中的所有类的对象实例
            Assembly respAss = Assembly.Load("MAD.Dal");
            //创建respAss中的所有类的instance以此类的实现接口存储
            builder.RegisterTypes(respAss.GetTypes()).Where(x => x.Name.EndsWith("Dal")).AsImplementedInterfaces().InstancePerLifetimeScope().PropertiesAutowired();
            ////或者统一全部注入
            //builder.RegisterTypes(respAss.GetTypes()).AsImplementedInterfaces().PropertiesAutowired();

            //告诉autofac框架注册业务逻辑层所在程序集中的所有类的对象实例
            Assembly serpAss = Assembly.Load("MAD.Service");    
            //创建serAss中的所有类的instance以此类的实现接口存储
            builder.RegisterTypes(serpAss.GetTypes()).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().PropertiesAutowired();
            ////或者统一全部注入
            //builder.RegisterTypes(serpAss.GetTypes()).AsImplementedInterfaces().PropertiesAutowired();


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container)); //更改MVC的注入方式为AutoFac
        }
    }
}