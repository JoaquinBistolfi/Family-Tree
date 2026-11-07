using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> n1 = new Node<int>(1);
            Node<int> n2 = new Node<int>(2);
            Node<int> n3 = new Node<int>(3);
            n1.AddChild(n2);
            n1.AddChild(n3);

            SumVisitor sum = new SumVisitor();
            n1.Accept(sum);
            Console.WriteLine("Sum of numbers: " + sum.Total);

            Node<Person> ana = new Node<Person>(new Person("Ana", 78));
            Node<Person> carlos = new Node<Person>(new Person("Carlos", 52));
            Node<Person> laura = new Node<Person>(new Person("Laura", 49));
            Node<Person> mateo = new Node<Person>(new Person("Mateo", 24));
            Node<Person> sofia = new Node<Person>(new Person("Sofia", 20));
            Node<Person> diego = new Node<Person>(new Person("Diego", 18));
            Node<Person> valentina = new Node<Person>(new Person("Valentina", 15));

            ana.AddChild(carlos);
            ana.AddChild(laura);
            carlos.AddChild(mateo);
            carlos.AddChild(sofia);
            laura.AddChild(diego);
            laura.AddChild(valentina);

            AgeSumVisitor ageSum = new AgeSumVisitor();
            ana.Accept(ageSum);
            Console.WriteLine("Sum of ages: " + ageSum.Total);

            OldestChildVisitor oldestChild = new OldestChildVisitor();
            ana.Accept(oldestChild);
            Console.WriteLine("Oldest child: " + oldestChild.Result.Name + " - " + oldestChild.Result.Age);

            LongestNameVisitor longestName = new LongestNameVisitor();
            ana.Accept(longestName);
            Console.WriteLine("Longest name: " + longestName.Result.Name);
        }
    }
}
