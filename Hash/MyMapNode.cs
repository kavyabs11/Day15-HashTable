using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    public class MyMapNode<K, V>
    {
        internal int Size;
        internal LinkedList<KeyValue<K, V>>[] Items;

        public MyMapNode(int Size)
        {
            this.Size = Size;
            Items = new LinkedList<KeyValue<K, V>>[Size];
        }

        public int ArrayPosition(K key)
        {
            int position = key.GetHashCode() % Size;
            return Math.Abs(position);
        }

        public V Get(K key)
        {
            int position = ArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);

            foreach (KeyValue<K, V> Items in linkedlist)
            {

                if (Items.Key.Equals(key))
                {
                    return Items.Value;
                }
            }
            return default(V);
        }
        public void Add(K key, V value)
        {
            int position = ArrayPosition(key);

            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            KeyValue<K, V> Items = new KeyValue<K, V>() { Key = key, Value = value };

            linkedlist.AddLast(Items);
        }

        public LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedlist = Items[position];

            if (linkedlist == null)
            {
                linkedlist = new LinkedList<KeyValue<K, V>>();
                Items[position] = linkedlist;
            }
            return linkedlist;
        }

        public struct KeyValue<k, v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }

        public void Remove(K key)
        {
            int position = ArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);

            bool ItemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);

            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    ItemFound = true;
                    foundItem = item;
                }
            }

            if (ItemFound)
            {
                linkedlist.Remove(foundItem);
            }
        }
    }
}
