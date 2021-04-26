namespace Ex07Hash.HashTables
{
    public class DivisionHashTable : HashTable
    {
        public DivisionHashTable(int size) : base(size) { }

        protected override int Hash(int value)
        {
            return value % Size;
        }
    }
}