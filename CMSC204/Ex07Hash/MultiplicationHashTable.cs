using System;

namespace Ex07Hash.HashTables
{
    public class MultiplicationHashTable : HashTable 
    { 
        private const double a = 0.6180339887498948;
        public MultiplicationHashTable(int size) : base(size) { }
        
        protected override int Hash(int value)
        {
            double fractionalPart = Math.Abs((value * a) % 1);
            double unflooredIndex = Size * fractionalPart;
            return (int)Math.Floor(Size * fractionalPart);
        }
    }
}