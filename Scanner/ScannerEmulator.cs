using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Scanner
{
    public class ScannerEmulator : IScanner
    {
        public int CPULoad { get; private set; }

        public int RAMLoad { get; private set; }

        private readonly Random random = new();
        private static readonly ScannerEmulator? instance = null;
        private ScannerEmulator()
        {
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ScannerEmulator GetInstace()
        {
            if (instance != null)
            {
                return instance;
            }
            return new ScannerEmulator();
        }

        public byte[] GetSequence(string source)
        {
            CPULoad = random.Next(101);
            RAMLoad = random.Next(100500);

            using var fileStream = File.OpenRead(source);
            using var reader = new BinaryReader(fileStream);
            var buffer = reader.ReadBytes((int)fileStream.Length);

            return buffer;
        }
    }
}
