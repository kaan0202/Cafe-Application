using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitOfWork.Core
{
    public class ServiceGetter
    {
        private readonly IServiceProvider _serviceProvider;

        public ServiceGetter(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected TService GetService<TService>() where TService : notnull,IInjectable
            =>_serviceProvider.GetRequiredService<TService>();
    }
}
