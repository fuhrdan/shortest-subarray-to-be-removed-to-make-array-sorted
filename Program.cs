//*****************************************************************************
//** 1574. Shortest Subarray to be Removed to Make Array Sorted    leetcode  **
//*****************************************************************************

int findLengthOfShortestSubarray(int* arr, int arrSize)
{
    int l = 0, r = arrSize - 1;

    while (l + 1 < arrSize && arr[l] <= arr[l + 1])
    {
        l++;
    }

    if (l == arrSize - 1)
    {
        return 0;
    }

    while (r - 1 > 0 && arr[r - 1] <= arr[r])
    {
        r--;
    }

    int min_len = (arrSize - 1 - l < r) ? arrSize - 1 - l : r;

    for (int i = 0, j = r; i <= l && j < arrSize; ++i)
    {
        while (j < arrSize && arr[i] > arr[j])
        {
            j++;
        }

        if (j < arrSize)
        {
            int current_len = j - 1 - i;
            if (current_len < min_len)
            {
                min_len = current_len;
            }
        }
    }

    return min_len;
}