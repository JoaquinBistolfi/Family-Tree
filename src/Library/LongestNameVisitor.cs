namespace Library;

public class LongestNameVisitor : IVisitor<Person>
{
    public Person Result { get; private set; }

    public void Visit(Node<Person> node)
    {
        if (Result == null || node.Data.Name.Length > Result.Name.Length)
        {
            Result = node.Data;
        }
    }
}
