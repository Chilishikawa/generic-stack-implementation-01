using InteractiveLINQconsoleApp01;

namespace GenericStackImplementation
{
    internal class Program
    {
        static void Main()
        {
            // INTEGERS
            GenericStack<int> intCaseGeneric = new GenericStack<int>();

            // Push 3 integers to list
            intCaseGeneric.Push(1);
            intCaseGeneric.Push(2);
            intCaseGeneric.Push(3);

            // Display all elements
            var intList = intCaseGeneric.Display();
            Console.WriteLine("List of integer added: " + string.Join(", ", intList));

            // Remove last element and display remaining elements
            intCaseGeneric.Pop();
            var intsRemaining = intCaseGeneric.Display();
            Console.WriteLine("List of integer remaining in list: " + string.Join(", ", intsRemaining));

            //-------------
            // STRINGS
            GenericStack<string> stringCaseGeneric = new GenericStack<string>();

            // Push 3 strings to list
            stringCaseGeneric.Push("uno");
            stringCaseGeneric.Push("dos");
            stringCaseGeneric.Push("tres");

            // BLANK SPACE
            Console.WriteLine("");

            // Display all elements
            var stringList = stringCaseGeneric.Display();
            Console.WriteLine("List of strings added: " + string.Join(", ", stringList));

            // Remove last element and display remaining elements
            stringCaseGeneric.Pop();
            var stringRemaining = stringCaseGeneric.Display();
            Console.WriteLine("List of strings remaining in list: " + string.Join(", ", stringRemaining));

            //-------------
            // PERSON
            GenericStack<Person> personCaseGeneric = new GenericStack<Person>();

            // Push 3 strings to list
            personCaseGeneric.Push(new Person ("UNO",11,111000));
            personCaseGeneric.Push(new Person("DOS", 22, 222000));
            personCaseGeneric.Push(new Person("UNO", 33, 333000));

            // BLANK SPACE
            Console.WriteLine("");

            // Display all elements
            var personList = personCaseGeneric.Display();
            Console.WriteLine("List of people added to list:");
            foreach (Person p in personList)
            {
                Console.WriteLine($"Name: {p.Name}, Age: {p.Age}, Salary: {p.Salary}");
            }

            // Remove last element and display remaining elements
            personCaseGeneric.Pop();
            var personRemaining = personCaseGeneric.Display();
            Console.WriteLine("List of people remaining in list:");
            foreach (Person p in personRemaining)
            {
                Console.WriteLine($"Name: {p.Name}, Age: {p.Age}, Salary: {p.Salary}");
            }
        }
    }
}
