using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal abstract class State
    {
        private Player _player;

        public State(Player player)
        {
            _Player = player;
        }

        public Player _Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public abstract void onPlay();
        public abstract void onNext();
        public abstract void onPrevious();
    }
}
