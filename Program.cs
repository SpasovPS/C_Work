string[] array;
int count;
string str;
string[] array2;
Console.WriteLine("Enter string:");
count = 0;
array = new string[count];
do 
{str = Console.ReadLine();
    if (str!="")
    {
        count++; 
        array2 = new string[count];
        for (int i = 0; i < array2.Length - 1; i++)
        array2[i] = array[i];
        array2[count - 1] = str;
        array = array2;
    }
} 
while (str !="");
string[] result = new string[array.Length];
count = 0;
foreach (string? value in array)
{
    if (value.Length <=3)
    {
        result[count] = value;
        count++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, count));