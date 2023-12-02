using Adapter.Abstraction;
using Adapter.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Fabrics
{
    public static class FabricCommands
    {

        private static IFileService _fileService = new FileService();

        public static IProgramm1 CreateProgramm1() => new Programm1(_fileService);
    }
}
