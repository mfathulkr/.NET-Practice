using Newtonsoft.Json.Linq;
using System.IO;

//I used JObject and JArray rather than deserializer since it fit my situation.

string jsonFilePath = "C:\\Users\\Mehmet Fatih ÜLKER\\source\\repos\\ReceiptScannerSystem\\ReceiptScannerSystem\\response.json";
string jsonString = File.ReadAllText(jsonFilePath);

JArray jsonArray = JArray.Parse(jsonString);

//we extract the first object from the array
JObject firstObject = (JObject)jsonArray[0];

//we then extract the value of the "description" field as a string
string description = firstObject["description"].ToString();

//we print
Console.WriteLine(description);
