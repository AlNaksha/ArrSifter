class ResPrg
{

    static void Main(string[] args)
    {        
        if (args.Length==0) 
        {
                Console.WriteLine(@"Sifter.exe v0.1
    Возвращает 'слова' не длинее 3 символов.
    -h - для отображения деталей.");
        }
        else{
            ResPrg cur = new ResPrg();
            // Console.WriteLine(args.Length);
            switch(args[0]){
                case "-line":{
                    //Task25();
                    Console.WriteLine(args[1]);
                    break;
                };
                case "-expl":{
                    cur.Expl();
                    break;
                };
                case "-help":
                default:{
                    Console.WriteLine(@"Sifter.exe
    Доступные флаги:
        -expl                           - Демонстрирует пример работы на заложенной тестовой строке.
        -help                           - Показать справку.
        -line {ряд слов через пробел}   - Передача своего ряда слов.");
                    break;
                }
            }
        }
    }

    void Expl( string LineWords = "tray fur day owe height -9 dark 1 chest pledge stake boom" )
    {
        Console.WriteLine(LineWords);
    }
}
