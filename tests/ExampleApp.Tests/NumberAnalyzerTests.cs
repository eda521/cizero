using System;
using System.Collections.Generic;
using Xunit;
using ExampleApp;

namespace ExampleApp.Tests
{
    public class NumberAnalyzerTests
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(1, false)]
        [InlineData(0, false)]
        [InlineData(-7, false)]
        public void IsPrime_Works(int value, bool expected)
        {
            Assert.Equal(expected, NumberAnalyzer.IsPrime(value));
        }

        [Fact]
        public void Mean_ComputesCorrectly()
        {
            var values = new List<double> { 1, 2, 3, 4 };
            Assert.Equal(2.5, NumberAnalyzer.Mean(values));
        }

        [Fact]
        public void Median_OddCount()
        {
            var values = new List<double> { 5, 1, 3 };
            Assert.Equal(3, NumberAnalyzer.Median(values));
        }

        [Fact]
        public void Median_EvenCount()
        {
            var values = new List<double> { 1, 2, 3, 4 };
            Assert.Equal(2.5, NumberAnalyzer.Median(values));
        }

        [Fact]
        public void Mean_ThrowsOnEmpty()
        {
            Assert.Throws<ArgumentException>(() => NumberAnalyzer.Mean(new List<double>()));
        }

        [Fact]
        public void Median_ThrowsOnNull()
        {
            Assert.Throws<ArgumentNullException>(() => NumberAnalyzer.Median(null!));
        }
    }
}