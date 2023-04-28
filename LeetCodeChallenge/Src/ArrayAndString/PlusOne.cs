namespace ArrayAndString
{
    public class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits[digits.Length - 1] != 9)
            {
                digits[digits.Length - 1] += 1;
                return digits;
            }
            else
            {
                int[] result = new int[digits.Length];
                int extendedValue = -1;
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    if (extendedValue == 0)
                    {
                        result[i] = digits[i];
                        continue;
                    }
                    if (digits[i] == 9)
                    {
                        result[i] = 0;
                        extendedValue = 1;
                    }
                    else
                    {

                        result[i] = digits[i] + extendedValue;
                        extendedValue = 0;

                    }
                }

                if (extendedValue != 0)
                {
                    var extendedResult = new int[digits.Length + 1];
                    extendedResult[0] = extendedValue;
                    return extendedResult;
                }
                else
                {
                    return result;
                }
            }
        }
    }
}