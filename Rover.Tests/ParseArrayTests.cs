using Rover.Cons;
using Rover.Cons.Input;
using Shouldly;


namespace Rover.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test] //return empty result when given empty input
        public void ParseInstructions_EmptyString_ReturnsEmptyList()
        {
            var result = InputParser.InputCleaner("");

            result.ShouldBeEmpty();
        }

        [Test] //result is 1 long when given single correct input
        public void ParseInstructions_SingleCorrect_ReturnsSingleResult()
        {
           
            var result2 = InputParser.InputCleaner("L");

            result2.Count.ShouldBe(1);

        }

        [Test] //result is 0 long when given incorrect input
        public void ParseInstructions_SingleIncorrect_RetunNothing()
        {
            Should.Throw<ArgumentException>(() => InputParser.InputCleaner("Z"));
        }

    }
}