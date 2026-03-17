using System.Collections.Generic;

public class DuplicateCounter
{
    public static int CountDuplicates(List<int> numbers)
    {
        // Set for values ​​already seen
        HashSet<int> seen = new HashSet<int>();

        // Set for duplicate values
        HashSet<int> duplicates = new HashSet<int>();

        foreach (int num in numbers)
        {
            // If it cannot be added, it already existed → it is a duplicate
            if (!seen.Add(num))
            {
                duplicates.Add(num);
            }
        }

        // Returns how many unique values ​​are duplicated
        return duplicates.Count;
    }
}