using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ParentPropertyNameAttribute : Attribute
    {
        public readonly string PropertyName;

        public ParentPropertyNameAttribute(string propertyName)
        {
            this.PropertyName = propertyName;
        }
    }
}
