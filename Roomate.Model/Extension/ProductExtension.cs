using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roommate.Model.Extension
{
    public static class ProductExtension
    {
        public static DateTime toGMTTime(this DateTime Time)
        {
            return Time.AddHours(-3);
        }
    }
}
