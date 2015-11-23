using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jitter.Models;
using System.Collections.Generic;

namespace Jitter.Tests.Models
{
    [TestClass]
    public class JitterRepositoryTests
    {
        [TestMethod]
        public void JitterContextEnsureICanCreateInstance()
        {
            JitterContext context = new JitterContext();
            Assert.IsNotNull(context);
        }
    }

    [TestMethod]
    public void JitterRepositoryEnsureICanGetAllUsers()
    {
        //Arrange
        var expected = new List<JitterUser>
        {
            new JitterUser { Handle, "adam1"},
            new JitterUser {Handle, "rumbadancer2"  }
        };
        JitterRepository repository = new JitterRepository();
        //Act
        var actual = respository.GetAllUsers();
        //Assert
        Assert.AreEqual("adam1", actual.First().Handle);
        CollectionAssert.AreEqual(expected, actual); 
    }

    [TestMethod]
    public void JitterRepositoryEnsureIHaveAContext()
    {
        JitterRepository repository = new JitterRepository();
        var actual = repository.Context;
        Assert.IsInstanceOfType(actual, typeof(JitterContext));
    }
}
