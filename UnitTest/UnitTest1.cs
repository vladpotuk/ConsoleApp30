using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTests
{
    [TestMethod]
    public void TestMultiplyNumbersInRange()
    {
        // Arrange
        int startRange = 2;
        int endRange = 4;
        int expected = 2 * 3 * 4;

        // Act
        int result = MathOperations.MultiplyNumbersInRange(startRange, endRange);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestIsFibonacciNumber()
    {
        // Arrange
        int fibonacciNumber = 5;
        int nonFibonacciNumber = 8;

        // Act
        bool isFibonacciResult = FibonacciChecker.IsFibonacciNumber(fibonacciNumber);
        bool isNonFibonacciResult = FibonacciChecker.IsFibonacciNumber(nonFibonacciNumber);

        // Assert
        Assert.IsTrue(isFibonacciResult);
        Assert.IsFalse(isNonFibonacciResult);
    }

    [TestMethod]
    public void TestSortArray()
    {
        // Arrange
        int[] originalArray = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
        int[] ascendingSortedArray = { 1, 1, 2, 3, 3, 4, 5, 5, 5, 6, 9 };
        int[] descendingSortedArray = { 9, 6, 5, 5, 5, 4, 3, 3, 2, 1, 1 };

        // Act
        int[] ascendingResult = ArraySorter.SortArray(originalArray, true);
        int[] descendingResult = ArraySorter.SortArray(originalArray, false);

        // Assert
        CollectionAssert.AreEqual(ascendingSortedArray, ascendingResult);
        CollectionAssert.AreEqual(descendingSortedArray, descendingResult);
    }
}
