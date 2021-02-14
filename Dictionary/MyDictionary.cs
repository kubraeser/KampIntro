using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T1,T2>
    {
        T1[] items1;
        T2[] items2;

        public MyDictionary()
        {
            items1 = new T1[0];
            items2 = new T2[0];
        }

        public void Add(T1 name, T2 age)
        {
            T1[] tempDict = items1;
            T2[] tempDict2 = items2;

            items1 = new T1[items1.Length + 1];
            items2 = new T2[items2.Length + 1];

            for (int i = 0; i < tempDict.Length; i++)
            {
                items1[i] = tempDict[i];
            }
            items1[items1.Length - 1] = name;

            for (int i = 0; i < tempDict2.Length; i++)
            {
                items2[i] = tempDict2[i];
            }
            items2[items2.Length - 1] = age;

            Console.WriteLine(name + " eklendi.");
            Console.WriteLine(age + " eklendi.");

        }
    }
}
