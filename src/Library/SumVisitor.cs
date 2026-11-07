namespace Library;

public class SumVisitor : IVisitor<int>
{
    public int Total { get; private set; }

    public void Visit(Node<int> node)
    {
        Total = Total + node.Data;
    }
}
