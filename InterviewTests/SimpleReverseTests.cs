using System;
using Xunit;
using Interview.Services;

namespace Interview.UnitTests.Service
{
    public class SimpleReverse_SampleTest
    {
        private readonly InterviewService _interviewService;

        public SimpleReverse_SampleTest()
        {
           _interviewService = new InterviewService();
        }

        [Fact]
        // This test is a sample test and should be removed!
        public void SampleTestThrowsNotImplementedException()
        {
            Action a = () => _interviewService.SimpleReverse("Test");
            Assert.Throws<NotImplementedException>(a);
        }
    }
}
