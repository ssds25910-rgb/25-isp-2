namespace ClassLibrary1
{
    public class OurClassLibrary
    {
        public static double[] MultimMatrix(double[,] matrix)
        {
            int n = matrix.GetLength(0);

            double me = matrix[0, 0];
            int mi = 0;

            for (int i = 1; i < n; i++)
            {
                if (matrix[i, i] > me)
                {
                    me = matrix[i, i];
                    mi = i;
                }
            }
            double[] result = new double[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = matrix[i, mi];
            }
            return result;
        }
    }
}

