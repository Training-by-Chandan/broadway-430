namespace Brooadway.ConsoleApp.Delegates
{
    public class Deleg
    {
        public delegate void Add(string str);

        public event Add OnClick;

        public void Call(string str)
        {
            OnClick?.Invoke(str);
        }
    }
}