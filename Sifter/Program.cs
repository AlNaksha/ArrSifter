class ResPrg
{
/*  Задача:
    Программа, которая из имеющегося массива строк
    формирует новый массив из строк, 
    длина которых меньше, либо равна 3 символам.
    Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
    При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

    static private int SignCount = 3 ;

    static void Main(string[] args)
    {        
        if (args.Length==0) 
        {
                Console.WriteLine(@"Sifter.exe v0.1
    Возвращает 'слова' не длинее 3 символов.
    -h - для отображения деталей.");
        }
        else{
            // Console.WriteLine(args.Length);
            string[] NewLineWords;

            switch(args[0]){

                case "-l":
                case "-line":{
                    
                    PrintStrArr(args,1);
                    NewLineWords = TranslateWordsShortLess(args,1);
                    PrintStrArr(NewLineWords);
                    break;
                };

                case "-e":
                case "-expl":{
                    string[] LineWords = {"tray", "fur", "day", "owe", "height", "-9", "dark", "1", "chest", "pledge", "stake", "boom"};
                    PrintStrArr(LineWords);
                    NewLineWords = TranslateWordsShortLess(LineWords);
                    PrintStrArr(NewLineWords);
                    break;
                };

                case "-h":
                case "-help":
                default:{
                    Console.WriteLine(@"Sifter.exe
    Доступные флаги:
        -e -expl                            - Демонстрирует пример работы на заложенной тестовой строке.
        -h -help                            - Показать справку.
        -l -line {ряд слов через пробел}    - Передача своего ряда слов.");
                    break;
                }
            }
        }
    }

    static int CountWordsLengthOf( string[] Words , int firstword = 0 ) // ф-я подсчета слов короче SignCount
    {
        int Count = 0;
        for( int i = firstword; i < Words.Length; i++)
        {
            if ( Words[i].Length < SignCount + 1 )
            {
                Count++;
            }
        }
        return Count;
    }

    static string[] TranslateWordsShortLess( string[] Words , int firstword = 0 ) // ф-я перезаписи в новый массив слов короче SignCount
    {
        int count = CountWordsLengthOf(Words, firstword);
        string[] NewLineWords = new string[count];

        count = 0;
        for (int i = firstword; i < Words.Length; i++)
        {
            if(Words[i].Length < SignCount+1)
            {
                NewLineWords[count] = Words[i];
                count++;
            } 
        }

        return NewLineWords;
    }

    static void PrintStrArr( string[] LineWords , int cur = 0)
    {
        for( int i = cur; i < LineWords.Length; i++)
        {
            Console.Write($"{LineWords[i]} ");    
        }
        Console.WriteLine();
    }
}