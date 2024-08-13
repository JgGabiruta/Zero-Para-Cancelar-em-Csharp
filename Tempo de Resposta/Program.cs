using System.Runtime.Serialization;

namespace Tempo_de_Resposta
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int S = 0;
            int N = int.Parse(Console.ReadLine());
            Stack<int> x = new Stack<int>();
            for(int i = 0; i < N; i++)
            {
                int v = int.Parse(Console.ReadLine());
                if (v == 0 && x.Count > 1)   
                {
                    x.Pop();

                } else
                {
                    x.Push(v);
                }
            }
            foreach(int v in x)
            {
                S += v;
            }
            
            Console.WriteLine(S);
        }
    }

}
