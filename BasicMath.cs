namespace uno_reverse
{
    public interface IBasicMath
    {
        int SumofNum(List<int> input);
        int DiffofNum(List<int> input);
        int Multipliers(List<int> input);
        float DivofNum(List<int> input);

    }
    public class BasicMath : IBasicMath
    {
        public int SumofNum(List<int> input)
        {
            int sum = 0;
            foreach (var item in input)
            {
                sum += item;
            }
            return sum;
        }

        public int DiffofNum(List<int> input)
        {
            int diff = input[0];
            for (int i = 1; i < input.Count; i++)
            {
                diff -= input[i];
            }
            return diff;
        }

        public int Multipliers(List<int> input)
        {
            int mul = 1;
            foreach (var item in input)
            {
                mul *= item;
            }
            return mul;
        }
        public float DivofNum(List<int> input)
        {
            float div = input[0];
            for (int i = 1; i < input.Count; i++)
            {
                div /= input[i];
            }
            return div;
        }
    }
}
