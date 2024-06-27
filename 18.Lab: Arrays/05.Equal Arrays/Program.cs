//Write a program that:

//· Read two arrays with the same length from the console

//· Check whether they are identical or not

//o If the arrays are identical, print: "Arrays are identical."

//o If the arrays are NOT identical, print: "Arrays are not identical."

//Note: Arrays are identical if their elements are equal.


    static void Main()
    {
        
        string[] input1 = Console.ReadLine().Split(' ');
        int[] array1 = new int[input1.Length];
        for (int i = 0; i < input1.Length; i++)
        {
            array1[i] = int.Parse(input1[i]);
        }

        string[] input2 = Console.ReadLine().Split(' ');
        int[] array2 = new int[input2.Length];
        for (int i = 0; i < input2.Length; i++)
        {
            array2[i] = int.Parse(input2[i]);
        }

        // Проверка дали двата масива са идентични
        bool areIdentical = true;
        if (array1.Length != array2.Length)
        {
            areIdentical = false;
        }
        else
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    areIdentical = false;
                    break;
                }
            }
        }

        // Принтиране на резултата
        if (areIdentical)
        {
            Console.WriteLine("Arrays are identical.");
        }
        else
        {
            Console.WriteLine("Arrays are not identical.");
        }
        
    }



