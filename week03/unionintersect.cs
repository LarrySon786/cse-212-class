var set1 = new HashSet<int>() [1, 2, 3, 4, 5];
var set2 = new HashSet<int>()[4, 5, 6, 7, 8, 9];


// FIND INTERSECTION
// Only adding the values that are in both tables to the final set.
var intersection = new HashSet<int>();
foreach (var number in set1)
{
    if (set2.Contains(number))
    {
        intersection.Add(number);
    }

    return intersection;
}


// FIND UNION
// no duplicates are permited in sets so just add all the data to a new set.
var union = new HashSet<int>();
foreach (var number in set1)
{
    union.Add(number);
}

foreach (var number in set2)
{
    union.Add(number);
}

return union;







