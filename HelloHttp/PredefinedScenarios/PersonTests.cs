using HelloHttp.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace HelloHttp.PredefinedScenarios
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void GetPerson()
        {
            var person = Person.GetPerson("joe");

            Assert.IsTrue(person.Equals(new Person
            {
                FirstName = "Joe",
                LastName = "Schmoe",
                Age = 25,
                Married = false,
                BirthDate = new DateTime(1980, 1, 1)
            }));
        }

        [TestMethod]
        public void GetPeople()
        {
            var people = Person.GetPeople();

            Assert.AreEqual(2, people.Count());
            Assert.IsTrue(people.Any(p => p.Equals(new Person
            {
                FirstName = "Joe",
                LastName = "Schmoe",
                Age = 25,
                Married = false,
                BirthDate = new DateTime(1980, 1, 1)
            })));
            Assert.IsTrue(people.Any(p => p.Equals(new Person
            {
                FirstName = "Jon",
                LastName = "Smith",
                Age = 35,
                Married = true,
                BirthDate = new DateTime(1990, 2, 1)
            })));
        }

        [TestMethod]
        public void PostPerson()
        {
            var person = new Person
            {
                FirstName = "Jane",
                LastName = "Smith",
                Age = 35,
                Married = true,
                BirthDate = new DateTime(1990, 3, 1)
            };

            var response = Person.PostPerson(person);

            //If we were testing a real application, we would
            //execute a GET here in order to validate the POST
            //was successful.
            //Assert.IsTrue(person.Equals(Person.GetPerson("jane")));

            Assert.AreEqual("Person creation success!", response);
        }
    }
}
