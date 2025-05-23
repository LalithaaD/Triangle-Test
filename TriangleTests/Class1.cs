﻿using System;
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
    
        // Valid Isosceles Triangles
        // Three (3) tests for a valid isosceles triangle
        [Test]
        public void ValidIsoscelesTriangle_Input5and5and7_OutputValidIsosceles1()
            {
            // Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 7;
            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            // Assert
            Assert.AreEqual("Isosceles triangle", result);
            }
        [Test]
        public void ValidIsoscelesTriangle_Input7and5and5_OutputValidIsosceles2()
            {
            // Arrange
            int side1 = 7;
            int side2 = 5;
            int side3 = 5;
            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            // Assert
            Assert.AreEqual("Isosceles triangle", result);
            }
        [Test]
        public void ValidIsoscelesTriangle_Input5and7and5_OutputValidIsosceles3()
            {
            // Arrange
            int side1 = 5;
            int side2 = 7;
            int side3 = 5;
            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            // Assert
            Assert.AreEqual("Isosceles triangle", result);
            }
        // Valid Scalene Triangles
        // Five (5) tests for a valid scalene triangle
        [Test]
        public void ValidscaleneTriangle_Input3and4and5_OutputValidScalene1()
            {
            // Arrange
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;
            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            // Assert
            Assert.AreEqual("Scalene triangle", result);
            }
        [Test]
        public void ValidscaleneTriangle_Input8and6and10_OutputValidScalene2()
            {
            // Arrange
            int side1 = 8;
            int side2 = 6;
            int side3 = 10;
            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            // Assert
            Assert.AreEqual("Scalene triangle", result);
            }
        [Test]
        public void ValidscaleneTriangle_Input7and9and12_OutputValidScalene3()   
            {
            // Arrange
            int side1 = 7;
            int side2 = 9;
            int side3 = 12;
            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            // Assert
            Assert.AreEqual("Scalene triangle", result);
            }
        [Test]
        public void ValidscaleneTriangle_Input5and13and14_OutputValidScalene4()
            {
            // Arrange
            int side1 = 5;
            int side2 = 13;
            int side3 = 14;
            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            // Assert
            Assert.AreEqual("Scalene triangle", result);
            }
        [Test]
        public void ValidscaleneTriangle_Input15and9and12_OutputValidScalene5()
            {
            // Arrange
            int side1 = 15;
            int side2 = 9;
            int side3 = 12;
            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            // Assert
            Assert.AreEqual("Scalene triangle", result);
            }

        
        // Zero Length for One or More Sides
        // Three (3) tests for verifying a zero length for one or more sides
        [Test]
        public void ZeroLengthForSide_Input0and5and7_OutputInvalid()
            {
            // Arrange
            int side1 = 0;
            int side2 = 5;
            int side3 = 7;
            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
            }
        [Test]
        public void ZeroLengthForSide_Input4and0and6_OutputInvalid()
            {
            // Arrange
            int side1 = 4;
            int side2 = 0;
            int side3 = 6;
            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
            }
        [Test]
        public void ZeroLengthForSide_Input3and8and0_OutputInvalid()
            {
            // Arrange
            int side1 = 3;
            int side2 = 8;
            int side3 = 0;
            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
            }
        // Invalid Response (Other than Zero Length)
        // Three (3) tests for verifying an invalid response (other than a zero length)
        [Test]
        public void InvalidResponse_Input3and5and9_OutputInvalid()
            {
            // Arrange
            int side1 = 3;
            int side2 = 5;
            int side3 = 9;
            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            // Assert
            Assert.AreEqual("INVALID!!", result);
            }
        [Test]
        public void InvalidResponse_Input7and10and3_OutputInvalid()
            {
            // Arrange
            int side1 = 7;
            int side2 = 10;
            int side3 = 3;
            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            // Assert
            Assert.AreEqual("INVALID!!", result);
            }
        [Test]
        public void InvalidResponse_Input15and5and3_OutputInvalid()
            {
            // Arrange
            int side1 = 15;
            int side2 = 5;
            int side3 = 3;
            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            // Assert
            Assert.AreEqual("INVALID!!", result);
            }
        
    }

}
