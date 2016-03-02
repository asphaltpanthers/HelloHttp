using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HelloHttp.Entities
{
    public class Person
    {
        public String FirstName;
        public String LastName;
        public Int32 Age;
        public Boolean Married;
        public DateTime BirthDate;

        public Boolean Equals(Person person)
        {
            return String.Equals(FirstName, person.FirstName) &&
                String.Equals(LastName, person.LastName) &&
                Int32.Equals(Age, person.Age) &&
                Boolean.Equals(Married, person.Married) &&
                DateTime.Equals(BirthDate, person.BirthDate);
        }

        public static Person GetPerson(string name)
        {
            return JsonConvert.DeserializeObject<Person>(Api.Get(new Uri(Config.Url + "api/person/" + name)));
        }

        public static IEnumerable<Person> GetPeople()
        {
            return JsonConvert.DeserializeObject<List<Person>>(Api.Get(new Uri(Config.Url + "api/person")));
        }
    }
}