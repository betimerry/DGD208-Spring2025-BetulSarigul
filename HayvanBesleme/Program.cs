using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HayvanBesleme
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Game game = new Game();
            await game.Start();
        }
    }
}
