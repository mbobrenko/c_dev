        int [] Array = {11, 22, 33, 44, 44, 66, 77, 888, 9 };
        int n = Array.Length;
        int find = 44;
        int index = 0;
        while (index < n)
        {
            if (Array[index] == find)
            {
                Console.WriteLine(index);
                break;
            }
            index++;
        }
    