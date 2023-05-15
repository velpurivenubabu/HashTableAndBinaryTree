using HashTableAndBinaryTree;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table");
            string sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] StringToArray;
            StringToArray = sentence.Split(' ');
            WordFrequency(StringToArray);
        }


        public static void WordFrequency(string[] StringToArray)
        {
            MyMapNode<string, int> MyMapNode = new MyMapNode<string, int>(5);
            foreach (string word in StringToArray)
            {
                int count = MyMapNode.CountFrequency(word);
                MyMapNode.Add(word, count);
            }
            IEnumerable<string> DistinctSentence = StringToArray.Distinct<string>();
            foreach (string word in DistinctSentence)
            {
                MyMapNode.Display(word);
            }
        }
    }
}