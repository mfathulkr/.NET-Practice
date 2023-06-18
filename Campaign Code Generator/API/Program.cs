using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Linq;


//Entry class that our program start running
//Creates a Generator object to generate codes

public class Program
{
    public static void Main()
    {
        Generator gn = new Generator();
        gn.GenerateCodes();
    }
}
