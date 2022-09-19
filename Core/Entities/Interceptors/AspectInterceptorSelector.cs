﻿using System;
using System.Linq;
using System.Reflection;
using Castle.DynamicProxy;
using static Core.Entities.Interceptors.Class1;

namespace Core.Entities.Interceptors
{
    
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);
            

            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}