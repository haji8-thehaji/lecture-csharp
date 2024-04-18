public void QuickSort(int[] array, int left, int right)
{
    if (left >= right) { return; }

    int temp;
    int pivot = array[(left + right) / 2];
    int i = left, j = right;
    while (i < j)
    {
        while (array[i] < pivot) { i++; }
        while (pivot < array[j]) { j--; }

        if (i < j)
        {
            if (array[i] == array[j]) { break; }

            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    QuickSort(array, left, j - 1);
    QuickSort(array, j + 1, right);
}
