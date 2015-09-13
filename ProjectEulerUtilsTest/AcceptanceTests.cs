using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;

namespace ProjectEulerUtilsTest {
    [TestClass]
    public class AcceptanceTests {
        [TestMethod]
        public void ShouldGenerateFibbonacciSequence() {
            CollectionAssert.AreEqual(new List<int>() { 1, 1, 2, 3, 5 }, PEUtils.fibSeq.Take(5).ToList());
            CollectionAssert.AreEqual(new List<int>() { 1, 1, 2, 3, 5 }, PEUtils.firstNFibs(5).ToList());
            CollectionAssert.AreEqual(First20ElementsOfFibonacciSequence(), PEUtils.fibSeq.Take(20).ToList());
            CollectionAssert.AreEqual(First20ElementsOfFibonacciSequence(), PEUtils.firstNFibs(20).ToList());
        }

        [TestMethod]
        public void ShouldGenerateNthFibonacciNumber() {
            for (var i = 0; i < 20; i++) {
                Assert.AreEqual(First20ElementsOfFibonacciSequence()[i], PEUtils.nthFib(i));
            }
        }

        private List<int> First20ElementsOfFibonacciSequence() {
            return new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 };
        }
    }
}
