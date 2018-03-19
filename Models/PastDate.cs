using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace Restauranter
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed public class PastDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool result = false;
            if (value is DateTime)
            {
                if ((DateTime)value <= DateTime.UtcNow)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}