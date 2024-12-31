using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;

namespace CsvAndJson_FileIo
{
    public class CsvDemo
    {

        public static void CsvWriteDemo()
        {
            string path = @"F:\c#practice\CsvAndJson_FileIo\CsvAndJson_FileIo\demo.csv";

            List<Person> records = Person.getPerson();

            if(!File.Exists(path))
            {
                File.Create(path);
                Console.WriteLine("File created successfully!!");
            }
            else
            {
                Console.WriteLine("file exists already");
            }
            using(var writer=new StreamWriter(path)) 
                using(var csvWriter=new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(records);
            }
            Console.WriteLine("Data is added into csv file");

        }

        public static void CsvReadDemo() 
        {
            string path = @"F:\c#practice\CsvAndJson_FileIo\CsvAndJson_FileIo\demo.csv";

            if (File.Exists(path))
            { 
                using(var reader=new StreamReader(path)) 
                    using(var csvReader=new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                   var res = csvReader.GetRecords<Person>();
                    foreach(var record in res)
                    {
                        Console.WriteLine(record);
                    }
                }
            }
        }





    }
}
