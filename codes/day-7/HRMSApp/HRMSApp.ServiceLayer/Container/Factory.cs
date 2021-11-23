using HRMSApp.ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMSApp.ServiceLayer.Container
{
    //public class Factory
    //{
    //    public static TInterace Create<TInterace,TClass>()
    //    {
    //        return (TInterace)Activator.CreateInstance(typeof(TClass));
    //    }
    //}
    public class Services
    {
        public static TClass AddDbContext<TClass>()
        {
            return (TClass)Activator.CreateInstance(typeof(TClass));
        }
    }
}
