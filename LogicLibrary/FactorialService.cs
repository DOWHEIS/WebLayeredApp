namespace LogicLibrary;
public class FactorialService
{
    public static int Factorial(int x)
    {
        if (x < 0)
        {
            throw new Exception("negative");
        }
        if (x == 0)
        {
            return 1;
        }
        int res = 1;
        while (x != 1)
        {
            res = res * x;
            x = x - 1;
        }
        return res;
    }

}
