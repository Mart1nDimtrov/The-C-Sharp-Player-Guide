using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Interfaces.Interfaces
{
    public interface IFileWriter
    {
        string Extension { get; }
        void Write(string filename);
    }
}
