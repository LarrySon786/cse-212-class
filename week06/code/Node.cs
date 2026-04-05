public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        // Check if the value already exists. DO NOT ADD if it does 
        else if (value == Data)
        {
            return;
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (Data == value)
        {
            return true;
        }
        if (value < Data)
        {
            if (Left is not null && Left.Contains(value))
            {
                return true;
            }
        }
        if (value > Data)
        {
            if (Right is not null && Right.Contains(value)) {
                return true;
            }
        }

        return false;
    }

    public int GetHeight()
    {

        // Declaring default height of left and right subtrees
        int leftHeight = 0;
        int rightHeight = 0;


        // Checking if there is only a root node
        if (Left is null && Right is null) return 1;
        

        // If Left is not null, begin adding their subtree heights.
        if (Left is not null)
        {
            leftHeight = Left.GetHeight();

        }
        // If Right is not null, begin adding their subtree heights
        if (Right is not null)
        {
            rightHeight = Right.GetHeight();
        }


        // Take the larger of the two subtrees.
        if (leftHeight > rightHeight) return leftHeight + 1;
        else if (rightHeight > leftHeight) return rightHeight + 1;
        else return leftHeight + 1;
    }
}