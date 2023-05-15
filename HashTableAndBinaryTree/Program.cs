using HashTableAndBinaryTree;

namespace HashTableAndBinaryTree
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
            Console.WriteLine("Binary search tree");

            MyBinaryTree<int> myBinaryTree = new MyBinaryTree<int>();
            myBinaryTree.Insert(56);
            myBinaryTree.Insert(30);
            myBinaryTree.Insert(70);
            myBinaryTree.Insert(22);
            myBinaryTree.Insert(40);
            myBinaryTree.Insert(60);
            myBinaryTree.Insert(95);
            myBinaryTree.Insert(65);
            myBinaryTree.Insert(63);
            myBinaryTree.Insert(67);
            myBinaryTree.Insert(11);
            myBinaryTree.Insert(3);
            myBinaryTree.Insert(16);

            myBinaryTree.Display();
            myBinaryTree.Search(63);

        }


        public static void WordFrequency(string[] StringToArray)
        {
            MyMapNode<string, int> MyMapNode = new MyMapNode<string, int>(5);
            foreach (string word in StringToArray)
            {
                int count = MyMapNode.CountFrequency(word);
                MyMapNode.Add(word, count);
            }
            MyMapNode.Remove("avoidable");
            IEnumerable<string> DistinctSentence = StringToArray.Distinct<string>();
            foreach (string word in DistinctSentence)
            {
                MyMapNode.Display(word);
            }
        }
        
    }
 

}