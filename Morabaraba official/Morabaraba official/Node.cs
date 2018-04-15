using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_official
{
    class Node: INode
    {
        private Player state;
        public Player getState => state;
        public Node()//The Player is primarily not assigned hence, None 
        { state = Player.None; }
        public void changeState(Player changedState)//Store the recently changed states in the Game State.
        { state = changedState;  }
    }
}
