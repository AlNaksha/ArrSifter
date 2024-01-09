void defaultFunct()
{

}

class TestClass
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine(args.Length);
        int ntask = Convert.ToInt32(Console.ReadLine());
        switch(ntask){
            case "-l":{
                Task25();
                break;
            };
            case 27:{
                Task27();
                break;
            };
            case 29:{
                Task29();
                break;
            };
            default:{
                defaultFunct();
                break;
            };
        }
  }
}
