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
}
