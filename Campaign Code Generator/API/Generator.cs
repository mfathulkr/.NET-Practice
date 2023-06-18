using API;
using System.Security.Cryptography;
using System.Text;

//Generator class for Program
internal class Generator
{
    //demanded code length
    public int CodeLength { get; set; } = 8;
    //demanded number of codes
    //that can also asked from the user with modification
    public int NumberOfCodes { get; set; } = 1000;
    //demanded character pool
    public string Characters { get; set; } = "ACDEFGHKLMNPRTXYZ234579";
    //list of generated codes

    List<string> codes = new List<string>();
    //RNG object
    public IRandomNumberGenerator RandomNumberGenerator { get; set; } = new RNGCryptoServiceProviderAdapter();
    //This method teruns null unless codes list reaches the demanded number of codes. After that it returns codes list.
    public List<string> GenerateRandomCode()
    {
        //here we get strongly random bytes
        byte[] randomBytes = new byte[CodeLength];
        RandomNumberGenerator.GetBytes(randomBytes);
        //String builder to build the code in string
        StringBuilder code = new StringBuilder(CodeLength);
        foreach (byte b in randomBytes)
        {
            code.Append(Characters[b % Characters.Length]);
        }
        //our code
        string thecode = code.ToString();
        // we add it to the codes list
        codes.Add(thecode);
        //we check if the code is unique
        codes = CheckCode(codes);
        //if codes reached demanded number we return the list
        if(codes.Count == NumberOfCodes)
        {
            return codes;
        }
        //else we return null
        return null;
    }
    //method for checking if the code is unique or not
    //it gets the code list from parameter
    //eliminates the duplicates and returns
    //that way we provide uniqueness in the list
    public List<string> CheckCode(List<string> codes)
    {
        List<string> uniqueList = codes.Distinct().ToList();

        return uniqueList;
    }
    //method that we print the demanded codes
    //we build our finalCodes here 
    public void GenerateCodes()
    {
        List<string> finalCodes = GenerateRandomCode();
        
        while(finalCodes == null)
        {
            finalCodes = GenerateRandomCode();
        }
        //we print the codes
        foreach (string code in finalCodes)
        {
            Console.WriteLine(code);
        }
    }
}