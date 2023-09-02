using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class PlayingState : State
    {

        public PlayingState(Player player) : base(player)
        {
            _Player.Playing = true;
        }

        public override void onNext()
        {
            _Player.nextTrack();
        }

        public override void onPlay()
        {
            _Player._State = new ReadyState(_Player);
            Console.WriteLine("Paused");
        }

        public override void onPrevious()
        {
            _Player.previousTrack();
        }
    }
}
