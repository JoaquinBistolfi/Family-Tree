namespace Library;

public class OldestChildVisitor : IVisitor<Person>
{
    public Person Result { get; private set; }

    public void Visit(Node<Person> node)
    {
        if (node.Children.Count == 0)
        {
            if (Result == null || node.Data.Age > Result.Age)
            {
                Result = node.Data;
            }
        }
    }
}
