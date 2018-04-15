using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnMorabarabaOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Board gameBoard = new Board();
            Console.WriteLine(gameBoard.drawBoard());
            
            GameManager manageGame = new GameManager();
            //Player x = new Player();
            string currentPlayer = "X";
            manageGame.placing(currentPlayer);

            Console.ReadLine();
        }
        class Board
        {
            public Board()
            {
                //The constructor
            }
            public List<string> GameBoard = new List<string>
              {    "a1", "a4","a7",
                   "b2","b4","b6",
                   "c3", "c4", "c5",
                   "d1", "d2", "d3",
                   "d5", "d6","d7",
                   "e3","e4","e5",
                   "f2","f4", "f6",
                   "g1", "g4","g7"
               };

            public string drawBoard()
            {
               
                return
              $@"
                                                                    1   2   3   4   5   6   7
                                                                A   {GameBoard[0]}-----------{GameBoard[1]}-----------{GameBoard[2]}
                                                                    | \         |         / |
                                                                B   |   {GameBoard[3]}-------{GameBoard[4]}-------{GameBoard[5]}   |
                                                                    |   | \     |     / |   |
                                                                C   |   |   {GameBoard[6]}---{GameBoard[7]}---{GameBoard[8]}   |   |
                                                                    |   |   |       |   |   |
                                                                D   {GameBoard[9]}---{GameBoard[10]}---{GameBoard[11]}       {GameBoard[12]}---{GameBoard[13]}---{GameBoard[14]}
                                                                    |   |   |       |   |   |
                                                                E   |   |   {GameBoard[15]}---{GameBoard[16]}---{GameBoard[17]}   |   |
                                                                    |   | /     |     \ |   |
                                                                F   |   {GameBoard[18]}-------{GameBoard[19]}-------{GameBoard[20]}   |
                                                                    | /         |         \ |
                                                                G   {GameBoard[21]}-----------{GameBoard[22]}-----------{GameBoard[23]}
            ";
            }
            public bool isValidPos (string player, string position)
            {
                for (int i = 0; i < GameBoard.Count; i++)
                {
                    if (GameBoard[i] == position)
                        return true;
                   
                }//else, the value enterd by the player is an invalid move or is currently occupied
                return false;
            }

            public void makeMove (string player, string position)
            {
                for (int i = 0; i < GameBoard.Count; i++)
                {
                    if (GameBoard[i] == position)
                    { GameBoard[i] = player; return; }

                }//else, the value enterd by the player is an invalid move or is currently occupied
                
            }
        }
        class Player
        {
           
            public int numCows = 2;
            private string currentPlayer;
            public Player(string player)
            {
                //This is the constructor for the Player
                currentPlayer = player;
                //numCows = 2;
            }
            private bool flying = false;

            

            public void makeFly()
            {
                flying = true;
            }
            public bool isFlying()
            {
                return flying;
            }

            public string switchPlayer (string player)
            {
                string  ans =  player == "X" ?  "Y" : "X";
                return ans;
            }

            public void reduceCows()
            {
                numCows--;
            }


        }
        class GameManager
        {
            Board newBoard = new Board();
            

            

            public GameManager()
            {
                //The constructor for GameManager
                IsDraw();
                //Play();
                //Winner();
            }

            
            private void IsDraw()
            {
                //Will be implemented in due course.
            }
            //public void Play(string player)
            //{
            //    Player N = new Player(player);

            //    Console.WriteLine("{0}'s turn: PLAYER {1}, Enter cell reference of position to place your move:",player,player);

            //    string positon = Console.ReadLine();


            //    if (!(newBoard.isValidPos(player, positon)))
            //    { Console.WriteLine("Invalid move!!! Position may be non existant or currently occupied. Please re-enter position"); Play(player); }

            //    Console.Clear();

            //    newBoard.makeMove(player, positon);
                
            //    Console.WriteLine(newBoard.drawBoard());

            //    if (N.numCows > 0)
            //    {
            //        N.reduceCows();

            //        Play(N.switchPlayer(player));
            //    }//else there is need for the player to move onto the movement phase.              
               
            //}

            public void placing(string player)
            {
                Player N = new Player(player);

                Console.WriteLine("{0}'s turn: PLAYER {1}, Enter cell reference of position to place your move:", player, player);

                string positon = Console.ReadLine();


                if (!(newBoard.isValidPos(player, positon)))
                {
                    Console.WriteLine("Invalid move!!! Position may be non existant or currently occupied. Please re-enter position");

                    placing(player);
                }

                Console.Clear();

                newBoard.makeMove(player, positon);

                Console.WriteLine(newBoard.drawBoard());

                if (N.numCows > 0)
                {
                    N.reduceCows();

                    placing(N.switchPlayer(player));
                }//else there is need for the player to move onto the movement phase.              

                move();
            }
            public void move()
            {
                Console.WriteLine("You are now in the movement phase.");

            }
        }
    }
}
