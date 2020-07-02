using Xenko.Engine;

namespace Test04.Windows
{
    class Test04App
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
