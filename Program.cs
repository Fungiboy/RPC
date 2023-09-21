using System;
using System.Collections.Generic;

/*    
"AX" = 3;
"AY" = 4;
"AZ" = 8;

"BX" = 1;
"BY" = 5;
"BZ" = 9;

"CX" = 2;
"CY" = 6;
"CZ" = 7;
*/

int points = 0;
string[] lista = File.ReadAllLines("../../../DATA.txt");

for (int i = 0; i <= lista.Length - 1; i++)
{
    var converted = lista[i].Replace(" ", "");

    if (converted == "AX")
    {
        points += 3;
    }
    if (converted == "AY")
    {
        points += 4;
    }
    if (converted == "AZ")
    {
        points += 8;
    }
    if (converted == "BX")
    {
        points += 1;
    }
    if (converted == "BY")
    {
        points += 5;
    }
    if (converted == "BZ")
    {
        points += 9;
    }
    if (converted == "CX")
    {
        points += 2;
    }
    if (converted == "CY")
    {
        points += 6;
    }
    if (converted == "CZ")
    {
        points += 7;
    }
}
Console.Write(points);



/*

IDictionary<string, int> numberNames = new Dictionary<string, int>();
numberNames.Add("A", 1);
numberNames.Add("B", 2);
numberNames.Add("C", 3);
numberNames.Add("X", 0);
numberNames.Add("Y", 3);
numberNames.Add("Z", 6);

for (int i = 0; i < lista.Length; i++)
{
    
    var converted = lista[i].Replace(" ", "");
    Console.Write(converted);
}

Console.Write(numberNames["B"]);

*/