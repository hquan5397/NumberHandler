namespace NumberHandler.Core.Interfaces
{
    public interface INumberSortingHandler
    {
        Task<List<int>> MoveLargestNumbersToCenterAsync(List<int> numbers, int numberOfLargestNumberes);
    }
}
