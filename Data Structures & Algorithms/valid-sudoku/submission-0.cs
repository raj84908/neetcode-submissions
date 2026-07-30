
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool RowSearchVal = RowSearch(board);
        bool ColSearchVal = ColumnSearch(board);
        bool BoxSearchVal = BoxSearch(board);

        return RowSearchVal && ColSearchVal && BoxSearchVal;
    }

    public bool RowSearch(char[][] board)
    {
       HashSet<int> HashValues = new HashSet<int>();
       for(int row = 0; row < board.Length; row++)
       {
        for(int col = 0; col < board[row].Length; col++)
        {
            // 1. CHECK FOR '.' FIRST: Skip it immediately before looking at numbers
            if (board[row][col] == '.') 
            {
                continue;
            }

            int value = (int)char.GetNumericValue(board[row][col]);
            if(value >= 1 && value <= 9)
            {
                if(!HashValues.Contains(value))
                {
                    HashValues.Add(value);
                }
                else
                {
                    return false;
                }
            }
            else {
                return false;
            }
        }
        HashValues.Clear();
       }
       return true;
    }

    public bool ColumnSearch(char[][] board)
    {
       HashSet<int> HashValues = new HashSet<int>();
       for(int col = 0; col < board.Length; col++)
       {
        for(int row = 0; row < board.Length; row++)
        {
            // 1. CHECK FOR '.' FIRST: Skip it immediately before looking at numbers
            if (board[row][col] == '.') 
            {
                continue;
            }

            int value = (int)char.GetNumericValue(board[row][col]);
            if(value >= 1 && value <= 9)
            {
                if(!HashValues.Contains(value))
                {
                    HashValues.Add(value);
                }
                else
                {
                    return false;
                }
            }
            else {
                return false;
            }
        }
        HashValues.Clear();
       }
       return true;
    }

    public bool BoxSearch(char[][] board)
    {
        HashSet<int> HashValues = new HashSet<int>();
        // FIX: boxRow and boxCol must both increment by += 3 to properly step through the 9 boxes
        for (int boxRow = 0; boxRow < 9; boxRow += 3)
        {
            for (int boxCol = 0; boxCol < 9; boxCol += 3)
            {
                for(int row = 0; row < 3; row++)
                {
                    for(int col = 0; col < 3; col++)
                    {
                        int ActualRow = row + boxRow;
                        int ActualCol = col + boxCol;

                        // 1. CHECK FOR '.' FIRST: Skip it immediately before looking at numbers
                        if (board[ActualRow][ActualCol] == '.') 
                        {
                            continue;
                        }

                        int value = (int)char.GetNumericValue(board[ActualRow][ActualCol]);
                        if(value >= 1 && value <= 9)
                        {
                            if(!HashValues.Contains(value))
                            {
                                HashValues.Add(value);
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else {
                            return false;
                        }
                    }
                }
                // Clear hash set after validating one full 3x3 block
                HashValues.Clear();
            }
        }
        return true;
    }
}
