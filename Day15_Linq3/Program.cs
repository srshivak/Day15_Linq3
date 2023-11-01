// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Tracing;
using Day15_Linq3;

Console.WriteLine("Enter SizeOfArr");
int SizeOfArr = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[SizeOfArr];

for (int i = 0; i < SizeOfArr; i++)
{
    Console.WriteLine("enter a word");
    arr[i] = Console.ReadLine();
}

/*Console.WriteLine("arr is");
 
foreach (string str in arr)
 
{
    Console.WriteLine(str);
}*/

Console.WriteLine("removing somebody and nobody");
var result = arr.Where(e => e != "nobody" && e != "somebody");
foreach (var i in result)
{
    Console.WriteLine(i);
}

var result2 = from e in arr
              where e != "nobody" && e != "somebody"
              select e;
foreach (var i in result2)
{
    Console.WriteLine(i);
}
