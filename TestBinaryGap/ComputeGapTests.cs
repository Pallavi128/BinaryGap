using BinaryGapComputation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestBinaryGap
{
    [TestClass]
    public class ComputeGapTests
    {
        private Mock<IComputeMaxZeros> _computeMaxZerosAction;

        [TestInitialize]
        public void Init() {
            _computeMaxZerosAction = new Mock<IComputeMaxZeros>();
            _computeMaxZerosAction.Setup(gap => gap.MaxZeros(It.IsAny<int>())).Returns(It.IsAny<int>());
        }

        [TestMethod]
        public void ComputeGapForNumberContainingOneBinaryGap()
        {
            var n = 9;
            var binaryGap = ComputeBinaryGap(n);
            Assert.AreEqual(2, binaryGap);

        }

        private static int ComputeBinaryGap(int n)
        {
            var _computeMaxZerosAction = new Mock<IComputeMaxZeros>();
            var binaryGap = _computeMaxZerosAction.Object.MaxZeros(n);
            return binaryGap;
        }

        [TestMethod]
        public void ComputeGapForNumberContainingTwoBinaryGaps()
        {
            var n = 529;
            var binaryGap = ComputeBinaryGap(n);
            Assert.AreEqual(4, binaryGap);
        }
        
        [TestMethod]
        public void ComputeGapForNumberContainingNoBinaryGapSinceBinaryRepresentationsContainsOnlyOnes()
        {
            var n = 15;
            var binaryGap = ComputeBinaryGap(n);
            Assert.AreEqual(0, binaryGap);
        }
     
        [TestMethod]
        public void ComputeGapForNumberContainingNoBinaryGapSinceBinaryRepresentationsContainsOnlySingleOne()
        {
            var n = 32;
            var binaryGap = ComputeBinaryGap(n);
            Assert.AreEqual(0, binaryGap);
        }
    }
}