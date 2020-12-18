using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace DiceTesting
{
    public class DiceTests
    {
        [Fact]

        public void Can_Create_Dice()
        {
            var theDice = new Dices.Dice();

            theDice.result.Should().Be(0);
            
        }

        [Fact]

        public void if_Roll_Dice()
        {
            var theDice = new Dices.Dice();

            theDice.Roll();

            theDice.result.Should().BeLessThan(7);
        }

        [Fact]

        public void if_Roll_One()
        {
            var theDice = new Dices.Dice();
            theDice.RollOne();

            theDice.result.Should().Be(1);
        }

        [Fact]

        public void Taken_off()
        {
            var theDice = new Dices.Dice();

            theDice.TakeOff();

            theDice.result.Should().Be(0);
        }
    }
}
