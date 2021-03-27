namespace Ex04BinaryTree
{
    public class DuplicateChecker
    {
        private BinaryTree _existingItems;

        public DuplicateChecker()
        {
            _existingItems = new BinaryTree();
        }

        /// <summary>
        /// Checks whether or not the int testValue has already been checked previously or not.
        /// </summary>
        /// <param name="testValue"></param>
        /// <returns>True if testValue has been checked previously, and false if otherwise.</returns>
        public bool IsDuplicate(int testValue)
        {
            return !_existingItems.AddUnique(testValue);
        }

    }
}