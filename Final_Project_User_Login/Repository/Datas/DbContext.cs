using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Datas
{
    public static class DbContext<T>
    {
        public static List<T> Datas;

        static DbContext()
        {
            Datas = new List<T>();
        }
    }
}
