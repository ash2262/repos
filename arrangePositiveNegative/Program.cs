using System;

class GFG
{
    // Utility function to right rotate
    // all elements between [outofplace, cur] to keep the remaining order same as it was
    static void rightrotate(int[] arr, int n,
                            int outofplace, int cur)
    {
        int tmp = arr[cur];
        for (int i = cur; i > outofplace; i--)
            arr[i] = arr[i - 1];// to move each value one place at a time and then replace the outofplace with curr value
        arr[outofplace] = tmp;
    }

    static void rearrange(int[] arr, int n)
    {
        int outofplace = -1;

        for (int index = 0; index < n; index++)
        {
            if (outofplace >= 0)
            {
                // find the item which must be moved
                // into the out-of-place entry if out-of-
                // place entry is positive and current
                // entry is negative OR if out-of-place
                // entry is negative and current entry
                // is negative then right rotate
                // [...-3, -4, -5, 6...] --> [...6, -3, -4,
                // -5...]
                // 	^                     	^
                // 	|                     	|
                // 	outofplace 	--> 	outofplace
                //
                if (((arr[index] >= 0)
                     && (arr[outofplace] < 0))
                    || ((arr[index] < 0)
                        && (arr[outofplace] >= 0)))
                {
                    rightrotate(arr, n, outofplace, index);

                    // the new out-of-place entry
                    // is now 2 steps ahead
                    if (index - outofplace > 2)  //to continue the //operation next to the last index. If this code is not there, 
                        //outofplace will be set to the last outofplace and it will replace it // again.
                        outofplace = outofplace + 2;
                    else
                        outofplace = -1; //this will send it for checking the current index and its values
                }
            }

            // if no entry has been flagged out-of-place
            if (outofplace == -1)
            {
                // check if current entry is out-of-place
                if (((arr[index] >= 0)
                     && ((index & 0x01) == 0))
                    || ((arr[index] < 0)
                        && (index & 0x01) == 1))
                    outofplace = index;
            }
        }
    }

    // A utility function to print an
    // array 'arr[]' of size 'n'
    static void printArray(int[] arr, int n)
    {
        for (int i = 0; i < n; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine("");
    }

    // Driver code
    public static void Main()
    {
        int[] arr = { -5, -2, 5, 2, 4, 7, 1, 8, 0, -8 };
        int n = arr.Length;

        Console.WriteLine("Given array is ");
        printArray(arr, n);

        rearrange(arr, n);

        Console.WriteLine("RearrangeD array is ");
        printArray(arr, n);
    }
}
