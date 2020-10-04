Module Module1
    Using System.Globalization;

    Namespace trainning {
    Class program {
        Static void Main(String [args]) {
            
        Double x = 10.35784;

        Console.WriteLine(x)
        Console.WriteLine(x.ToString("F2"));
        Console.Writeline(x.ToString("F4"));

        Console.Writeline(x.ToString("F2", CultureInfo.InvariantCulture));


        Console.ReadLine (); 

    End Namespace

End Module
