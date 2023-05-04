public class DiagonalMatrix
{
    public int[] FindDiagonalOrder(int[,] mat)
    {
        var rowsCount = mat.GetLength(0);
        var columnsCount = mat.GetLength(1);
        var result = new int[rowsCount * columnsCount];

        var headings = GetDiagonalHeadings(rowsCount, columnsCount);

        var index = 0;
        for (int k = 0; k < headings.GetLength(0); k++)
        {
            var items = new List<int>();
            int i = headings[k, 0];
            int j = headings[k, 1];

            if (i == 0 && j == 0)
            {
                result[index++] = mat[i, j];
                continue;
            }
            else if (i == rowsCount - 1 && j == columnsCount - 1)
            {
                result[index++] = mat[i, j];
                continue;
            }

            for (int n = j; n >= 0 && i < rowsCount; n--)
            {
                items.Add(mat[i, n]);
                i += 1;
            }

            if (k % 2 == 0)
                items.Reverse();

            foreach (var item in items)
                result[index++] = item;
        }

        return result;
    }

    private int[,] GetDiagonalHeadings(int rowsCount, int columnsCount)
    {
        var headings = new int[rowsCount + columnsCount - 1, 2];
        int diagonalCounts = 0;

        for (int i = 0; i < columnsCount; i++)
        {
            headings[diagonalCounts, 0] = 0;
            headings[diagonalCounts, 1] = i;
            diagonalCounts += 1;
        }

        for (int i = 1; i < rowsCount; i++)
        {
            headings[diagonalCounts, 0] = i;
            headings[diagonalCounts, 1] = rowsCount - 1;
            diagonalCounts += 1;
        }

        return headings;
    }
}