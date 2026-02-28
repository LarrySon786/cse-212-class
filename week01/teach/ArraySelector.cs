public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var results = new int[select.Length];
        int arrayIndex1 = 0;
        int arrayIndex2 = 0;
        int resultIndex = 0;

        foreach(int i in select)
        {
            if (i == 1)
            {
                int value = list1[arrayIndex1];
                results[resultIndex] = value;
                arrayIndex1++;
            }
            if (i == 2)
            {
                int value = list2[arrayIndex2];
                results[resultIndex] = value;
                arrayIndex2++;
            }
            resultIndex++;
        }
        return results;
    }
}