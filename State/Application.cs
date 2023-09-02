using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            Player player = new Player();

            player._State.onPlay();
            player._State.onNext();
            player._State.onNext();
            player._State.onPrevious();
            // state block
            player._State.onPlay();
            player._State.onNext();

            // ready again
            player._State.onPlay();

        }
    }
}
