public static class Trees
{
    public static BinarySearchTree CreateTreeFromSortedList(int[] sortedNumbers)
    {
        var bst = new BinarySearchTree();
        InsertMiddle(sortedNumbers, 0, sortedNumbers.Length - 1, bst);
        return bst;
    }

    private static void InsertMiddle(int[] sortedNumbers, int first, int last, BinarySearchTree bst)
    {
        // Problem 5: Insert middle element recursively to balance the tree

        if (first > last)
            return;

        int mid = (first + last) / 2;

        // Insert middle value
        bst.Insert(sortedNumbers[mid]);

        // Recurse on left half
        InsertMiddle(sortedNumbers, first, mid - 1, bst);

        // Recurse on right half
        InsertMiddle(sortedNumbers, mid + 1, last, bst);
    }
}