﻿using NUnit.Framework;
using Problem50;

namespace Tests.Problem50Tests
{
	[TestFixture]
	public class SolutionTests
	{
		[Test]
		public void TestProblem50Solution_ShouldReturnCorrectResult()
		{
			// Arrange
			var root = new Node('*', new Node('+', new Node(3), new Node(2)), new Node('+', new Node(4), new Node(5)));

			var expectedResult = 45;

			// Act
			var result = Program.Evaluate(root);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}
	}
}
