// See https://aka.ms/new-console-template for more information

static void showPrimeNums(int upperLimit) {
    int count = 0;
    for (int i = 1; i <= upperLimit; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            if (i % j == 0)
            {
                count++;
            }
        }
        if (count == 2) 
        {
            System.Console.WriteLine(i);
        }
        count = 0;
    }
}
