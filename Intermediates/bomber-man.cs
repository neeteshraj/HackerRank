using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Solution {
    static void Main(String[] args) {
        string[] tokens = Console.ReadLine().Split(' ');
        int rows = Convert.ToInt32(tokens[0]);
        int columns = Convert.ToInt32(tokens[1]);
        int seconds = Convert.ToInt32(tokens[2]);
        List<string> steps = new List<string>();

        char[][] map = new char[rows][];
        for (int i = 0; i < rows; ++i)
        {
            map[i] = Console.ReadLine().ToCharArray();
        }

        if (seconds == 1)
        {
            DumpMap(map);

            return;
        }

        if (seconds % 2 == 0)
        {
            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < columns; ++j)
                    map[i][j] = 'O';

            DumpMap(map);

            return;
        }

        IterateMap(map);

        if (seconds % 4 == 1)
            IterateMap(map);

        DumpMap(map);
    }

    private static void IterateMap(char[][] map)
    {
        // Blow up the bombs
        for (int i = 0; i < map.Length; ++i)
        {
            for (int j = 0; j < map[i].Length; ++j)
            {
                if (map[i][j] == 'O')
                {
                    map[i][j] = ' ';
                    ClearCell(map, i - 1, j);
                    ClearCell(map, i + 1, j);
                    ClearCell(map, i, j - 1);
                    ClearCell(map, i, j + 1);
                }
            }
        }

        for (int i = 0; i < map.Length; ++i)
        {
            for (int j = 0; j < map[i].Length; ++j)
            {
                if (map[i][j] == '.')
                    map[i][j] = 'O';
                else
                    map[i][j] = '.';
            }
        }
    }

    private static void DumpMap(char[][] map)
    {
        for (int i = 0; i < map.Length; ++i)
        {
            Console.Out.WriteLine(String.Join("", map[i]));
        }
    }

    private static void ClearCell(char[][] map,int r,int c)
    {
        if (r < 0) return;
        if (r >= map.Length) return;
        if (c < 0) return;
        if (c >= map[r].Length) return;
        if (map[r][c] == 'O') return;
        map[r][c] = ' ';
    }
}
