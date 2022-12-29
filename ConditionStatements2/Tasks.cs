namespace ConditionStatements2
{
    public static class Tasks
    {
        public static (int a, int b) Task1(int a, int b)
        {
            if (a != b)
            {
                a = (a + b);
                b = a;
                return (a, b);

            }
            else
            {
                a = 0;
                b = 0;
                return (a, b);
            }
        }

        public static int Task2( int a,  int b, int c )
        {
            var min = 0;

            if (a < c & a < b)
            {
                min = a;
            }

            if (b < a & b < c)
            {
                min = b;

            }
            if (c < a & c < b)
            {
                min = c;
            }
            return min;
        }

        public static int Task3(int a,  int b, int c)
        {
            var result = 0;

            if (a < b & a < c)
            {
                result = b+c;
            }
            if (b < a & b < c)
            {
                result = a + c;
            }
            if (c < a & c < b)
            {
                result = a + b;
            }

            return result;
        }
    } 
}

