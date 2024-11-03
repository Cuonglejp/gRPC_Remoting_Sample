using RemotingLibrary.Interfaces;
public class GreetingService : MarshalByRefObject,IGreetingService
{
    public string GetGreeting(string name)
    {
        return $"Hello, {name}!";
    }
}
