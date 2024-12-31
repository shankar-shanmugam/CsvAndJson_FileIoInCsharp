using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace CsvAndJson_FileIo
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return $"person Id:{Id}, Name:{Name}, Address:{Address}";
        }

        public static List<Person> getPerson()
        {
            var people = new List<Person>
                               {
                                 new Person { Id = 1, Name = "John", Address="123 street gandhi bazar" },
                                 new Person { Id = 2, Name = "Jane", Address="146 north side road" }
                                };
            return people;
        }

    }
}
