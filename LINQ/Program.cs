namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>()
                {   
                    "Arc Raiders", 
                    "Elden Ring",
                    "Bloodborne", 
                    "GTA",
                    "Insurgency SandStorm",
                    "Valheim" 
                };
            var sortedbyAsc = videoGames.OrderBy(x => x.Length).ToList();
             Console.WriteLine(string.Join("\n", sortedbyAsc));
        }
    }
}
