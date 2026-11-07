namespace Library;

public class AgeSumVisitor : IVisitor<Person>
{
    public int Total { get; private set; }

    public void Visit(Node<Person> node)
    {
        Total = Total + node.Data.Age;
    }
}
