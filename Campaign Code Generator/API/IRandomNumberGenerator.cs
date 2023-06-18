using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//An Interface to inject the Random Number Generator
namespace API
{
    public interface IRandomNumberGenerator
    {
        void GetBytes(byte[] data);
    }
}
