namespace Library;

using System.Collections.Generic;

public class Node<T>
{
    public T Data { get; private set; }
    public List<Node<T>> Children { get; private set; }

    public Node(T data)
    {
        Data = data;
        Children = new List<Node<T>>();
    }

    public void AddChild(Node<T> child)
    {
        Children.Add(child);
    }

    public void Accept(IVisitor<T> visitor)
    {
        visitor.Visit(this);

        foreach (Node<T> child in Children)
        {
            child.Accept(visitor);
        }
    }
}
