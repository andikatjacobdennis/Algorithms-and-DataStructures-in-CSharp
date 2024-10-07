## Introduction

In this document, we will explore various data structures and algorithms that are essential for efficient programming in C#. Understanding these concepts will help you write better code, optimize performance, and solve complex problems effectively.

## Data Structures

### Arrays

Arrays are a collection of elements identified by index or key. They are used to store multiple values in a single variable. In C#, arrays are of fixed size and can hold elements of the same data type.

#### Example Declaration
```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
```

#### CRUD Operations on Arrays

##### 1. Create

To create or initialize an array in C#, you can use the following syntax:

```csharp
int[] numbers = new int[5]; // Creates an array of size 5
```

You can also initialize an array with values:

```csharp
int[] numbers = { 1, 2, 3, 4, 5 }; // Initializes with values
```

##### 2. Read

To read or access elements in an array, you use the index of the element. In C#, array indices are zero-based.

```csharp
int firstNumber = numbers[0]; // Accesses the first element (1)
int secondNumber = numbers[1]; // Accesses the second element (2)
```

You can also loop through an array to read all its elements:

```csharp
for (int i = 0; i < numbers.Length; i++) {
    Console.WriteLine(numbers[i]); // Prints each element
}
```

##### 3. Update

To update an element in an array, you simply assign a new value to the desired index:

```csharp
numbers[2] = 10; // Updates the third element (3) to 10
```

You can also loop through an array to update elements based on some condition:

```csharp
for (int i = 0; i < numbers.Length; i++) {
    if (numbers[i] % 2 == 0) {
        numbers[i] += 1; // Increments even numbers by 1
    }
}
```

##### 4. Delete

Since arrays in C# have a fixed size, you cannot directly delete an element. However, you can achieve the effect of deletion by shifting elements and reducing the size of the logical array:

```csharp
int indexToDelete = 1; // Index of element to delete (value 2)
for (int i = indexToDelete; i < numbers.Length - 1; i++) {
    numbers[i] = numbers[i + 1]; // Shift elements to the left
}

// Optionally, set the last element to a default value (e.g., 0)
numbers[numbers.Length - 1] = 0; // Assuming you want to set it to 0
```

#### Example of Full CRUD Operations

Here is a complete example demonstrating CRUD operations on an array:

```csharp
using System;

class Program {
    static void Main() {
        // Create
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Read
        Console.WriteLine("Original array:");
        for (int i = 0; i < numbers.Length; i++) {
            Console.WriteLine(numbers[i]);
        }

        // Update
        numbers[2] = 10; // Update third element (3) to 10
        Console.WriteLine("\nArray after update:");
        for (int i = 0; i < numbers.Length; i++) {
            Console.WriteLine(numbers[i]);
        }

        // Delete
        int indexToDelete = 1; // Index of element to delete (value 2)
        for (int i = indexToDelete; i < numbers.Length - 1; i++) {
            numbers[i] = numbers[i + 1]; // Shift elements to the left
        }
        Array.Resize(ref numbers, numbers.Length - 1); // Resize the array to remove last element
        Console.WriteLine("\nArray after deletion:");
        for (int i = 0; i < numbers.Length; i++) {
            Console.WriteLine(numbers[i]);
        }
    }
}
```

#### Output
When you run the above code, the output will be:

```
Original array:
1
2
3
4
5

Array after update:
1
2
10
4
5

Array after deletion:
1
10
4
5
```

### IEnumerable<T>

`IEnumerable<T>` is an interface that represents a collection of objects that can be enumerated. It is often used for working with collections like lists, arrays, and other data structures in a more flexible way compared to arrays. 

#### Example Declaration
You typically work with `IEnumerable<T>` when using collections like `List<T>`, but you can also create it from an array:

```csharp
using System;
using System.Collections.Generic;

IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
```

#### CRUD Operations on IEnumerable<T>

##### 1. Create

You can create a collection that implements `IEnumerable<T>` using various collection types, such as `List<T>`, `Array`, or `HashSet<T>`. Here’s how you can create a `List<T>`:

```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 }; // Create a List
IEnumerable<int> enumerableNumbers = numbers; // Cast List to IEnumerable
```

##### 2. Read

To read elements from an `IEnumerable<T>`, you can use a `foreach` loop:

```csharp
Console.WriteLine("Original collection:");
foreach (var number in enumerableNumbers) {
    Console.WriteLine(number);
}
```

You can also use LINQ (Language Integrated Query) to query the collection:

```csharp
var evenNumbers = enumerableNumbers.Where(n => n % 2 == 0);
Console.WriteLine("\nEven numbers:");
foreach (var number in evenNumbers) {
    Console.WriteLine(number);
}
```

##### 3. Update

Since `IEnumerable<T>` is a read-only interface, you cannot directly update elements. However, you can convert it to a more flexible collection type (like `List<T>`) to perform updates:

```csharp
// Convert IEnumerable to List to update elements
List<int> numbersList = new List<int>(enumerableNumbers);
numbersList[2] = 10; // Update the third element (3) to 10

// Recast back to IEnumerable if needed
enumerableNumbers = numbersList;
```

##### 4. Delete

Similar to updates, you cannot directly delete items from an `IEnumerable<T>`. However, you can create a new collection without the unwanted items or use a list for more dynamic operations:

```csharp
// Convert IEnumerable to List to delete elements
numbersList = new List<int>(enumerableNumbers);
numbersList.Remove(2); // Remove the element with value 2

// Recast back to IEnumerable if needed
enumerableNumbers = numbersList;
```

#### Example of Full CRUD Operations

Here is a complete example demonstrating CRUD operations using `IEnumerable<T>`:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main() {
        // Create
        List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };
        IEnumerable<int> enumerableNumbers = numbersList;

        // Read
        Console.WriteLine("Original collection:");
        foreach (var number in enumerableNumbers) {
            Console.WriteLine(number);
        }

        // Update
        numbersList[2] = 10; // Update the third element (3) to 10
        enumerableNumbers = numbersList; // Recast to IEnumerable
        Console.WriteLine("\nCollection after update:");
        foreach (var number in enumerableNumbers) {
            Console.WriteLine(number);
        }

        // Delete
        numbersList.Remove(2); // Remove the element with value 2
        enumerableNumbers = numbersList; // Recast to IEnumerable
        Console.WriteLine("\nCollection after deletion:");
        foreach (var number in enumerableNumbers) {
            Console.WriteLine(number);
        }
    }
}
```

#### Output
When you run the above code, the output will be:

```
Original collection:
1
2
3
4
5

Collection after update:
1
2
10
4
5

Collection after deletion:
1
10
4
5
```

Here's an explanation of how to perform CRUD (Create, Read, Update, Delete) operations using `IQueryable<T>` in C#. The `IQueryable<T>` interface is an extension of `IEnumerable<T>` and is used primarily for querying data from a data source, especially in the context of LINQ (Language Integrated Query) and Entity Framework.

### IQueryable<T>

`IQueryable<T>` is an interface that allows for querying data from a data source in a way that enables the execution of queries against a remote data source (like a database) while still providing the capabilities of LINQ. It provides a way to perform queries on data collections that may not be entirely loaded into memory, which makes it ideal for working with databases.

#### Example Declaration

You typically use `IQueryable<T>` when working with LINQ to SQL or Entity Framework. Here’s an example of declaring an `IQueryable<T>`:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

IQueryable<int> numbers = (new List<int> { 1, 2, 3, 4, 5 }).AsQueryable();
```

#### CRUD Operations on IQueryable<T>

##### 1. Create

Creating data usually involves adding new records to a data source. While `IQueryable<T>` itself doesn’t support adding items directly, you can perform the operation using the underlying data context or repository:

```csharp
using (var context = new YourDbContext()) {
    var newNumber = new Number { Value = 6 };
    context.Numbers.Add(newNumber); // Add the new record to the database
    context.SaveChanges(); // Save changes to the database
}
```

##### 2. Read

To read data from an `IQueryable<T>`, you can use LINQ queries to filter, sort, or group the data. This is one of the primary uses of `IQueryable<T>`:

```csharp
using (var context = new YourDbContext()) {
    IQueryable<Number> query = context.Numbers; // IQueryable from the database

    // Read all numbers
    var allNumbers = query.ToList(); // Executes the query

    // Read even numbers
    var evenNumbers = query.Where(n => n.Value % 2 == 0).ToList();
    Console.WriteLine("Even numbers:");
    foreach (var number in evenNumbers) {
        Console.WriteLine(number.Value);
    }
}
```

##### 3. Update

To update records, you must first retrieve them from the database, modify them, and then save the changes. Here's how to update an item:

```csharp
using (var context = new YourDbContext()) {
    var numberToUpdate = context.Numbers.First(n => n.Value == 3); // Fetch the number
    numberToUpdate.Value = 10; // Update the value
    context.SaveChanges(); // Save changes to the database
}
```

##### 4. Delete

To delete records, you similarly fetch the record from the database and then remove it:

```csharp
using (var context = new YourDbContext()) {
    var numberToDelete = context.Numbers.First(n => n.Value == 2); // Fetch the number
    context.Numbers.Remove(numberToDelete); // Remove the number
    context.SaveChanges(); // Save changes to the database
}
```

#### Example of Full CRUD Operations

Here is a complete example demonstrating CRUD operations using `IQueryable<T>` with an Entity Framework context:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore; // Make sure to add the required Entity Framework references

// Entity Class
public class Number {
    public int Id { get; set; }
    public int Value { get; set; }
}

// DbContext Class
public class YourDbContext : DbContext {
    public DbSet<Number> Numbers { get; set; }
}

class Program {
    static void Main() {
        // Ensure the database is created
        using (var context = new YourDbContext()) {
            context.Database.EnsureCreated();

            // Create
            context.Numbers.Add(new Number { Value = 1 });
            context.Numbers.Add(new Number { Value = 2 });
            context.Numbers.Add(new Number { Value = 3 });
            context.SaveChanges();
        }

        // Read
        using (var context = new YourDbContext()) {
            IQueryable<Number> query = context.Numbers;

            // Read all numbers
            var allNumbers = query.ToList(); // Executes the query
            Console.WriteLine("All Numbers:");
            foreach (var number in allNumbers) {
                Console.WriteLine(number.Value);
            }

            // Read even numbers
            var evenNumbers = query.Where(n => n.Value % 2 == 0).ToList();
            Console.WriteLine("\nEven Numbers:");
            foreach (var number in evenNumbers) {
                Console.WriteLine(number.Value);
            }
        }

        // Update
        using (var context = new YourDbContext()) {
            var numberToUpdate = context.Numbers.First(n => n.Value == 3); // Fetch the number
            numberToUpdate.Value = 10; // Update the value
            context.SaveChanges(); // Save changes to the database
        }

        // Delete
        using (var context = new YourDbContext()) {
            var numberToDelete = context.Numbers.First(n => n.Value == 2); // Fetch the number
            context.Numbers.Remove(numberToDelete); // Remove the number
            context.SaveChanges(); // Save changes to the database
        }
    }
}
```

### List<T>

`List<T>` is a generic collection that allows you to store a list of items of a specific type. It provides methods to manipulate the data, including adding, removing, and searching for elements. The `List<T>` is particularly useful when you need a collection that can grow and shrink in size dynamically.

#### Example Declaration

You can declare a `List<T>` as follows:

```csharp
using System;
using System.Collections.Generic;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
```

#### CRUD Operations on List<T>

##### 1. Create

To create new items in a `List<T>`, you can use the `Add()` method. This method appends an element to the end of the list.

```csharp
List<int> numbers = new List<int> { 1, 2, 3 };

// Create (Add new elements)
numbers.Add(4); // Adds 4 to the list
numbers.Add(5); // Adds 5 to the list
```

##### 2. Read

To read data from a `List<T>`, you can use various methods such as `Count`, indexing, and `ForEach()`:

```csharp
// Read all numbers
foreach (var number in numbers) {
    Console.WriteLine(number); // Outputs: 1, 2, 3, 4, 5
}

// Read a specific element using an index
int firstNumber = numbers[0]; // Gets the first element (1)
```

You can also use LINQ queries to filter the list:

```csharp
using System.Linq;

// Read even numbers using LINQ
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
Console.WriteLine("Even Numbers:");
foreach (var number in evenNumbers) {
    Console.WriteLine(number); // Outputs: 2, 4
}
```

##### 3. Update

To update an item, you can access it via its index and assign a new value:

```csharp
// Update the second element (index 1)
numbers[1] = 10; // Changes 2 to 10
```

##### 4. Delete

To delete an item, you can use the `Remove()` or `RemoveAt()` method. The `Remove()` method removes the first occurrence of a specific value, while `RemoveAt()` removes an element at a specified index:

```csharp
// Delete by value
numbers.Remove(10); // Removes 10 from the list

// Delete by index
numbers.RemoveAt(0); // Removes the first element (1)
```

#### Example of Full CRUD Operations

Here’s a complete example demonstrating CRUD operations using `List<T>`:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main() {
        // Create a List
        List<int> numbers = new List<int> { 1, 2, 3 };

        // Create: Adding new elements
        numbers.Add(4);
        numbers.Add(5);

        // Read: Display all numbers
        Console.WriteLine("All Numbers:");
        foreach (var number in numbers) {
            Console.WriteLine(number); // Outputs: 1, 2, 3, 4, 5
        }

        // Read: Using LINQ to find even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("\nEven Numbers:");
        foreach (var number in evenNumbers) {
            Console.WriteLine(number); // Outputs: 2, 4
        }

        // Update: Changing the second element
        numbers[1] = 10; // Changes 2 to 10
        Console.WriteLine("\nAfter Update:");
        foreach (var number in numbers) {
            Console.WriteLine(number); // Outputs: 1, 10, 3, 4, 5
        }

        // Delete: Removing a number by value and index
        numbers.Remove(10); // Removes 10 from the list
        numbers.RemoveAt(0); // Removes the first element (1)

        // Final state of the List
        Console.WriteLine("\nAfter Deletions:");
        foreach (var number in numbers) {
            Console.WriteLine(number); // Outputs: 3, 4, 5
        }
    }
}
```

### LinkedList<T>

`LinkedList<T>` is a generic collection that represents a doubly linked list, allowing for efficient insertion and removal of elements from any position in the list. Unlike arrays and `List<T>`, `LinkedList<T>` does not require contiguous memory allocation, making it more efficient for operations that involve frequent additions and deletions.

#### Example Declaration

You can declare a `LinkedList<T>` as follows:

```csharp
using System;
using System.Collections.Generic;

LinkedList<int> numbers = new LinkedList<int>();
```

#### CRUD Operations on LinkedList<T>

##### 1. Create

To create new items in a `LinkedList<T>`, you can use the `AddLast()` or `AddFirst()` method. The `AddLast()` method appends an element to the end of the list, while the `AddFirst()` method inserts an element at the beginning.

```csharp
LinkedList<int> numbers = new LinkedList<int>();

// Create (Add new elements)
numbers.AddLast(1); // Adds 1 to the end of the list
numbers.AddLast(2); // Adds 2 to the end of the list
numbers.AddFirst(0); // Adds 0 to the beginning of the list
```

##### 2. Read

To read data from a `LinkedList<T>`, you can use a `foreach` loop to iterate through the elements:

```csharp
// Read all numbers
Console.WriteLine("All Numbers:");
foreach (var number in numbers) {
    Console.WriteLine(number); // Outputs: 0, 1, 2
}
```

You can also access specific nodes using the `Find()` method:

```csharp
// Find a specific number
var foundNode = numbers.Find(1);
if (foundNode != null) {
    Console.WriteLine($"Found: {foundNode.Value}"); // Outputs: Found: 1
}
```

##### 3. Update

To update an item, you must first find the node, and then you can change its value:

```csharp
// Update a specific element
var nodeToUpdate = numbers.Find(1);
if (nodeToUpdate != null) {
    nodeToUpdate.Value = 10; // Changes 1 to 10
}
```

##### 4. Delete

To delete an item, you can use the `Remove()` method to remove a specific value or `RemoveFirst()`/`RemoveLast()` to remove the first or last element, respectively:

```csharp
// Delete by value
numbers.Remove(10); // Removes 10 from the list

// Delete the first and last elements
numbers.RemoveFirst(); // Removes 0
numbers.RemoveLast();  // Removes 2
```

#### Example of Full CRUD Operations

Here’s a complete example demonstrating CRUD operations using `LinkedList<T>`:

```csharp
using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        // Create a LinkedList
        LinkedList<int> numbers = new LinkedList<int>();

        // Create: Adding new elements
        numbers.AddLast(1);
        numbers.AddLast(2);
        numbers.AddFirst(0); // Adding to the front

        // Read: Display all numbers
        Console.WriteLine("All Numbers:");
        foreach (var number in numbers) {
            Console.WriteLine(number); // Outputs: 0, 1, 2
        }

        // Read: Find a specific number
        var foundNode = numbers.Find(1);
        if (foundNode != null) {
            Console.WriteLine($"Found: {foundNode.Value}"); // Outputs: Found: 1
        }

        // Update: Changing a specific element
        var nodeToUpdate = numbers.Find(1);
        if (nodeToUpdate != null) {
            nodeToUpdate.Value = 10; // Changes 1 to 10
        }

        Console.WriteLine("\nAfter Update:");
        foreach (var number in numbers) {
            Console.WriteLine(number); // Outputs: 0, 10, 2
        }

        // Delete: Removing a number by value
        numbers.Remove(10); // Removes 10 from the list

        // Delete the first and last elements
        numbers.RemoveFirst(); // Removes 0
        numbers.RemoveLast();  // Removes 2

        // Final state of the LinkedList
        Console.WriteLine("\nAfter Deletions:");
        foreach (var number in numbers) {
            Console.WriteLine(number); // Outputs: (no output, as the list is empty)
        }
    }
}
```

### Stack<T>

`Stack<T>` is a generic collection that allows you to store objects in a last-in, first-out order. This means that the last element added to the stack is the first one to be removed. It is ideal for scenarios where you need to keep track of a sequence of actions or states.

#### Example Declaration

You can declare a `Stack<T>` as follows:

```csharp
using System;
using System.Collections.Generic;

Stack<int> numbers = new Stack<int>();
```

#### CRUD Operations on Stack<T>

##### 1. Create

To create new items in a `Stack<T>`, you can use the `Push()` method, which adds an element to the top of the stack.

```csharp
// Create (Add new elements)
numbers.Push(1); // Adds 1 to the stack
numbers.Push(2); // Adds 2 to the stack
numbers.Push(3); // Adds 3 to the stack
```

##### 2. Read

To read data from a `Stack<T>`, you can use the `Peek()` method to view the top element without removing it, and the `Count` property to get the number of elements in the stack.

```csharp
// Read the top element
int topElement = numbers.Peek(); // Gets the top element (3)

// Read the number of elements in the stack
Console.WriteLine($"Number of elements in the stack: {numbers.Count}"); // Outputs: 3
```

##### 3. Update

To update an item in a `Stack<T>`, you typically have to remove the item, modify it, and then push it back onto the stack since stacks do not provide direct access to elements other than the top one. Here's how you can do it:

```csharp
// Update: Changing the top element
if (numbers.Count > 0) {
    int topElement = numbers.Pop(); // Remove the top element (3)
    topElement = 10; // Update the value
    numbers.Push(topElement); // Push the updated value back onto the stack
}
```

##### 4. Delete

To delete an item, you can use the `Pop()` method to remove the top element from the stack:

```csharp
// Delete the top element
int removedElement = numbers.Pop(); // Removes the top element (10)

// Check the number of elements after removal
Console.WriteLine($"Number of elements after pop: {numbers.Count}"); // Outputs: 2
```

#### Example of Full CRUD Operations

Here’s a complete example demonstrating CRUD operations using `Stack<T>`:

```csharp
using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        // Create a Stack
        Stack<int> numbers = new Stack<int>();

        // Create: Adding new elements
        numbers.Push(1);
        numbers.Push(2);
        numbers.Push(3);

        // Read: Display the top element
        int topElement = numbers.Peek();
        Console.WriteLine($"Top element: {topElement}"); // Outputs: 3

        // Read: Count the number of elements
        Console.WriteLine($"Number of elements in the stack: {numbers.Count}"); // Outputs: 3

        // Update: Changing the top element
        if (numbers.Count > 0) {
            topElement = numbers.Pop(); // Removes the top element (3)
            topElement = 10; // Update the value
            numbers.Push(topElement); // Push the updated value back onto the stack
        }

        Console.WriteLine("\nAfter Update:");
        Console.WriteLine($"Top element: {numbers.Peek()}"); // Outputs: 10

        // Delete: Removing the top element
        int removedElement = numbers.Pop(); // Removes the top element (10)

        Console.WriteLine("\nAfter Deletion:");
        Console.WriteLine($"Removed element: {removedElement}"); // Outputs: 10
        Console.WriteLine($"Number of elements after pop: {numbers.Count}"); // Outputs: 2
    }
}
```

### ConcurrentStack<T>

`ConcurrentStack<T>` is a thread-safe collection that allows multiple threads to add and remove items concurrently without needing additional synchronization. It is ideal for scenarios where multiple threads may be accessing and modifying the stack simultaneously.

#### Example Declaration

You can declare a `ConcurrentStack<T>` as follows:

```csharp
using System;
using System.Collections.Concurrent;

ConcurrentStack<int> numbers = new ConcurrentStack<int>();
```

#### CRUD Operations on ConcurrentStack<T>

##### 1. Create

To create new items in a `ConcurrentStack<T>`, you can use the `Push()` method, which adds an element to the top of the stack.

```csharp
// Create (Add new elements)
numbers.Push(1); // Adds 1 to the stack
numbers.Push(2); // Adds 2 to the stack
numbers.Push(3); // Adds 3 to the stack
```

##### 2. Read

To read data from a `ConcurrentStack<T>`, you can use the `TryPeek()` method to safely view the top element without removing it, and the `Count` property to get the number of elements in the stack.

```csharp
// Read the top element
if (numbers.TryPeek(out int topElement)) {
    Console.WriteLine($"Top element: {topElement}"); // Outputs: 3
}

// Read the number of elements in the stack
Console.WriteLine($"Number of elements in the stack: {numbers.Count}"); // Outputs: 3
```

##### 3. Update

To update an item in a `ConcurrentStack<T>`, you typically have to remove the item, modify it, and then push it back onto the stack since stacks do not provide direct access to elements other than the top one. Here’s how you can do it:

```csharp
// Update: Changing the top element
if (numbers.TryPop(out int poppedElement)) {
    // poppedElement now holds the value of the top element (3)
    poppedElement = 10; // Update the value
    numbers.Push(poppedElement); // Push the updated value back onto the stack
}
```

##### 4. Delete

To delete an item, you can use the `TryPop()` method to remove the top element from the stack safely.

```csharp
// Delete the top element
if (numbers.TryPop(out int removedElement)) {
    Console.WriteLine($"Removed element: {removedElement}"); // Outputs: 10
}

// Check the number of elements after removal
Console.WriteLine($"Number of elements after pop: {numbers.Count}"); // Outputs the remaining count
```

#### Example of Full CRUD Operations

Here’s a complete example demonstrating CRUD operations using `ConcurrentStack<T>`:

```csharp
using System;
using System.Collections.Concurrent;

class Program {
    static void Main() {
        // Create a ConcurrentStack
        ConcurrentStack<int> numbers = new ConcurrentStack<int>();

        // Create: Adding new elements
        numbers.Push(1);
        numbers.Push(2);
        numbers.Push(3);

        // Read: Display the top element
        if (numbers.TryPeek(out int topElement)) {
            Console.WriteLine($"Top element: {topElement}"); // Outputs: 3
        }

        // Read: Count the number of elements
        Console.WriteLine($"Number of elements in the stack: {numbers.Count}"); // Outputs: 3

        // Update: Changing the top element
        if (numbers.TryPop(out int poppedElement)) {
            poppedElement = 10; // Update the value
            numbers.Push(poppedElement); // Push the updated value back onto the stack
        }

        Console.WriteLine("\nAfter Update:");
        if (numbers.TryPeek(out topElement)) {
            Console.WriteLine($"Top element: {topElement}"); // Outputs: 10
        }

        // Delete: Removing the top element
        if (numbers.TryPop(out int removedElement)) {
            Console.WriteLine("\nAfter Deletion:");
            Console.WriteLine($"Removed element: {removedElement}"); // Outputs: 10
            Console.WriteLine($"Number of elements after pop: {numbers.Count}"); // Outputs the remaining count
        }
    }
}
```

### Queues

A queue is a collection of elements that follows the First In First Out (FIFO) principle. Elements are added at the back and removed from the front.

```csharp
public class Queue {
    private List<int> elements = new List<int>();

    public void Enqueue(int item) {
        elements.Add(item);
    }

    public int Dequeue() {
        int firstItem = elements[0];
        elements.RemoveAt(0);
        return firstItem;
    }
}
```

### Hash Tables

A hash table is a data structure that implements an associative array, a structure that can map keys to values.

```csharp
Dictionary<string, int> hashTable = new Dictionary<string, int>();
hashTable["one"] = 1;
hashTable["two"] = 2;
```

Here’s an overview of each tree type, including **Trees**, **Binary Trees**, **Binary Search Trees**, **Heaps**, and **Tries**, along with sample C# code snippets for each.

---

## Trees

A tree is a hierarchical data structure consisting of nodes, where each node contains a value and references to its child nodes. The topmost node is called the root, and each node can have zero or more child nodes. Trees are used in various applications, such as representing hierarchical data (e.g., file systems) and enabling efficient search operations.

```csharp
public class TreeNode {
    public int Value;
    public List<TreeNode> Children = new List<TreeNode>();
}
```

---

### Binary Trees

A binary tree is a specific type of tree where each node has at most two children, referred to as the left child and the right child. Binary trees are used in various algorithms and data structures, such as binary search trees and heaps.

```csharp
public class BinaryTreeNode {
    public int Value;
    public BinaryTreeNode Left;
    public BinaryTreeNode Right;

    public BinaryTreeNode(int value) {
        Value = value;
        Left = null;
        Right = null;
    }
}
```

### Binary Search Trees (BST)

A binary search tree is a binary tree with the additional property that for each node, all values in the left subtree are less than the node's value, and all values in the right subtree are greater. This property allows for efficient searching, insertion, and deletion operations.

```csharp
public class BinarySearchTree {
    public BinaryTreeNode Root;

    public void Insert(int value) {
        Root = InsertRec(Root, value);
    }

    private BinaryTreeNode InsertRec(BinaryTreeNode node, int value) {
        if (node == null) {
            return new BinaryTreeNode(value);
        }

        if (value < node.Value) {
            node.Left = InsertRec(node.Left, value);
        } else if (value > node.Value) {
            node.Right = InsertRec(node.Right, value);
        }

        return node;
    }

    public bool Search(int value) {
        return SearchRec(Root, value);
    }

    private bool SearchRec(BinaryTreeNode node, int value) {
        if (node == null) {
            return false;
        }

        if (value == node.Value) {
            return true;
        } else if (value < node.Value) {
            return SearchRec(node.Left, value);
        } else {
            return SearchRec(node.Right, value);
        }
    }
}
```

### Heaps

A heap is a special tree-based data structure that satisfies the heap property. In a max-heap, for any given node, the value of the node is greater than or equal to the values of its children, and in a min-heap, the value of the node is less than or equal to the values of its children. Heaps are commonly used in priority queues and sorting algorithms like heap sort.

```csharp
public class MinHeap {
    private List<int> elements = new List<int>();

    public void Insert(int value) {
        elements.Add(value);
        HeapifyUp(elements.Count - 1);
    }

    private void HeapifyUp(int index) {
        while (index > 0) {
            int parentIndex = (index - 1) / 2;
            if (elements[index] >= elements[parentIndex]) break;

            // Swap
            int temp = elements[index];
            elements[index] = elements[parentIndex];
            elements[parentIndex] = temp;
            index = parentIndex;
        }
    }

    public int ExtractMin() {
        if (elements.Count == 0) throw new InvalidOperationException("Heap is empty.");

        int min = elements[0];
        elements[0] = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        HeapifyDown(0);
        return min;
    }

    private void HeapifyDown(int index) {
        int leftChildIndex, rightChildIndex, smallestIndex;

        while (true) {
            leftChildIndex = 2 * index + 1;
            rightChildIndex = 2 * index + 2;
            smallestIndex = index;

            if (leftChildIndex < elements.Count && elements[leftChildIndex] < elements[smallestIndex]) {
                smallestIndex = leftChildIndex;
            }

            if (rightChildIndex < elements.Count && elements[rightChildIndex] < elements[smallestIndex]) {
                smallestIndex = rightChildIndex;
            }

            if (smallestIndex == index) break;

            // Swap
            int temp = elements[index];
            elements[index] = elements[smallestIndex];
            elements[smallestIndex] = temp;
            index = smallestIndex;
        }
    }
}
```

### Trie

A trie, or prefix tree, is a tree-like data structure used to store a dynamic set of strings, where the keys are usually strings. Tries are particularly useful for tasks involving retrieval of keys with a common prefix, such as autocomplete systems.

```csharp
public class TrieNode {
    public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    public bool IsEndOfWord;

    public TrieNode() {
        IsEndOfWord = false;
    }
}

public class Trie {
    private TrieNode root;

    public Trie() {
        root = new TrieNode();
    }

    public void Insert(string word) {
        TrieNode currentNode = root;

        foreach (char c in word) {
            if (!currentNode.Children.ContainsKey(c)) {
                currentNode.Children[c] = new TrieNode();
            }
            currentNode = currentNode.Children[c];
        }
        currentNode.IsEndOfWord = true;
    }

    public bool Search(string word) {
        TrieNode currentNode = root;

        foreach (char c in word) {
            if (!currentNode.Children.ContainsKey(c)) {
                return false;
            }
            currentNode = currentNode.Children[c];
        }
        return currentNode.IsEndOfWord;
    }

    public bool StartsWith(string prefix) {
        TrieNode currentNode = root;

        foreach (char c in prefix) {
            if (!currentNode.Children.ContainsKey(c)) {
                return false;
            }
            currentNode = currentNode.Children[c];
        }
        return true;
    }
}
```

### Graphs

A graph is a collection of nodes (vertices) and edges connecting them. It can be directed or undirected.

```csharp
public class Graph {
    private Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();

    public void AddEdge(int source, int destination) {
        if (!adjacencyList.ContainsKey(source)) {
            adjacencyList[source] = new List<int>();
        }
        adjacencyList[source].Add(destination);
    }
}
```

## Algorithms

## Sorting Algorithms

Sorting algorithms are methods for arranging the elements of a list or array in a specific order, typically in ascending or descending order. Different sorting algorithms have different characteristics in terms of complexity, efficiency, and stability.

### Bubble Sort

Bubble Sort is a simple sorting algorithm that repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order. The pass through the list is repeated until no swaps are needed, indicating that the list is sorted.

```csharp
public void BubbleSort(int[] array) {
    int n = array.Length;
    for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n - i - 1; j++) {
            if (array[j] > array[j + 1]) {
                // Swap
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}
```

### Selection Sort

Selection Sort is an in-place comparison sorting algorithm that divides the input list into two parts: a sorted and an unsorted section. It repeatedly selects the smallest (or largest) element from the unsorted section and moves it to the end of the sorted section.

```csharp
public void SelectionSort(int[] array) {
    int n = array.Length;
    for (int i = 0; i < n - 1; i++) {
        int minIndex = i;
        for (int j = i + 1; j < n; j++) {
            if (array[j] < array[minIndex]) {
                minIndex = j;
            }
        }
        // Swap
        if (minIndex != i) {
            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
    }
}
```

### Insertion Sort

Insertion Sort builds the final sorted array one item at a time. It takes each element from the input and finds the correct position for it in the sorted section by comparing it with the already sorted elements.

```csharp
public void InsertionSort(int[] array) {
    int n = array.Length;
    for (int i = 1; i < n; i++) {
        int key = array[i];
        int j = i - 1;
        
        // Move elements that are greater than key to one position ahead
        while (j >= 0 && array[j] > key) {
            array[j + 1] = array[j];
            j--;
        }
        array[j + 1] = key;
    }
}
```

### Merge Sort

Merge Sort is a divide-and-conquer algorithm that divides the unsorted list into n sublists, each containing one element, and then repeatedly merges sublists to produce new sorted sublists until there is only one sublist remaining.

```csharp
public void MergeSort(int[] array) {
    if (array.Length < 2) return;

    int mid = array.Length / 2;
    int[] left = new int[mid];
    int[] right = new int[array.Length - mid];

    Array.Copy(array, 0, left, 0, mid);
    Array.Copy(array, mid, right, 0, array.Length - mid);

    MergeSort(left);
    MergeSort(right);
    Merge(array, left, right);
}

private void Merge(int[] array, int[] left, int[] right) {
    int i = 0, j = 0, k = 0;

    while (i < left.Length && j < right.Length) {
        if (left[i] <= right[j]) {
            array[k++] = left[i++];
        } else {
            array[k++] = right[j++];
        }
    }

    while (i < left.Length) {
        array[k++] = left[i++];
    }

    while (j < right.Length) {
        array[k++] = right[j++];
    }
}
```

### Quick Sort

Quick Sort is another divide-and-conquer algorithm that selects a 'pivot' element from the array and partitions the other elements into two sub-arrays according to whether they are less than or greater than the pivot. The sub-arrays are then sorted recursively.

```csharp
public void QuickSort(int[] array, int low, int high) {
    if (low < high) {
        int pivotIndex = Partition(array, low, high);
        QuickSort(array, low, pivotIndex - 1);
        QuickSort(array, pivotIndex + 1, high);
    }
}

private int Partition(int[] array, int low, int high) {
    int pivot = array[high];
    int i = low - 1;

    for (int j = low; j < high; j++) {
        if (array[j] < pivot) {
            i++;
            // Swap
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    // Swap pivot
    int temp1 = array[i + 1];
    array[i + 1] = array[high];
    array[high] = temp1;

    return i + 1;
}
```

### Heap Sort

Heap Sort is a comparison-based sorting algorithm that uses a binary heap data structure. It first builds a max heap from the input data and then repeatedly extracts the maximum element from the heap and rebuilds the heap until no elements remain.

```csharp
public void HeapSort(int[] array) {
    int n = array.Length;

    // Build max heap
    for (int i = n / 2 - 1; i >= 0; i--) {
        Heapify(array, n, i);
    }

    // Extract elements from heap
    for (int i = n - 1; i > 0; i--) {
        // Move current root to end
        int temp = array[0];
        array[0] = array[i];
        array[i] = temp;

        // Call max heapify on the reduced heap
        Heapify(array, i, 0);
    }
}

private void Heapify(int[] array, int n, int i) {
    int largest = i;
    int left = 2 * i + 1;
    int right = 2 * i + 2;

    if (left < n && array[left] > array[largest]) {
        largest = left;
    }

    if (right < n && array[right] > array[largest]) {
        largest = right;
    }

    if (largest != i) {
        int temp = array[i];
        array[i] = array[largest];
        array[largest] = temp;

        Heapify(array, n, largest);
    }
}
```

### Searching Algorithms

#### Linear Search

Linear search is a simple search algorithm that checks every element in the list until the desired element is found.

```csharp
public int LinearSearch(int[] arr, int target) {
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] == target) return i;
    }
    
    return -1; // Not found
}
```

#### Binary Search

Binary search is a more efficient algorithm that works on sorted arrays by repeatedly dividing the search interval in half.

```csharp
public int BinarySearch(int[] arr, int target) {
    int left = 0, right = arr.Length - 1;

    while (left <= right) {
        int mid = left + (right - left) / 2;

        if (arr[mid] == target) return mid;

        if (arr[mid] < target) left = mid + 1;
        else right = mid - 1;
    }

    return -1; // Not found
}
```

### Graph Algorithms

#### Depth-First Search (DFS)

DFS is an algorithm for traversing or searching tree or graph data structures. It starts at the root and explores as far as possible along each branch before backtracking.

```csharp
public void DFS(int vertex, HashSet<int> visited) {
    visited.Add(vertex);
    
    foreach (var neighbor in adjacencyList[vertex]) {
        if (!visited.Contains(neighbor)) {
            DFS(neighbor, visited);
        }
    }
}
```

#### Breadth-First Search (BFS)

BFS is an algorithm for traversing or searching tree or graph data structures. It starts at the root and explores all neighbors at the present depth prior to moving on to nodes at the next depth level.

```csharp
public void BFS(int start) {
    Queue<int> queue = new Queue<int>();
    HashSet<int> visited = new HashSet<int>();

    queue.Enqueue(start);
    visited.Add(start);

    while (queue.Count > 0) {
        int vertex = queue.Dequeue();

        foreach (var neighbor in adjacencyList[vertex]) {
            if (!visited.Contains(neighbor)) {
                visited.Add(neighbor);
                queue.Enqueue(neighbor);
            }
        }
    }
}
```

#### Dijkstra's Algorithm

Dijkstra's algorithm finds the shortest path between nodes in a graph. It assigns a tentative distance value to every node and updates it as shorter paths are discovered.

```csharp
public int[] Dijkstra(int start) {
    var distances = new Dictionary<int, int>();
    var priorityQueue = new SortedSet<(int distance, int vertex)>();

    foreach (var vertex in adjacencyList.Keys) {
        distances[vertex] = int.MaxValue;
    }
    distances[start] = 0;
    priorityQueue.Add((0, start));

    while (priorityQueue.Count > 0) {
        var (currentDistance, currentVertex) = priorityQueue.Min;
        priorityQueue.Remove(priorityQueue.Min);

        foreach (var neighbor in adjacencyList[currentVertex]) {
            int newDistance = currentDistance + 1; // assuming all edges have weight 1

            if (newDistance < distances[neighbor]) {
                distances[neighbor] = newDistance;
                priorityQueue.Add((newDistance, neighbor));
            }
        }
    }

    return distances;
}
```

#### Bellman-Ford Algorithm

The Bellman-Ford algorithm computes the shortest paths from a single source vertex to all other vertices in a graph, handling graphs with negative weight edges.

```csharp
public void BellmanFord(int start) {
    Dictionary<int, int> distances = new Dictionary<int, int>();
    
    foreach (var vertex in adjacencyList.Keys) {
        distances[vertex] = int.MaxValue;
    }
    distances[start] = 0;

    foreach (var vertex in adjacencyList.Keys) {
        foreach (var neighbor in adjacencyList[vertex]) {
            // Assuming you have a way to get the weight of the edges
            int weight = 1; // replace with actual edge weight retrieval logic
            if (distances[vertex] + weight < distances[neighbor]) {
                distances[neighbor] = distances[vertex] + weight;
            }
        }
    }
}
```

#### Floyd-Warshall Algorithm

The Floyd-Warshall algorithm finds the shortest paths between all pairs of vertices in a weighted graph.

```csharp
public int[,] FloydWarshall(int vertexCount) {
    int[,] distances = new int[vertexCount, vertexCount];

    // Initialize distances
    for (int i = 0; i < vertexCount; i++) {
        for (int j = 0; j < vertexCount; j++) {
            distances[i, j] = (i == j) ? 0 : int.MaxValue;
        }
    }

    // Set distances for direct edges
    foreach (var vertex in adjacencyList.Keys) {
        foreach (var neighbor in adjacencyList[vertex]) {
            distances[vertex, neighbor] = 1; // assuming all edges have weight 1
        }
    }

    // Update distances
    for (int k = 0; k < vertexCount; k++) {
        for (int i = 0; i < vertexCount; i++) {
            for (int j = 0; j < vertexCount; j++) {
                if (distances[i, j] > distances[i, k] + distances[k, j]) {
                    distances[i, j] = distances[i, k] + distances[k, j];
                }
            }
        }
    }

    return distances;
}
```

#### Edmonds-Karp Algorithm

The Edmonds-Karp algorithm is an implementation of the Ford-Fulkerson method for computing the maximum flow in a flow network.

```csharp
public int EdmondsKarp(int source, int sink) {
    int maxFlow = 0;
    // Create a residual graph
    var residualGraph = new Dictionary<int, List<int>>();
    // Initialize capacities in the residual graph

    while (true) {
        var parent = new Dictionary<int, int>();
        var visited = new HashSet<int>();
        var queue = new Queue<int>();
        queue.Enqueue(source);
        visited.Add(source);

        while (queue.Count > 0) {
            int current = queue.Dequeue();
            if (current == sink) break;

            foreach (var neighbor in residualGraph[current]) {
                if (!visited.Contains(neighbor) && capacity[current, neighbor] > 0) {
                    parent[neighbor] = current;
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }

        // Check if we reached sink
        if (!visited.Contains(sink)) break;

        // Find the maximum flow through the path found
        int pathFlow = int.MaxValue;
        for (int v = sink; v != source; v = parent[v]) {
            int u = parent[v];
            pathFlow = Math.Min(pathFlow, capacity[u, v]);
        }

        // update residual capacities of the edges and reverse edges
        for (int v = sink; v != source; v = parent[v]) {
            int u = parent[v];
            capacity[u, v] -= pathFlow;
            capacity[v, u] += pathFlow;
        }

        maxFlow += pathFlow;
    }

    return maxFlow;
}
```

#### All Paths Algorithm

The All Paths algorithm finds all paths from a source vertex to a target vertex in a graph.

```csharp
public void FindAllPaths(int start, int target, List<int> path, List<List<int>> allPaths) {
    path.Add(start);

    if (start == target) {
        allPaths.Add(new List<int>(path));
    } else {
        foreach (var neighbor in adjacencyList[start]) {
            if (!path.Contains(neighbor)) {
                FindAllPaths(neighbor, target, path, allPaths);
            }
        }
    }

    path.RemoveAt(path.Count - 1);
}
```
