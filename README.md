# InterviewPrepRepo
This repo is for concepts that may be important to revisit for technical interviews.

Bubble Sort:
- Swap each adjacent pair from left to right if left < right. After you reach the end, decrement the end point.
- Essentially moves the biggest element to the right all the way in each pass.
- O(n^2)

Selection Sort:
- Go start to end looking for the lowest val and swap with start. Increment start index and repeat.
- Essentially moves smallest element to correct spot every iteration.
- O(n^2)

Insertion Sort:
- Go left to right and when the val is less than the prev val, swap right to left until val is bigger than the one to the left.
- Left gets more and more sorted.
- O(n^2)

Merge Sort:
- Split arr in half, left and right, recursively until only 1 element.
- Then merge left and right on the return, sorting on insertion.
- O(nlogn)

Quick Sort: 
- Pick partition and move all greater vals to the left. Do again on subarray to the left and right.
- Tricky for me to remember.
- O(nlogn)
```
void sort(arr, lIndex, rIndex)
{
	if(lIndex < rIndex)
	{
		int p = partition(arr, lIndex, rIndex);
		sort(arr, lIndex, p-1);
		sort(arr, p+1, rIndex);
	}
}

int partition(arr, lIndex, rIndex)
{
	int pivot = arr[rIndex];
    int i = lIndex;

    for (int j = lIndex; j < rIndex; j++)
    {
        if (arr[j] < pivot)
        {
            swap arr[i], arr[j]

            increment i
        }
    }

    swap arr[i], arr[rIndex]

    return i;
}
```