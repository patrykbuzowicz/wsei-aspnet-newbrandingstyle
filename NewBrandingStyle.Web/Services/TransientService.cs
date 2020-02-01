using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Services
{
    public class TransientService
    {
        private int _value;

        public string GetMessage()
        {
            _value++;
            return $"transient value: {_value}";
        }
    }
}
