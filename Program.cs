using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Hagwartz
{
  public class Program
  {
    public static void Main(string[] args)
    {

    }
    public authorizedPersons[] authorizedPersonsDetector()
    {
      dynamic jsonFile = JsonConvert.DeserializeObject<authorizedPersons[]>(File.ReadAllText("JSON_DATA.json"));
      return jsonFile;
    }
  }
}