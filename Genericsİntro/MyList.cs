using System;
using System.Collections.Generic;
using System.Text;

namespace Genericsİntro
{
    class MyList <T>
    {
        T[] items;
        //constructor   clası new lediğin zmaan alt taraf otomatik olarak çalışır.
        public MyList()
        {
            items = new T[0];  
        }
        public void Add(T item)  // item = eleman   
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length;i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
