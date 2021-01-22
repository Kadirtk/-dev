using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T,J>
    {
        T[] keyArray;
        T[] tempKey;
        J[] valueArray;
        J[] tempValue;

        public MyDictionary()
        {
            keyArray = new T[0];
            valueArray = new J[0];
        }

        public void Add(T key,J value)
        {
            tempKey = keyArray;
            tempValue = valueArray;

            keyArray = new T[keyArray.Length + 1];
            valueArray = new J[valueArray.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keyArray[i] = tempKey[i];
                valueArray[i] = tempValue[i];
            }
            keyArray[keyArray.Length - 1] = key;
            valueArray[valueArray.Length - 1] = value;
        }
        public T[] Keys
        {
            get { return keyArray; }
        }
        public J[] Values
        {
            get { return valueArray; }
        }
    }
}
