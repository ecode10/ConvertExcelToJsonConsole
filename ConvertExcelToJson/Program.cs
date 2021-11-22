using ConvertCsvToJson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ConvertExcelToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //var path = @"C:\Temp\Data.xlsx";

            //var excel = new ExcelToJsonLibrary.ExcelToJson();
            //var result = excel.GetJson(path, "Sheet1");

            //Console.WriteLine(result);

            var main = new Main();
            var result = ((IMain)main).ConvertCsvFileToJsonObject("C:/temp/Data.csv");

            dynamic u = JsonConvert.DeserializeObject(result);

            var user = JsonConvert.DeserializeObject<IList<UserModel>>(result);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
