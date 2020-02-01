using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Services
{
    public class ScopedService
    {
        private int _value;

        public string GetMessage()
        {
            _value++;
            return $"scoped value: {_value}";
        }
    }
}
