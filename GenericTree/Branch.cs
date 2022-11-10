namespace GenericTree;

public class Branch
{
    LinkedList<Branch> branches = new LinkedList<Branch>();

    public void AddBranch(Branch newBranch)
    {
        branches.AddFirst(newBranch);
    }

    //The complexity is O(n) as we are traversing all the elements one time
    public int GetDepth()
    {
        while(branches.Count() != 0)
        {
            int depth = 0;
            foreach (Branch b in branches)
            {
                //total depth of a one branch/path
                int belowDepth = b.GetDepth();

                //take the longest depth and keep the value
                if(depth < belowDepth)
                {
                    depth = belowDepth;
                }
            }
            //if not a leaf node return depth + 1
            return depth + 1;
        }
        //return 1 if its a leaf node
        return 1;
    }
}