using System;
using docker_ci.domain.models;
using Xunit;

namespace Application
{
    public class Person_AgeCheck
    {
        private Person _person;

        public Person_AgeCheck()
        {
        }

        [Fact]
        public void IsNotOfAge_ReturnTrue()
        {
            _person = new Person() { Age = 17 };
            var notOfAge = !_person.IsOfAge;
            Assert.True(notOfAge, "Person is less than 18");
        }
    }
}
