using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class LockedState : State
    {

        public LockedState(Player player) : base(player)
        {
            player.Playing = false;
        }
        public override void onNext()
        {
            Console.WriteLine("Locked");
        }

        public override void onPlay()
        {
            _Player._State = new ReadyState(_Player);
            Console.WriteLine("Ready");
        }

        public override void onPrevious()
        {
            Console.WriteLine("Locked");
        }
    }
}
