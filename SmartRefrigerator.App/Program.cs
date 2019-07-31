namespace SmartRefrigerator.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public interface IEmail : INotifier
    {
        void SetSubject(string subjectMessage);
        string GetSubject();
    }
}
