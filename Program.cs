using System;

namespace Live;


public class GameOfLife

{

    int[,] Field = new int[25, 25];


    public static int Neighbours { get; set; }
    public static int Cell { get; set; }
    public static int numberOfCells = 625;


    private static int ConditionsOfTheGame()
    {
        if ((Neighbours > 3) || (Neighbours < 2))
            Cell = 0;

        else if ((Neighbours <= 3) || (Neighbours > 2))
            Cell = 1;

        return Cell;
    }


    static void Main(string[] args)

    {


    }


}








