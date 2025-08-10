using System.Diagnostics;
using System.Text;

var reader = new StreamReader(new BufferedStream(Console.OpenStandardInput())); // 이게 콘솔.write랑 다르게 한번에 저장했다가 한번에 푸는거래

var writer = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())); //콘솔은 하나 하고 플러쉬하고 반복하는데

string[] input = reader.ReadLine().Split();
int x = int.Parse(input[0]);
int y = int.Parse(input[1]);



int[,] map = new int[x,y];
int[,] path = new int[x, y];
bool[,] isvisit = new bool[x, y]; 
Queue<(int, int)> queue = new Queue<(int , int)>();



int[] dr = { -1, 1, 0, 0 };
int[] dc = { 0, 0, -1, 1 };
for (int i=0; i<x;i++)
{
    var parts = reader.ReadLine().Split();
    for (int k=0;k<y;k++)
    {
        map[i,k]= int.Parse(parts[k]);
        path[i, k] = -1;
        if (map[i, k] == 2)
        {
            queue.Enqueue((i, k));
            path[i, k] = 0;
            isvisit[i, k] = true;
        }
        else if( map[i, k] == 0)
        {
            path[i, k] = 0;
        }
    }
}
while (queue.Count > 0)
{
    (int r, int c) = queue.Dequeue();
    for(int i=0;i<4;i++ )
    {
        int nr = r + dr[i];
        int nc = c+ dc[i];
        
        if(nr<0 || nr>=x || nc<0 ||nc>=y)
        {
            continue;
        }


        if (isvisit[nr, nc] || map[nr, nc] == 0)
            continue;

        isvisit[nr,nc] = true;
        path[nr, nc] = path[r, c] + 1;
        queue.Enqueue((nr, nc));

    }
}

var sb = new StringBuilder();
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        if (map[i, j] == 0)
            sb.Append("0 ");
        else
            sb.Append(path[i, j]).Append(' ');
    }
    sb.AppendLine();
}

writer.Write(sb.ToString());
writer.Flush(); //마지막에 무조건 플러쉬 해주기!! 중요
 