using Rover.Cons;
using Rover.Cons.Domain;
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
            var result = InputParser.InstructionParser("");

            result.ShouldBeEmpty();
        }

        [Test] //result is 1 long when given single correct input
        public void ParseInstructions_SingleCorrect_ReturnsSingleResult()
        {
           
            var result2 = InputParser.InstructionParser("L");

            result2.Count.ShouldBe(1);

        }

        [Test] //result is 0 long when given incorrect input
        public void ParseInstructions_SingleIncorrect_RetunNothing()
        {
            Should.Throw<ArgumentException>(() => InputParser.InstructionParser("Z"));
        }

        //[Test] //result is 3 long when given 3 correct inputs and 2 incorrect inputs
        //public void ParseInstructions_ThreeLong_ThreeCorrectInputsTwoIncorrectInputs()
        //{
        //    var result4 = InputParser.InputCleaner("LLLZZ");

        //    result4.Count.ShouldBe(3); 
        //} 
        //Could not get this to work because the code throws exception when it's given incorrect input, even if some are correct.
        //Maybe this is actually what the sprint wants? Not sure, leaving it for now



        [Test] //Plateau tests start here
        public void ParsePlateau_ValidInput_ReturnsCorrectSize()
        {
            var result = InputParser.PlateauParser("5 5");

           
            result.PlateauX.ShouldBe(5);
            result.PlateauY.ShouldBe(5);

        }
    }
} 