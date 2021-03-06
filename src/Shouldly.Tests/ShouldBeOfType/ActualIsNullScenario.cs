﻿using Shouldly.Tests.TestHelpers;

namespace Shouldly.Tests.ShouldBeOfType
{
    public class ActualIsNullScenario : ShouldlyShouldFailureTestScenario
    {
        protected override void ShouldThrowAWobbly()
        {
            MyThing myThing = null;
            // ReSharper disable once ExpressionIsAlwaysNull
            myThing.ShouldBeOfType<MyBase>();
        }

        protected override string ChuckedAWobblyErrorMessage
        {
            get { return "myThing should be of type Shouldly.Tests.TestHelpers.MyBase but was null"; }
        }
    }
}