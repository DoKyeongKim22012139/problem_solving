namespace _1764_듣보잡
{
    internal class Program
    {
        static HashSet<string> names = new HashSet<string>();
        static List<string> answer = new List<string>();
        static void Main(string[] args)
        {
            solve();
        }

        static public void solve()
        {
            var reader = new StreamReader(Console.OpenStandardInput());
            var writer = new StreamWriter(Console.OpenStandardOutput());
            string[] input = reader.ReadLine().Split(" ");
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int sum = n + m;

            for(int i=0; i<n;i++)
            {
                string name = reader.ReadLine().Trim();
                names.Add(name);
            }

            for(int i=0;i<m;i++)
            {
               string name = reader.ReadLine().Trim() ;
                if(names.Contains(name))
                {
                    answer.Add(name);
                }
            }

            answer.Sort();

            writer.WriteLine(answer.Count);
            for(int i=0;i<answer.Count;i++)
            {
                writer.WriteLine(answer[i]);
            }
            writer.Flush(); 
        }
    }

}
