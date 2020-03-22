using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestGithubActions.Controllers;
using Xunit;

namespace XUnitTestProject
{
    public class WhenUsingTestController
    {

        [Fact]
        public void AddTestActionMethod()
        {
            TestController testController = new TestController();

            var response = testController.Add(4, 5) as ObjectResult;
            Assert.Equal(StatusCodes.Status200OK, response.StatusCode);
            Assert.Equal(9, response.Value);
        }

        [Fact]
        public void TestHelloMethod()
        {
            TestController testController = new TestController();

            var response = testController.Hello() as ObjectResult;
            Assert.Equal(StatusCodes.Status200OK, response.StatusCode);
            Assert.Equal("hello world!", response.Value);
        }
    }
}
