namespace Astrana.Core.Extensions
{
    public static class PaginationExtensions
    {
        public static long CalculateLastPage(this long resultSetCount, long pageSize)
        {
            if (resultSetCount < 1)
                return 1;

            return (long)Math.Ceiling(resultSetCount / (decimal)pageSize);
        }

        public static long CalculatePreviousPage(this long currentPage)
        {
            return currentPage < 2 ? 1 : currentPage - 1;
        }

        public static long CalculateNextPage(this long currentPage, long pageSize, long resultSetCount)
        {
            long nextPage = currentPage < 1 ? 2 : currentPage + 1;

            var lastPage = resultSetCount.CalculateLastPage(pageSize);

            if (nextPage > lastPage)
                nextPage = lastPage;

            return nextPage;
        }

        public static int CalculateLastPage(this int resultSetCount, int pageSize)
        {
            return (int)((long)resultSetCount).CalculateLastPage(pageSize);
        }

        public static int CalculatePreviousPage(this int currentPage)
        {
            return (int)((long)currentPage).CalculatePreviousPage();
        }

        public static int CalculateNextPage(this int currentPage, int pageSize, int resultSetCount)
        {
            return (int)((long)currentPage).CalculateNextPage(pageSize, resultSetCount);
        }
    }
}
