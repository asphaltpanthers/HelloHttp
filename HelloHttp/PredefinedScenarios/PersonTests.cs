using HelloHttp.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloHttp.PredefinedScenarios
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void GetPerson()
        {
            var person = Person.GetPerson("joe");

            person.Equals(new Person
            {
                FirstName = "Joe",
                LastName = "Scmhoe",
                Age = 25,
                Married = false,
                BirthDate = new DateTime(1980, 1, 1)
            });
        }
    }
}
