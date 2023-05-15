using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBinaryTree
{

    internal class MyMapNode<K, V>
    {
        private LinkedList<KeyValuePair<K, V>>[] items;
        private readonly int size;

        public MyMapNode(int size)
        {
            items = new LinkedList<KeyValuePair<K, V>>[size];
            this.size = size;
        }

        public int CountFrequency(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> list = items[position];
            int count = 1;
            bool DoubleWord = false;
            KeyValuePair<K, V> NewSentence = default(KeyValuePair<K, V>);
            if (list != null)
            {
                foreach (KeyValuePair<K, V> pair in list)
                {
                    if (pair.key.Equals(key))
                    {
                        DoubleWord = true;
                        NewSentence = pair;
                        count = Convert.ToInt32(pair.value) + 1;
                    }
                }
                if (DoubleWord == true)
                {
                    list.Remove(NewSentence);
                }
            }
            return count;
        }

        public int GetArrayPosition(K Key)
        {
            var position = Key.GetHashCode() % size;
            return Math.Abs(position);
        }


        public void Add(K Key, V Value)
        {
            int position = GetArrayPosition(Key);
            LinkedList<KeyValuePair<K, V>> linkedList = GetLinkedList(position);
            KeyValuePair<K, V> Adding = new KeyValuePair<K, V>() { key = Key, value = Value };
            linkedList.AddLast(Adding);
        }

        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> linkedList = items[position];
            KeyValuePair<K, V> Removing = default(KeyValuePair<K, V>);
            foreach (KeyValuePair<K, V> kv in linkedList)
            {
                if (kv.key.Equals(key))
                {
                    Removing = kv;
                }
            }
            linkedList.Remove(Removing);
        }

        public LinkedList<KeyValuePair<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValuePair<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValuePair<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

        public void Display(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> LinkedListofPosition = GetLinkedList(position);
            foreach (KeyValuePair<K, V> keyValue in LinkedListofPosition)
            {
                if (keyValue.key.Equals(key))
                {
                    Console.WriteLine($"{keyValue.key} : {keyValue.value}");
                }
            }
        }
    }

    public struct KeyValuePair<K, V>
    {
        public K key { get; set; }
        public V value { get; set; }
    }
}