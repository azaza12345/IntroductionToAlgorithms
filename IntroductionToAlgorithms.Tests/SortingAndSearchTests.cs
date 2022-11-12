using System;
using SortingAndSearchAlgorithms;

namespace IntroductionToAlgorithms.Tests
{
    public class SortingAndSearchTests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3}, 3, 2)]
        [InlineData(new[] { 1, 7, 8}, 1, 0)]
        [InlineData(new[] { 1, 2, 3}, 5, -1)]
        [InlineData(new[] { 2, 4, 5, 11}, 5, 2)]
        [InlineData(new[] { 2, 4, 5, 11}, 4, 1)]
        [InlineData(new[] { 1, 5, 8, 9, 12}, 12, 4)]
        public void IterativeBinarySearchTest(int[] array, int target, int result)
        {
            // Arrange
            
            // Act
            var value = BinarySearch.IterativeSolution(array, target);
            
            // Assert
            Assert.Equal(result, value);
        }
        
        [Theory]
        [InlineData(new[] { 1, 2, 3}, 3, 2)]
        [InlineData(new[] { 1, 7, 8}, 1, 0)]
        [InlineData(new[] { 1, 2, 3}, 5, -1)]
        [InlineData(new[] { 2, 4, 5, 11}, 5, 2)]
        [InlineData(new[] { 2, 4, 5, 11}, 4, 1)]
        [InlineData(new[] { 1, 5, 8, 9, 12}, 12, 4)]
        public void RecursiveBinarySearchTest(int[] array, int target, int result)
        {
            // Arrange
            
            // Act
            var value = BinarySearch.RecursiveSolution(array, target);
            
            // Assert
            Assert.Equal(result, value);
        }
        
        [Theory]
        [InlineData(new[] { 5, 4}, new[] {4, 5})]
        [InlineData(new[] { 12, 5, 7}, new[] {5, 7, 12})]
        [InlineData(new[] { 0, 1, -1}, new[] {-1, 0, 1})]
        [InlineData(new[] { 2, 1, 4, 3}, new[] {1, 2, 3, 4})]
        [InlineData(new[] { 9, 8, 7, 6, 5}, new[] {5, 6, 7, 8, 9})]
        public void SelectionSortTest(int[] array, int[] result)
        {
            // Arrange
            
            // Act
            SelectionSort.Solution(array);
            
            // Assert
            Assert.Equal(result, array);
        }
        
        [Theory]
        [InlineData(new[] { 5, 4}, new[] {4, 5})]
        [InlineData(new[] { 12, 5, 7}, new[] {5, 7, 12})]
        [InlineData(new[] { 0, 1, -1}, new[] {-1, 0, 1})]
        [InlineData(new[] { 2, 1, 4, 3}, new[] {1, 2, 3, 4})]
        [InlineData(new[] { 9, 8, 7, 6, 5}, new[] {5, 6, 7, 8, 9})]
        public void InsertionSortTest(int[] array, int[] result)
        {
            // Arrange
            
            // Act
            InsertionSort.Solution(array);
            
            // Assert
            Assert.Equal(result, array);
        }
    }
}