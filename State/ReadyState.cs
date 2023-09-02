using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class ReadyState : State
    {
        public ReadyState(Player player) : base(player) 
        {
        }

        public override void onNext()
        {
            Console.WriteLine("Locked");
        }

        public override void onPlay()
        {
            string action = _Player.startPlaying();
            _Player._State = new PlayingState(_Player);
            Console.WriteLine(action);
        }

        public override void onPrevious()
        {
            Console.WriteLine("Locked");
        }
    }
}
