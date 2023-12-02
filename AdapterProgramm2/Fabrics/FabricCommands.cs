using Adapter.Abstraction;
using Adapter.Services;
using AdapterProgramm2.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Fabrics
{
    public static class FabricCommands2
    {

        private static IFileService _fileService = new FileService();

        public static IProgramm2 CreateProgramm2() => new Programm2(_fileService, new AdapterProgtamm(new Programm1(_fileService), _fileService));
    }
}
