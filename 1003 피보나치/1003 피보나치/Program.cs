
string count = Console.ReadLine();
if (count == null)
{
    Console.WriteLine("입력한게 null");
    return;
}
   
int num_count =int.Parse(count);
int[] fibo_Zero = new int[41];
int[] fibo_One = new int[41];

fibo_Zero[0] = 1;
fibo_One[0] = 0;
fibo_Zero[1] = 0;
fibo_One[1] = 1;

for (int k = 2; k < 41; k++)
{
    fibo_Zero[k] = fibo_Zero[k - 1] + fibo_Zero[k - 2];
    fibo_One[k] = fibo_One[k - 1] + fibo_One[k - 2];
}


for (int i=0;i<num_count;i++)
{
    string input = Console.ReadLine();
    if (input == null)
    {
        Console.WriteLine("입력한게 null");
        return;
    }
    int input_int = int.Parse(input);

    Console.WriteLine("{0} {1}", fibo_Zero[input_int], fibo_One[input_int]); // 쉼표잇다고 틀림
}







