using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_official
{
    //There can be an X player, or an O player or none player at all.
    public enum Player { X, O, None }


    public interface IBoard
    {   //Method to Shoot for the Player with the cows that have formed a mill
        void Shoot(IPlayer player);
        //Method to get the neighbouring positions.
        List<INode> getNeighbours(string getPosition);
        INode getCell(string getPosition);
        //Property which list's the total number of cows
        int numCows(Player player);
        bool allInMill(Player player);
        void drawBoard();//draw gameBoard
        bool canPlay(IPlayer player);
        //Method which Places the COWS onto the Board
        void Place(IPlayer player);
        //Method to move cows from on position to the other 
        void Move(IPlayer player);
        //Check Movability
        bool isMovable(string getPosition);
        //Check if the Cow is in a Mill position
        bool isInMill(string getPosition);
        
    }

    public interface INode
    {        
        Player getState { get; }
        void changeState(Player changedState);
    }

    public interface IPlayer
    {
        Player playerID { get; }
        string getMove(string prompt);
        Player getOpponent();
        int Cows { get; }
        void reduceNumCows();
        bool isFlying();
        void makeFlying();
    }

    
    public interface IReferee
    {
        //This is where the game starts initially
        void placingPhase();
        //Phase following the Placement phase where the entities move adjacently if position is unoccupied.
        void movingPhase();
    }

    public class invalidMoveException : ApplicationException { }
}
