
var reader = new StreamReader(Console.OpenStandardInput());
var writer = new StreamWriter(Console.OpenStandardOutput());

string[] input = reader.ReadLine().Split(" ");

int N= int.Parse(input[0]);
int M= int.Parse(input[1]);

int[] answer = new int[N + 1];
answer[0] = 0;
string[] nums = reader.ReadLine().Split(" ");
for (int i = 1; i <=N; i++)
{
    answer[i] =answer[i - 1]+int.Parse(nums[i-1]);
}

for(int i=0;i<M;i++)
{
    string[] range = reader.ReadLine().Split(" ");
    int start = int.Parse(range[0]);
    int last= int.Parse(range[1]);

    int sum = answer[last]-answer[start-1];
    writer.WriteLine(sum);
}


writer.Flush();