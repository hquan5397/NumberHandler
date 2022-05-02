using NumberHandler.Core.Interfaces;

namespace NumberHandler.ApplicationLogic
{
    public class NumberSortingHandler : INumberSortingHandler
    {
        public Task<List<int>> MoveLargestNumbersToCenterAsync(List<int> numbers, int numberOfLargestNumberes)
        {

            int length = numbers.Count;

            int centerPostition = (length - 1) / 2;

            numbers.Sort();

            var largerstNumberList = numbers.GetRange(length - numberOfLargestNumberes, numberOfLargestNumberes);

            numbers.InsertRange(centerPostition - numberOfLargestNumberes / 2, largerstNumberList);

            int newLength = numbers.Count;

            numbers.RemoveRange(newLength - numberOfLargestNumberes, numberOfLargestNumberes);

            return Task.FromResult(numbers);
        }
    }
}
