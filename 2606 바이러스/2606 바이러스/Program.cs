var reader= new StreamReader(Console.OpenStandardInput());
var writer = new StreamWriter(Console.OpenStandardOutput());

string input = reader.ReadLine();
int N = int.Parse(input);
input = reader.ReadLine();
int M = int.Parse(input);

int[] visited = new int[101];
Queue<int> q = new Queue<int>();  
int[,] connect = new int[N + 1, N + 1];

int count = -1;

for(int i=0; i<M;i++)
{
    int[] com = Array.ConvertAll(reader.ReadLine().Split(' '),int.Parse);
    connect[com[0], com[1]] = 1;
    connect[com[1], com[0]] = 1;
}

int x = 1; //1부터 시작해야지
q.Enqueue(x);

while(q.Count > 0)
{
    x=q.Dequeue();
    if(visited[x]==0) //방문안했으면
    {
        visited[x] = 1; //방문했다고 하기 방문 == 바이러스 감염
        count++; 

    }

    for(int i=1;i<=N;i++)
    {
        if (connect[x,i]==1 && visited[i]==0) //연결된것중에 방문안한거 찾기
            q.Enqueue(i);
    }
}

writer.WriteLine(count);
writer.Flush();
