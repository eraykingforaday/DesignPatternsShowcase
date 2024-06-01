public class ConcreteObservable : IObservable
{
    private List<IObserver> observers = new List<IObserver>();
    private string message;

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }

    public void UpdateMessage(string message)
    {
        this.message = message;
        NotifyObservers();
    }
}