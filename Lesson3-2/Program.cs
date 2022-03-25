namespace Lesson3
{
    class ReverseString
    {
        private string _output { get; set; } = string.Empty;
        private string _resultingString { get; set; } = string.Empty;


        public string ReverseLine(string processedString)
        {
            char[] inputString = processedString.ToArray();
            Array.Reverse(inputString);
            _output = new string(inputString);
            return _output;

        }

        public string ReverseLineDouble(string processedString)

        {
            for (int i = processedString.Length - 1; i >= 0; i--)
            {
                _resultingString += processedString[i];

            }
            return _resultingString;

        }

        static void Main(string[] args)
        {
            var saveString = new ReverseString();
            var textReverse = saveString.ReverseLineDouble("Спартак - Чемпион!");
            Console.WriteLine(textReverse);
            textReverse = saveString.ReverseLine("Спартак");
            Console.WriteLine(textReverse);
        }


    }
}