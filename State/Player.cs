using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Player
    {
        private State _state;
        private bool _playing = false;
        private List<string> _playlist = new List<string>();
        private int _currentTrack = 0;

        public Player()
        {
            _State = new ReadyState(this);
            Playing = true;
            for(int i=0; i<=12; i++)
            {
                _playlist.Add("Track => "+i.ToString());
            }
        }

        public State _State 
        { 
            get { return _state; } 
            set { _state = value; }
        }

        public bool Playing
        {
            get { return _playing; }
            set { _playing = value; }
        }

        public List<String> Playlist
        {
            get { return _playlist; }
            set { _playlist = value; }
        }

        public int CurrentTrack
        {
            get { return _currentTrack; }
            set { _currentTrack = value; }
        }

        public void nextTrack()
        {
            CurrentTrack++;
            if (CurrentTrack > Playlist.Count - 1)
            {
                CurrentTrack = 0;
            }
            Console.WriteLine("Playing " + Playlist[CurrentTrack]);
        }

        public void previousTrack()
        {
            CurrentTrack--;
            if (CurrentTrack < 0)
            {
                CurrentTrack = Playlist.Count - 1;
            }
            Console.WriteLine("Playing " + Playlist[CurrentTrack]);
        }

        public string startPlaying()
        {
            return "Playing " + Playlist[CurrentTrack];
        }
    }
}
