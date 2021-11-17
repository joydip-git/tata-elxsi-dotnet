using System;
using System.Collections;
using System.Collections.Generic;

namespace KeysandValuesDemo
{
    struct KeyValueData<TKey, TValue>
    {
        private TKey _key;
        private TValue _value;

        public KeyValueData(TKey key, TValue value)
        {
            this._key = key;
            this._value = value;
        }

        public TKey Key => _key;
        public TValue Value => _value;
    }
    class MyCollection<TKey, TValue> : IEnumerable<KeyValueData<TKey, TValue>>
    {
        private readonly List<KeyValueData<TKey, TValue>> items;
        public MyCollection()
        {
            items = new List<KeyValueData<TKey, TValue>>();
        }
        public void Add(TKey key, TValue value)
        {
            KeyValueData<TKey, TValue> keyValueData = new KeyValueData<TKey, TValue>(key, value);
            items.Add(keyValueData);
        }

        public IEnumerator<KeyValueData<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main()
        {
            //sessionId:dhsadjaDHQW1WPI
            // Dictionary<>
            /*
            MyCollection<string, int> myCollection = new MyCollection<string, int>();
            myCollection.Add("1", 12);
            myCollection.Add("first", 1);
            myCollection.Add("a", 21);

            foreach (KeyValueData<string, int> item in myCollection)
            {
                Console.WriteLine($"Key:{item.Key}, value:{item.Value}");
            }
            */

            //keys are not sorted
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            //adding using Add method (if the key exists, then exception will be thrown. if the key does not exist, then the key and value will be added)
            dictionary.Add("1", 12);
            dictionary.Add("a", 21);
            dictionary.Add("first", 1);
           
            //dictionary.Add("a", 212);

            //adding using indexer (if the key exists, then the value will be updated and if the key does not exist, then the key and value will be added)
            dictionary["a"] = 231;

            //dictionary.Remove("1");

            foreach (KeyValuePair<string, int> item in dictionary)
            {
                Console.WriteLine($"Key:{item.Key}, value:{item.Value}");
            }
            if (dictionary.ContainsKey("first"))
            {
                dictionary["first"] = 111;
                Console.WriteLine(dictionary["first"]);
            }

            //keys will be sorted by defualt
            SortedList<int, int> sl = new SortedList<int, int>();
            //adding using Add method (if the key exists, then exception will be thrown. if the key does not exist, then the key and value will be added)
            sl.Add(1, 12);           
            sl.Add(0, 1);
            sl.Add(2, 21);

            //dictionary.Add("a", 212);

            //adding using indexer (if the key exists, then the value will be updated and if the key does not exist, then the key and value will be added)
            sl[-1] = 231;

            //dictionary.Remove("1");

            foreach (KeyValuePair<int, int> item in sl)
            {
                Console.WriteLine($"Key:{item.Key}, value:{item.Value}");
            }

            /**
             * split the setence, get the words in an array
             * iterate through the array, pick up each word and add it to a collection along with the count (if the word already does not exist in the collection)
             * if the word exists, you increase the count value in the collection
             * 
             * select products.productname
             * group products.productname by categories.categoryname
             * 
             * SortedList<string, List<string>>
             * 
             * Laptop
             * -----------------------
             * Accer
             * Dell
             * Hp
             *           
             * Mobile
             * ------------------------------
             * iphone
             * one plus
             * 
             */
        }
    }
}
