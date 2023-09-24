public class Algo
{
    public static void Merge(int[] left , int[] right , int[] array )
    {
        int leftSize = array.Length / 2;
        int rightSize = right.Length / 2;
        int i = 0, l = 0, r = 0;

        while(l < leftSize && r < rightSize)
        {
            if (left[i] < right[r])
            {
                array[i] = left[l];
                i++;
                l++;
            }
            else
            {
                array[i] = right[r];
                ++i;
                ++r;
            }
        }

        while(l < leftSize)
        {
            array[i] = left[l];
            i++;
            l++;
        }
        while(r < rightSize)
        {
            array[i] = right[r];
            i++;
            r++;
        }
    }
}