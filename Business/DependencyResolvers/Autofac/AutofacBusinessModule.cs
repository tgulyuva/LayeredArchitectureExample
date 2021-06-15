using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using LayeredArchitectureExample.Business.Abstract;
using LayeredArchitectureExample.Business.Concrete;
using LayeredArchitectureExample.DataAccess.Abstract;
using LayeredArchitectureExample.DataAccess.Concrete.EntityFramework;

namespace LayeredArchitectureExample.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}