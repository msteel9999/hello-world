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
        // Task 1
        public void When_GivenASentence_SimpleRevers_ReturnsReversedString()
        {
            var actual = _interviewService.SimpleReverse("This is a computer");
            var expected = "computer a is This";
            Assert.Equal(expected, actual);
        }

        [Fact]
        //Task 2
        public void When_ArrayWithObjectsAndInts_GetAverageEvenNumberOfObjectsTest_ReturnsExpectedValue()
        {
            var stringArray = new String[] { "tea", "coffee" };
            var actual = _interviewService.GetAverageEvenNumberOfObjects(new System.Collections.Generic.List<object> { 1, 2, 3, 4, stringArray, 6, 7, 8, 9, 10 });
            var expected = 6.0;
            Assert.Equal(expected, actual);
        }

        [Fact]
        //Task 3
        public void When_PunctuatedSentence_ReverseWithPunctuation_ReturnsReversedWithPunctuation()
        {
            var actual = _interviewService.ReverseWithPunctuation("Are you there? I am here.");
            var expected = ".Here am i ?There you are";
            Assert.Equal(expected, actual);
        }
    }
}
