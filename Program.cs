using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Hagwartz
{
    
  internal class Program
  {
    public static void Main(string[] args)
    {
      authorizedPersonsDetector();

    }
    public static authorizedPersons[] authorizedPersonsDetector()
    {
      dynamic jsonFile = JsonConvert.DeserializeObject<authorizedPersons[]>(File.ReadAllText("JSON_DATA.json"));
      return jsonFile;
    }
  }
}