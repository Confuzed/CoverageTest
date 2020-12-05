namespace CoverageTestLib.Test
{
    using System;
    using Shouldly;
    using Xunit;

    using CoverageTestLib;

    public class UnitTest1
    {
        [Fact]
        public void Value_is_properly_initialized()
        {
            var subject = new CoverageTest("bob");

            subject.Value.ShouldBe("bob");
        }
    }
}
