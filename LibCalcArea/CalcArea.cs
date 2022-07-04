namespace LibCalcArea
{
    public class CalcArea
    {
        public double Areacircle(double r)
        {
                return Math.PI * Math.Pow(r, 2);
        }
        public double Areatriangle(double a, double b, double c)
        {
            if (a >= 0 && b >= 0 && c >= 0)
            {
                if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                {
                    return (a * b) / 2;
                }
                else
                {
                    double p = (a + b + c) / 2;
                    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }
            }
            else
            {
                return 0;
            }
        }
    }
}