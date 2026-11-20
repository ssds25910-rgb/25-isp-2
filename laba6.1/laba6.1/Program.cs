try
{
    bool F1(bool x, bool y, bool z)
    {
        return (!x && z) || (y && !z);
    } 
    bool F2(bool x, bool y, bool z)
    {
        return !y || ((x && !z) && z);
    }

    Console.WriteLine("X | Y | Z | F1 | F2");
    Console.WriteLine(new string('-', 19));

    for (int x = 0; x <= 1; x++)
    {
        for (int y = 0; y <= 1; y++)
        {
            for (int z = 0; z <= 1; z++)
            {
                bool bx = (x == 1);
                bool by = (y == 1);
                bool bz = (z == 1);

                int res1 = F1(bx, by, bz) ? 1 : 0;
                int res2 = F2(bx, by, bz) ? 1 : 0;

                Console.WriteLine($"{x} | {y} | {z} |  {res1} |  {res2}");
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


