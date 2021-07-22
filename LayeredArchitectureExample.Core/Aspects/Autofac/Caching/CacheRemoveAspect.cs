﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using LayeredArchitectureExample.Core.CrossCuttingConcerns.Caching;
using LayeredArchitectureExample.Core.Utilities.Interceptors;
using LayeredArchitectureExample.Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace LayeredArchitectureExample.Core.Aspects.Autofac.Caching
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}
