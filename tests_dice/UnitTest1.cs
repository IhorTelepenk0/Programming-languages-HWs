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

            theDice.result.Should().Be(1);
        }

    }
}
