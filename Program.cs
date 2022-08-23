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