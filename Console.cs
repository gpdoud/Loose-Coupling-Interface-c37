namespace LooseCouplingInterface
{
    internal class Console : ILogger
    {
        public void Log(object message)
        {
            System.Console.WriteLine(message.ToString());
        }

    }

}