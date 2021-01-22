using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOdev
{
    class MyDictionary<T, Y>
    {
        T[] x;
        Y[] y;

        public MyDictionary()
        {
            x = new T[0];
            y = new Y[0];

        }

        public void Add(T xx, Y yy)
        {
            T[] tempArrayx = x;
            Y[] tempArrayy = y;

            x = new T[x.Length + 1];
            y = new Y[y.Length + 1];

            for (int i = 0; i < tempArrayx.Length; i++)
            {
                x[i] = tempArrayx[i];
            }

            for (int i = 0; i < tempArrayy.Length; i++)
            {
                y[i] = tempArrayy[i];
            }

            x[x.Length - 1] = xx;
            y[y.Length - 1] = yy;
        }

     

    }
}
