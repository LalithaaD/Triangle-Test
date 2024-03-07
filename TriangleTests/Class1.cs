using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleTests
    {
    [TestFixture]
    public class TriangleTests
        {
        // Valid Equilateral Triangle
        // Only one (1) test for a valid equilateral triangle
        [Test]
        public void ValidEquilateralTriangle_Input5_OutputValidEquilateral()
            {
            // Arrange
            int side = 5;
            // Act
            string result = Triangle.AnalyzeTriangle(side, side, side);
            // Assert
            Assert.AreEqual("Equilateral triangle", result);
            }
        
    }


