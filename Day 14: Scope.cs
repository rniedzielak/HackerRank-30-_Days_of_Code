public Difference(int[] a)
    {
        elements = a;
    }
    public int computeDifference()
    {
        System.Collections.Generic.List<int> differences = new System.Collections.Generic.List<int>();
        for (int i = 0; i < elements.Length; i++)
        {
            for (int j = 0; j < elements.Length; j++)
            {
                if (i != j)
                {
                    int sum = 0;
                    if (elements[i] - elements[j] > 0)
                    {
                        sum = elements[i] - elements[j];
                    }
                    else
                    {
                        sum = elements[j] - elements[i];
                    }
                    differences.Add(sum);
                }
            }
        }
        int max = 0;
        max = differences.Max();
        maximumDifference = max;
        return maximumDifference;
    }
