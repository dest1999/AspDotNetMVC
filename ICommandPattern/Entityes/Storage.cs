using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ICommandPattern
{
    internal static class Storage
    {
        private static List<ICommand> list = new();

        public static void Add(ICommand item)
        {
            list.Add(item);
        }

        public static ICommand? GetById(int id)
        {
            if(id < list.Count)
            {
                return list[id];
            }
            return null;
        }

    }
}
