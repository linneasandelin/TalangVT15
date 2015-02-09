using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HelloWorld
{
    class Tests
    {
        [Test]
        public void should_return_hello_world()
        {
            Assert.That(HelloWorld.Hello(), Is.EqualTo("Hello World!"));
        }
        
    }
}
