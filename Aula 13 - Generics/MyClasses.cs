/*
 * IPCA-EST-LP2
 * Lidar com Generics Classes
 * Generic Classes : type-safe classes
 * boxing/unboxing
 *
 * Consultar http://msdn.microsoft.com/en-us/library/ms379564%28v=vs.80%29.aspx
 * lufer
 * */


using System;
using System.Collections.Generic;

namespace Generics
{
    /// <summary>
    /// Classe normal
    /// </summary>
    class MyClass
    {
        int[] dados;
        //object[] dados1;
        const int MAX = 20;
        int tot;

        public MyClass()
        {
            dados = new int[MAX];
            tot = 0;
        }

        /// <summary>
        /// Indexador...
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int this[int i]
        {
            get { return dados[i]; }
            set { dados[i] = value; tot++; }
        }

        /// <summary>
        /// Troca no estado actual
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Swap(int x, int y)
        {
            if (x >= 0 && x <= tot && y >= 0 && y <= tot)
            {
                int t = dados[x];
                dados[x] = dados[y];
                dados[y] = t;
            }
        }

        /// <summary>
        /// Troca com referências
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Swap(ref int x, ref int y)
        {
               int t = x;
                x = y;
                y = t;
        }
    }

    /// <summary>
    /// Classe demonstradora de comportamento (quase) genérico
    /// Estado "condiciona"
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MyGenericArray<T>
    {
        private T[] dados;
        const int MAX=20;
        int tot;

        public MyGenericArray()
        {
            dados = new T[MAX];
            tot = 0;
        }

        public MyGenericArray(int s)
        {
            dados = new T[s];
            tot = 0;
        }

        /// <summary>
        /// Indexador
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T this[int i]
        {
            get { return dados[i]; }
            set { dados[i] = (T)(object)value; tot++; }
        }
        //Substitui Properties...a la JAVA!!!!
        public T GetItem(int index)
        {
            return dados[index];
        }

        public void SetItem(int index, T value)
        {
            dados[index] = value;
        }

        /// <summary>
        /// Troca no estado actual
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Swap<X>(int x, int y)
        {
            X aux = (X)(object)dados[x];            
            dados[x] = dados[y];
            dados[y] = (T)(object)aux;
            //ou
            //dados[y] = (T)(Convert.ChangeType(aux, typeof(T)));
        }

        /// <summary>
        /// Método Genérico
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

    }


    /// <summary>
    /// Classe demonstradora de comportamento genérico
    /// Estado "não condiciona"
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class ReallyGeneric<T>
    {
        private T aux;
        
        public ReallyGeneric(T o)
        {
            aux = o;
        }

        public T Aux
        {
            get { return aux; }
            set { aux = value; }
        }

        /// <summary>
        /// Só  possível caso T implemente IEnumerator
        /// </summary>
        //public void Show()
        //{
        //    foreach (T x in aux)
        //    {
        //    }
        //}
    }


    class OtherGenerics<T>
    {

        /// <summary>
        /// Converte List to Array de Generics
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T[] ConvertListToArray<T>(List<T> list)
        {
            int count = list.Count;
            T[] array = new T[count];
            for (int i = 0; i < count; i++)
                array[i] = list[i];
            return array;
        }
        //Exemplo
        //List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        //int[] array = ConvertListToArray<int>(list);


        /// <summary>
        /// Cria uma Lista inicializada com determinado valor
        /// http://www.dotnetperls.com/generic-method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<T> GetInitializedList<T>(T value, int count)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < count; i++)
            {
                list.Add(value);
            }
            return list;
        }
        //Exemplo
        //List<bool> list1 = GetInitializedList<bool>(true, 5);
        //List<string> list2 = GetInitializedList<string>("Perls", 3);        

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TypeOfValue"></typeparam>
        /// <param name="value"></param>
        public void Show<TypeOfValue>(TypeOfValue value)
        {
            Console.WriteLine(value.ToString());        //versão mais simples!
        }

    }



    #region Generic Types - I - LISTS
    // --------------------------------------------------------------------
    // The following code example shows a simple generic linked-list
    // class for demonstration purposes. (In most cases, it is recommended
    // that you use the List<T> class provided by the .NET Framework class
    // library, rather than create your own.) The type parameter T is
    // used in several places where a concrete type would normally be
    // used to indicate the type of the item stored in the list.
    // https://www.akadia.com/services/dotnet_generics.html
    // --------------------------------------------------------------------

    // Type parameter T in angle brackets <>
    public class CustomList<T>
    {
        // Fields
        private Node head;

        // The nested class is also generic on T
        private class Node
        {
            // Fields
            private Node next;

            // T as private member data type
            private T data;

            // T used in non-generic constructor
            public Node(T pData)
            {
                next = null;
                data = pData;
            }

            // Properties
            public Node Next
            {
                get
                {
                    return next;
                }
                set
                {
                    next = value;
                }
            }

            // T as return type of the Property
            public T Data
            {
                get
                {
                    return data;
                }
                set
                {
                    data = value;
                }
            }
        }

        // Constructor
        public CustomList()
        {
            head = null;
        }

        // T as method parameter type:
        public void Add(T pType)
        {
            Node n = new Node(pType);
            n.Next = head;
            head = n;
        }

        // Enables foreach on the List
        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        // Provides indexing on the List
        public T this[int index]
        {
            get
            {
                int ctr = 0;
                Node current = head;
                while (current != null && ctr <= index)
                {
                    if (ctr == index)
                    {
                        return current.Data;
                    }
                    else
                    {
                        current = current.Next;
                    }
                    ++ctr;
                }
                return default(T);
            }
        }

        // Provides ToString() on the List
        public override string ToString()
        {
            if (this.head != null)
            {
                return this.head.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }

    // My own Class of any Datatype
        class ExampleClass
        {
            private object o;

            public ExampleClass(object obj)
            {
                o = obj;
            }

            public object objGet
            {
                get
                {
                    return o;
                }
            }
        }

        #endregion


    #region Multiple Generic Types - II

        /// <summary>
        /// List Node 
        /// Adaptado de http://msdn.microsoft.com/en-us/library/ms379564%28v=vs.80%29.aspx
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="T"></typeparam>
        class Node<K, T>
    {
        public K Key;
        public T Item;
        public Node<K, T> NextNode;

        public Node()
        {
            Key = default(K);
            Item = default(T);
            NextNode = null;
        }

        public Node(K key, T item, Node<K, T> nextNode)
        {
            Key = key;
            Item = item;
            NextNode = nextNode;
        }

    }
    /// <summary>
    /// Multiple Generic Types
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<K, T>
    {
        Node<K, T> m_Head;
        public LinkedList()
        {
            m_Head = new Node<K, T>();
        }

        public void AddHead(K key, T item)
        {
            Node<K, T> newNode = new Node<K, T>(key, item, m_Head.NextNode);
            m_Head.NextNode = newNode;
        }



    }

    #endregion

    class X
    {
        public int a;
        public int[] valores;
    }

    class X<T>
    {
        public T a;
        public T[] valores;

    }

    class X<K, T>
    {
        public K a;
        T valores;
         

        public T Valores
        {
            get => valores;
            set => valores = value;
        }


    }


}
