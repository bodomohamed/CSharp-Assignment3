using System.Runtime.InteropServices;

namespace Assignment3;
internal class Program
{
    static void Main(string[] args)
    {
        #region Q01
        double[] prices = { 25.5, 40.0, 33.75 };
        Console.WriteLine($"The second price is: {prices[1]}");
        #endregion

        #region Q02
        int[,] shelfCopies =
        {
            { 3, 5 },
            { 1, 4 }
        };

        Console.WriteLine(shelfCopies[1, 0]);
        #endregion

        #region Q03
        PrintWelcomeMessage();
        #endregion

        #region Q04
        PrintBookTitle("Clean Code");
        #endregion

        #region Q05
        AddBonusPages(400);
        // 400 because the pages variable is passed by value, so the original value remains unchanged.
        #endregion

        #region Q06
        double[] bookPrices = { 25.5, 40.0 };
        ApplyDiscount(bookPrices);
        Console.WriteLine($"The first price after calling ApplyDiscount is: {bookPrices[0]}");
        #endregion

        #region Q07
        int pages = 400;
        AddBonusPagesByRef(ref pages);
        Console.WriteLine($"The number of pages after adding bonus pages is: {pages}");
        // 450 because the pages variable is passed by reference, so the original value is modified.
        #endregion

        #region Q08
        //double[] bookPrices = { 25.5, 40.0 }; already declared in Q06
        ReplaceArray(ref bookPrices);
        Console.WriteLine($"The length of the array after replacement is: {bookPrices.Length}");
        #endregion

        #region Q09
        if (TryGetPrice("Clean Code", out double price))
        {
            Console.WriteLine(price);
        }
        #endregion

        #region Q10
        PrintBookInfo("Clean Code");
        PrintBookInfo("The Pragmatic Programmer", 400);
        #endregion

        #region Q11
        PrintBookInfo(pages: 450, title: "Clean Code");
        #endregion

        #region Q12
        PrintAllTitles("Clean Code", "Java Basics", "The Pragmatic Programmer");
        #endregion

    }
    #region Q03
    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Library!");
        return;
    }
    #endregion

    #region Q04
    static void PrintBookTitle(string title)
    {
        Console.WriteLine("Book title: " + title);
        return;
    }
    #endregion

    #region Q05
    static void AddBonusPages(int pages)
    {
        pages += 50;
        return;
    }
    #endregion

    #region Q06
    static void ApplyDiscount(double[] prices)
    {
        prices[0] -= 5.0;
        return;
    }
    #endregion

    #region Q07
    static void AddBonusPagesByRef(ref int pages)
    {
        pages += 50;
        return;
    }
    #endregion

    #region Q08
    static void ReplaceArray(ref double[] prices)
    {
        prices = new double[] { 10.0, 12.5, 15.0 };
        return;
    }
    #endregion

    #region Q09
    static bool TryGetPrice(string title, out double price)
    {
        if (title == "Clean Code")
        {
            price = 25.5;
            return true;
        }
        else
        {
            price = 0;
            return false;
        }
    }
    #endregion

    #region Q10
    static void PrintBookInfo(string title,  int pages = 300)
    {
        Console.WriteLine($"Title: {title}, Pages: {pages}");
    }
    #endregion

    #region Q12
    static void PrintAllTitles(params string[] titles)
    {
        foreach (string title in titles)
        {
            Console.WriteLine(title);
        }
    }
    #endregion
}
