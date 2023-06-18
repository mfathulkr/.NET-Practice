using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//Random Number Generator class who has GetBytes method

namespace API
{
    public class RNGCryptoServiceProviderAdapter : IRandomNumberGenerator
    {
        private readonly RNGCryptoServiceProvider rngCryptoServiceProvider;

        //Constructor
        public RNGCryptoServiceProviderAdapter()
        {
            rngCryptoServiceProvider = new RNGCryptoServiceProvider();
        }

        //Get Byte method takes array of bytes to fill up with strong sequence of random values
        public void GetBytes(byte[] data)
        {
            rngCryptoServiceProvider.GetBytes(data);
        }
    }
}
