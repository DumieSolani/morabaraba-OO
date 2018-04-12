using System;
using System.Collections.Generic;

namespace morabaraba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public interface IBoard
    {
        ICow Occupant(string position);
        IEnumerable<string> Cows(Cow cow); // stores the cows 
        void PlaceCow(ICow cow, string position); // places the cow on the board
        void RemoveCapturedCow(); // removes the shot cow
        void MillFormed(ICow cow);
        void CheckPreviousMill(IMills Mill);
    }
    public enum Cow { X, O } // either X cow or O cow
    public enum Status { Captured, Active, NotPlaced }

    public interface IMills
    {
        IEnumerable<string> Mills(IBoard board);
        bool MillFormed(IBoard board);
    }

    public interface ICow
    {
        IEnumerable<string> NormalMoves(IBoard board);
        IEnumerable<string> MillForms(IBoard board);
        Status Status { get; }
        Cow Cow { get; }
        string position { get; }
        void Move(string destination);
        void Shoot(string destination);
        void Fly(string destination);
        void Place(string destination);
    }
    public interface IPlayer
    {
        string Name { get; }
        (int,int) getMove();
    }
    public interface IReferee
    {
        IPlayer Winner();
        bool IsDraw();
        void Play();
    }
    public class illegalMoveException : ApplicationException { }
    public class Board : IBoard
    {
        public void CheckPreviousMill(IMills Mill)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Cows(Cow cow)
        {
            throw new NotImplementedException();
        }

        public void MillFormed(ICow cow)
        {
            throw new NotImplementedException();
        }

        public ICow Occupant(string position)
        {
            throw new NotImplementedException();
        }

        public void PlaceCow(ICow cow, string position)
        {
            throw new NotImplementedException();
        }

        public void RemoveCapturedCow()
        {
            throw new NotImplementedException();
        }
    }
    public class Player : IPlayer
    {
        public string Name => throw new NotImplementedException();

        public (int, int) getMove()
        {
            throw new NotImplementedException();
        }
    }
    public class Cows : ICow
    {
        public Status Status => throw new NotImplementedException();

        public string position => throw new NotImplementedException();

        Cow ICow.Cow => throw new NotImplementedException();

        public void Fly(string destination)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> MillForms(IBoard board)
        {
            throw new NotImplementedException();
        }

        public void Move(string destination)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> NormalMoves(IBoard board)
        {
            throw new NotImplementedException();
        }

        public void Place(string destination)
        {
            throw new NotImplementedException();
        }

        public void Shoot(string destination)
        {
            throw new NotImplementedException();
        }
    }
    public class Referee : IReferee
    {
        public bool IsDraw()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public IPlayer Winner()
        {
            throw new NotImplementedException();
        }
    }
    public class Mill : IMills
    {
        public bool MillFormed(IBoard board)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Mills(IBoard board)
        {
            throw new NotImplementedException();
        }
    }
}
