using System.Text.Json.Serialization.Metadata;

var reader = new StreamReader(Console.OpenStandardInput());
var writer = new StreamWriter(Console.OpenStandardOutput());

string[] number = reader.ReadLine().Split();
int N =int.Parse(number[0]);
int M=int.Parse(number[1]);
Dictionary<string , int> dic = new Dictionary<string , int>();  
Dictionary<int, string> reverseDic= new Dictionary<int, string>();

for(int i=1;i<=N;i++)
{
    string name = reader.ReadLine();
    dic[name] = i;
    reverseDic[i]= name;
}

for(int i=1;i<=M;i++)
{
    string check = reader.ReadLine();
    int num = 0;
    if (int.TryParse(check, out num))
        writer.WriteLine(reverseDic[num]);
    else
        writer.WriteLine(dic[check]);
       
}
writer.Flush();