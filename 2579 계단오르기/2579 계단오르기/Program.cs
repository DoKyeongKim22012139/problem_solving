var reader = new StreamReader(Console.OpenStandardInput());
var writer = new StreamWriter(Console.OpenStandardOutput());

string input = reader.ReadLine();
int n= int.Parse(input);
int[] stair = new int[n+1];
int[] dp = new int[n+1];

stair[0] = 0;
for(int i=1; i<=n;i++)
{
    input = reader.ReadLine();
    stair[i] = int.Parse(input);
}
dp[0] = 0;
dp[1] = stair[1];
if(n>=2)
    dp[2] = (int)MathF.Max(stair[1] + stair[2], stair[2]);

for (int i=3;i<=n;i++)
{
    dp[i] = (int)MathF.Max(dp[i-2] + stair[i], dp[i-3] + stair[i - 1] + stair[i]);
}

writer.WriteLine(dp[n]);
writer.Flush();