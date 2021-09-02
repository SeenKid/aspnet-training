using System;

class Program {

    static void Main(string[] args) {

        int result = 0;

        result = result + 5;

        // Console.WriteLine(++result); // 6
        /* le ++ est avant le result, donc il est incrémenté */ 

        Console.WriteLine(result++); // 5
        Console.WriteLine(result); // 6
        /* le ++ est après le premier result, le prochain sera incrémenté
        donc le result suivant sera 6 */ 
    }
}