﻿using System;
using System.Diagnostics;
using NUnit.Framework;

namespace ControlDigit
{
    [TestFixture]
    public class ControlDigitExtensions_Tests
    {
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 2)]
        [TestCase(9, ExpectedResult = 9)]
        [TestCase(10, ExpectedResult = 3)]
        [TestCase(15, ExpectedResult = 8)]
        [TestCase(17, ExpectedResult = 1)]
        [TestCase(18, ExpectedResult = 0)]
        public int TestControlDigit(long x)
        {
            return x.ControlDigit();
        }

        [Test]
        public void CompareImplementations()
        {
            for (long i = 0; i < 100000; i++)
                Assert.AreEqual(i.ControlDigit(), i.ControlDigit2());
        }
    }

    [TestFixture]
    public class ControlDigit_PerformanceTests
    {
        [Test]
        public void TestControlDigitSpeed()
        {
            var count = 10000000;
            var sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
                12345678L.ControlDigit();
            Console.WriteLine("Old " + sw.Elapsed);
            sw.Restart();
            for (int i = 0; i < count; i++)
                12345678L.ControlDigit2();
            Console.WriteLine("New " + sw.Elapsed);
        }
    }
}