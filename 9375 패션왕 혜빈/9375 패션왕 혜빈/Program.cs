using System.ComponentModel.Design;

var reader = new StreamReader(Console.OpenStandardInput());
var writer = new StreamWriter(Console.OpenStandardOutput());

string input = reader.ReadLine();

int test = int.Parse(input);


for(int i=0; i<test; i++)
{
    Dictionary<string, int> dic = new Dictionary<string, int>();
    input = reader.ReadLine();
    int n = int.Parse(input);
    for(int j=0;j<n;j++)
    {
        string[] cloth =new string[2];
        cloth = reader.ReadLine().Split(" ");

        if (!dic.ContainsKey(cloth[1]))
            dic.Add(cloth[1], 1); 

        else
            dic[cloth[1]]++;   
    }

    int result = 1;

    foreach (var c in dic.Values)
        result *= (c + 1);

    writer.WriteLine(result-1);


}

writer.Flush();