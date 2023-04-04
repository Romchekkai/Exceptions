



using System.Security.Cryptography;

class IsNumberException: FormatException
{
    public int Value { get; }
    public IsNumberException(string message, int value) : base(message)

    {
        Value = value;

    }

}

public delegate void SortSirNamesArray(int op, string[] surname);
public class SortSurname
{
    public event SortSirNamesArray Notify;
    public string[] surnames;

    public int SelectedOperation;

    public SortSurname(string[] ss )
    {
        surnames =ss;

    }
     public void Dooperation()
    {
        Console.WriteLine("Sorted from Я to А");
        Notify(SelectedOperation, surnames);


    }
  








}


class Program

{




    public static void Main(string[] args)
    {
        string[] SurName = { "Сиянов", "Салко", "Елешев", "Талызина", "Яйцов" };
        SortSurname fssort = new SortSurname(SurName);




        try

        {
            Console.WriteLine("choose kind of operation press 1 to sort: А to Я; press 2 to sort: Я to А ");
            fssort.SelectedOperation = Convert.ToInt32(Console.ReadLine());
            if (fssort.SelectedOperation != 1 && fssort.SelectedOperation != 2) { throw new IsNumberException("You must choose 1 or 2", fssort.SelectedOperation); }
            fssort.Notify += SortSurnames;
            fssort.Dooperation();
        }
        catch (IsNumberException e)
        {

            Console.Write(e.Message);
            Console.WriteLine(e.Value);
        }
        catch (Exception e) { Console.WriteLine(e.Message); }








    }





    public static void SortSurnames(int SelectedOperation, string[] surmanes)
    {
        if (SelectedOperation == 1) { Array.Sort(surmanes); foreach (string s in surmanes) { Console.WriteLine(s); } }
        else if (SelectedOperation == 2) { Array.Sort(surmanes); Array.Reverse(surmanes); foreach (string s in surmanes) { Console.WriteLine(s); } }



    }
} 

        


    




/*
 
 
 
 
 int numbers = 1;
        Exception[] exceptions = new Exception[5];
        exceptions[0] = new IsNumberException("Entered incorrect value", numbers);
        exceptions[1] = new FormatException();
        exceptions[2] = new ArgumentException();
        exceptions[3] = new ArgumentOutOfRangeException();
        exceptions[4] = new Exception();

        try { Console.WriteLine(); }
        catch (exceptions[i] ex) { Console.WriteLine(ex.); }
 
 
 
  */
