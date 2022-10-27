namespace Generic
{
    public class MyArray<T>
    {
        private static int capacity = 10;
        private int count = 0;
        T[] arrayTest = new T[capacity];

        public void AddElement(T element)
        {
            if(count + 1 < 11)
            {
                arrayTest[count] = element;
            }
            count++;
        }

        public T this[int index]
        {
            get { return arrayTest[index]; }
            set { arrayTest[index] = value; }
        }

    }
}