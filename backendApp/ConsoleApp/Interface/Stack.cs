namespace ConsoleApp.Interface
{
    public class Stack<T> : IStack<T>
    {
        private readonly IStack<T> _stack;

        public Stack(IStack<T> stack)
        {
            _stack = stack;
        }

        public T Peek()
        {
            return _stack.Peek();
        }

        public T Pop()
        {
         return _stack.Pop();
        }

        public void Push(T item)
        {
            _stack.Push(item);
        }
    }
}
