using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ICommandPattern
{
    internal class Storage
    {
        #region LazyInit
        //private static Lazy<Storage> instance = new Lazy<Storage>(() => new Storage());
        //public static Storage InstanceStorage => instance.Value;
        #endregion

        //public static Storage storage { get; } = new();
        private static List<ICommand> list = new();
        private Storage()
        {
        }

        [MethodImpl(MethodImplOptions.Synchronized)] //единовременно получить доступ к методу может только один поток
        public static void Add(ICommand item)
        {
            list.Add(item);
            Debug.WriteLine("Run Add method");
        }

        public static ICommand? GetById(int id)
        {
            Debug.WriteLine($"Run GetById method with id = {id}");
            if (id < list.Count)
            {
                return list[id];
            }
            return null;
        }

    }
}
