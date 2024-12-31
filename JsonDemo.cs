using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using Newtonsoft.Json;

namespace CsvAndJson_FileIo
{
    public class JsonDemo
    {
        public static void JsonWriteIntoFile()
        {
            string path = @"F:\c#practice\CsvAndJson_FileIo\CsvAndJson_FileIo\jsondemo.json";

            List<Person> records = Person.getPerson();

            if (!File.Exists(path))
            {
                File.Create(path);
                Console.WriteLine("File created successfully!!");
            }
            else
            {
                Console.WriteLine("file exists already");
            }
            string result = JsonConvert.SerializeObject(records, Formatting.Indented);
            File.WriteAllText(path, result);
        }

        public static void JsonReadFromFile()
        {
            string path = @"F:\c#practice\CsvAndJson_FileIo\CsvAndJson_FileIo\jsondemo.json";

            string s = File.ReadAllText(path);
            var res = JsonConvert.DeserializeObject<List<Person>>(s);
            if (res != null)
            {
                foreach (Person person in res)
                    Console.WriteLine(person);
            }
        }

    }
}
