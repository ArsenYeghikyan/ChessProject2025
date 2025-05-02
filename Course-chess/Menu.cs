using ChessCoordinades;

namespace ConsoleApp9;

internal static class Menu
{
 private static ChessBoard board = new ChessBoard();

    public static void RunChessMenu()
    {
        bool flag = true;
        do
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The new game has started!");
            Console.WriteLine("Enter two coordinates in chess format (e.g., A1, H8):");
            Console.WriteLine("First — starting position, then — target position.");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Start (e.g., A2): ");
            string coord1 = Console.ReadLine();
            Coordinates point1 = new Coordinates(coord1);
            Console.Write("End   (e.g., A4): ");
            string coord2 = Console.ReadLine();
            Console.ResetColor();
            Coordinates point2 = new Coordinates(coord2);

            Console.ResetColor();
            if (point1.GetColumnIndex() < 0 || point1.GetRowIndex() < 0 || point1.GetColumnIndex() > 7 || point1.GetRowIndex() > 7 ||
                point2.GetColumnIndex() < 0 || point2.GetRowIndex() < 0 || point2.GetColumnIndex() > 7 || point2.GetRowIndex() > 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect coordinates!!! Please, enter correct coordinates in chess format (e.g., A1, H8):");
                Console.ResetColor();
                return;
            }
            board.BuildChessBoard(point1, point2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("If you want to exit the menu, type \"Exit\" or type \"Start\" to continue");

            Console.ResetColor();
            string? button = Console.ReadLine();          
            if (button == null || button.Equals("Exit") || !button.Equals("Start"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game Over!");
                flag = false;
                Console.ResetColor();
            }
        } while (flag);
    }
}

