using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    public static class Students
    {
        public static string GetStudNumber(string fio, DateTime year, int group)
        {
            var fullname = fio.Split(' ');
            return $"{year.ToString("yyyy")}.{group.ToString("1234567890")}.{fullname[0]} {fullname[1]} {fullname[2]}";
        }

        public static bool ValidateStudNumber(string fio)
        {
            if (!fio.Any(Char.IsLower))
                return false;
           
            return true;
        }
    }
}
