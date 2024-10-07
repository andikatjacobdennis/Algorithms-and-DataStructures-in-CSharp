- [Introduction](#introduction)
   * [Time and Space Complexity](#time-and-space-complexity)
      + [1. **O(1) - Constant Time / Space**](#1-o1-constant-time-space)
      + [2. **O(log n) - Logarithmic Time / Space**](#2-olog-n-logarithmic-time-space)
      + [3. **O(n) - Linear Time / Space**](#3-on-linear-time-space)
      + [4. **O(n log n) - Linearithmic Time / Space**](#4-on-log-n-linearithmic-time-space)
      + [5. **O(n²) - Quadratic Time / Space**](#5-on-quadratic-time-space)
      + [6. **O(2^n) - Exponential Time / Space**](#6-o2n-exponential-time-space)
      + [7. **O(n!) - Factorial Time / Space**](#7-on-factorial-time-space)
   * [Summary of Time and Space Complexities](#summary-of-time-and-space-complexities)
- [Data Structures](#data-structures)
   * [Arrays](#arrays)
      + [Example Declaration](#example-declaration)
      + [CRUD Operations on Arrays](#crud-operations-on-arrays)
         - [1. Create](#1-create)
         - [2. Read](#2-read)
         - [3. Update](#3-update)
         - [4. Delete](#4-delete)
      + [Example of Full CRUD Operations](#example-of-full-crud-operations)
      + [Output](#output)
      + [Get memory address of the array](#get-memory-address-of-the-array)
      + [2D Array](#2d-array)
      + [Jagged Array](#jagged-array)
      + [Matrix Multiplication](#matrix-multiplication)
   * [IEnumerable<T>](#ienumerable)
      + [Example Declaration](#example-declaration-1)
      + [CRUD Operations on IEnumerable<T>](#crud-operations-on-ienumerable)
         - [1. Create](#1-create-1)
         - [2. Read](#2-read-1)
         - [3. Update](#3-update-1)
         - [4. Delete](#4-delete-1)
      + [Example of Full CRUD Operations](#example-of-full-crud-operations-1)
      + [Output](#output-1)
   * [IQueryable<T>](#iqueryable)
      + [Example Declaration](#example-declaration-2)
      + [CRUD Operations on IQueryable<T>](#crud-operations-on-iqueryable)
         - [1. Create](#1-create-2)
         - [2. Read](#2-read-2)
         - [3. Update](#3-update-2)
         - [4. Delete](#4-delete-2)
      + [Example of Full CRUD Operations](#example-of-full-crud-operations-2)
   * [List<T>](#list)
      + [Example Declaration](#example-declaration-3)
      + [CRUD Operations on List<T>](#crud-operations-on-list)
         - [1. Create](#1-create-3)
         - [2. Read](#2-read-3)
         - [3. Update](#3-update-3)
         - [4. Delete](#4-delete-3)
      + [Example of Full CRUD Operations](#example-of-full-crud-operations-3)
   * [LinkedList<T>](#linkedlist)
      + [Example Declaration](#example-declaration-4)
      + [CRUD Operations on LinkedList<T>](#crud-operations-on-linkedlist)
         - [1. Create](#1-create-4)
         - [2. Read](#2-read-4)
         - [3. Update](#3-update-4)
         - [4. Delete](#4-delete-4)
      + [Example of Full CRUD Operations](#example-of-full-crud-operations-4)
   * [Stack<T>](#stack)
      + [Example Declaration](#example-declaration-5)
      + [CRUD Operations on Stack<T>](#crud-operations-on-stack)
         - [1. Create](#1-create-5)
         - [2. Read](#2-read-5)
         - [3. Update](#3-update-5)
         - [4. Delete](#4-delete-5)
      + [Example of Full CRUD Operations](#example-of-full-crud-operations-5)
   * [ConcurrentStack<T>](#concurrentstack)
      + [Example Declaration](#example-declaration-6)
      + [CRUD Operations on ConcurrentStack<T>](#crud-operations-on-concurrentstack)
         - [1. Create](#1-create-6)
         - [2. Read](#2-read-6)
         - [3. Update](#3-update-6)
         - [4. Delete](#4-delete-6)
      + [Example of Full CRUD Operations](#example-of-full-crud-operations-6)
   * [Queue<T>](#queue)
      + [Example Declaration](#example-declaration-7)
      + [CRUD Operations on Queue<T>](#crud-operations-on-queue)
         - [1. Create](#1-create-7)
         - [2. Read](#2-read-7)
         - [3. Update](#3-update-7)
         - [4. Delete](#4-delete-7)
      + [Example of Full CRUD Operations](#example-of-full-crud-operations-7)
   * [ConcurrentQueue<T>](#concurrentqueue)
      + [Example Declaration](#example-declaration-8)
      + [CRUD Operations on ConcurrentQueue<T>](#crud-operations-on-concurrentqueue)
         - [1. Create](#1-create-8)
         - [2. Read](#2-read-8)
         - [3. Update](#3-update-8)
         - [4. Delete](#4-delete-8)
      + [Example of Full CRUD Operations](#example-of-full-crud-operations-8)
   * [Dictionary<TKey, TValue>](#dictionary)
      + [Example Declaration](#example-declaration-9)
      + [CRUD Operations on Dictionary<TKey, TValue>](#crud-operations-on-dictionary)
         - [1. Create](#1-create-9)
         - [2. Read](#2-read-9)
         - [3. Update](#3-update-9)
         - [4. Delete](#4-delete-9)
      + [Example of Full CRUD Operations](#example-of-full-crud-operations-9)
   * [ConcurrentDictionary<TKey, TValue>](#concurrentdictionary)
      + [Example Declaration](#example-declaration-10)
      + [CRUD Operations on ConcurrentDictionary<TKey, TValue>](#crud-operations-on-concurrentdictionary)
         - [1. Create](#1-create-10)
         - [2. Read](#2-read-10)
         - [3. Update](#3-update-10)
         - [4. Delete](#4-delete-10)
      + [Example of Full CRUD Operations](#example-of-full-crud-operations-10)
   * [Trees](#trees)
      + [Binary Trees](#binary-trees)
      + [Binary Search Trees (BST)](#binary-search-trees-bst)
      + [Segment Tree / Interval Tree](#segment-tree-interval-tree)
      + [B-Trees](#b-trees)
      + [Heaps](#heaps)
      + [Trie](#trie)
   * [Graphs](#graphs)
- [Algorithms](#algorithms)
   * [Sorting Algorithms](#sorting-algorithms)
      + [Bubble Sort](#bubble-sort)
      + [Selection Sort](#selection-sort)
      + [Insertion Sort](#insertion-sort)
      + [Merge Sort](#merge-sort)
      + [Quick Sort](#quick-sort)
      + [Heap Sort](#heap-sort)
   * [Searching Algorithms](#searching-algorithms)
      + [Linear Search](#linear-search)
      + [Binary Search](#binary-search)
   * [**Inverted Index**](#inverted-index)
   * [**Bloom Filter**](#bloom-filter)
   * [**Caching Mechanisms**](#caching-mechanisms)
   * [**Matrix Factorization / Collaborative Filtering**](#matrix-factorization-collaborative-filtering)
   * [Graph Algorithms](#graph-algorithms)
      + [1. **Graph Representations**](#1-graph-representations)
      + [2. **Traversal Algorithms**](#2-traversal-algorithms)
      + [3. **Shortest Path Algorithms**](#3-shortest-path-algorithms)
      + [4. **Minimum Spanning Tree (MST) Algorithms**](#4-minimum-spanning-tree-mst-algorithms)
      + [5. **Network Flow Algorithms**](#5-network-flow-algorithms)
      + [6. **Cycle Detection**](#6-cycle-detection)
      + [7. **Topological Sorting**](#7-topological-sorting)
      + [8. **Graph Coloring Algorithms**](#8-graph-coloring-algorithms)
      + [9. **Strongly Connected Components (SCC) Algorithms**](#9-strongly-connected-components-scc-algorithms)
      + [10. **Bipartite Graph Algorithms**](#10-bipartite-graph-algorithms)
      + [11. **Eulerian and Hamiltonian Paths**](#11-eulerian-and-hamiltonian-paths)
      + [12. **Matching and Covering Algorithms**](#12-matching-and-covering-algorithms)
      + [13. **Planarity Testing**](#13-planarity-testing)
      + [14. **Graph Decomposition**](#14-graph-decomposition)
      + [15. **Randomized and Approximation Algorithms**](#15-randomized-and-approximation-algorithms)

## Introduction

In this document, we will explore various data structures and algorithms that are essential for efficient programming in C#. Understanding these concepts will help you write better code, optimize performance, and solve complex problems effectively.

### Time and Space Complexity

Time Complexity and Space Complexity are fundamental concepts in computer science and algorithm analysis, crucial for understanding the efficiency of algorithms. These concepts help developers evaluate how algorithms perform as the size of the input data increases, guiding them in choosing the right algorithms for their applications.

#### 1. O(1) - Constant Time / Space

- **Time Complexity Example:**
  ```csharp
  int GetFirstElement(int[] arr)
  {
      return arr[0]; // Accessing the first element
  }
  ```

  **Time Complexity Calculation:**
  - The operation is performed in a fixed amount of time regardless of the size of the input array. 
  - Thus, time complexity is `O(1)`.

- **Space Complexity Example:**
  ```csharp
  void PrintFirstElement(int[] arr)
  {
      Console.WriteLine(arr[0]); // Constant space usage
  }
  ```

  **Space Complexity Calculation:**
  - Only a constant amount of space is used for the output, irrespective of the input size.
  - Thus, space complexity is `O(1)`.

#### 2. O(log n) - Logarithmic Time / Space

- **Time Complexity Example:**
  ```csharp
  int BinarySearch(int[] arr, int target)
  {
      int left = 0, right = arr.Length - 1;
      while (left <= right)
      {
          int mid = left + (right - left) / 2;
          if (arr[mid] == target) return mid;
          else if (arr[mid] < target) left = mid = 1;
          else right = mid - 1;
      }
      return -1; // Not found
  }
  ```

  **Time Complexity Calculation:**
  - Each iteration halves the search space until the target is found or the search space is exhausted.
  - The number of iterations can be approximated as:
  
  ```math
  T(n) = \log_2(n)
  ```
  - Thus, time complexity is `O(log n)`.

- **Space Complexity Example:**
  ```csharp
  int LogExample(int n)
  {
      if (n <= 1) return 1;
      return LogExample(n / 2) + 1; // Recursive call
  }
  ```

  **Space Complexity Calculation:**
  - The recursion stack grows with each call, and the depth of recursion is approximately `log n`.
  - Thus, space complexity is `O(log n)`.

#### 3. O(n) - Linear Time / Space

- **Time Complexity Example:**
  ```csharp
  int LinearSearch(int[] arr, int target)
  {
      for (int i = 0; i < arr.Length; i++)
      {
          if (arr[i] == target) return i;
      }
      return -1; // Not found
  }
  ```

  **Time Complexity Calculation:**
  - In the worst case, each element is checked until the target is found, leading to:
  
  ```math
  T(n) = n
  ```
  - Thus, time complexity is `O(n)`.

- **Space Complexity Example:**
  ```csharp
  int[] CreateArray(int n)
  {
      int[] arr = new int[n]; // Allocate space for n elements
      return arr;
  }
  ```

  **Space Complexity Calculation:**
  - An array of size `n` is created, leading to:
  
  ```math
  S(n) = n
  ```
  - Thus, space complexity is `O(n)`.

#### 4. O(n log n) - Linearithmic Time / Space

- **Time Complexity Example:**
  ```csharp
  void MergeSort(int[] arr)
  {
      if (arr.Length <= 1) return;

      int mid = arr.Length / 2;
      int[] left = new int[mid];
      int[] right = new int[arr.Length - mid];

      Array.Copy(arr, left, mid);
      Array.Copy(arr, mid, right, 0, arr.Length - mid);

      MergeSort(left);
      MergeSort(right);
      Merge(arr, left, right);
  }
  ```

  **Time Complexity Calculation:**
  - The merging step takes `O(n)` and the number of levels in the recursion tree is `log n`:
  
  ```math
  T(n) = n \log_2(n)
  ```
  - Thus, time complexity is `O(n log n)`.

- **Space Complexity Example:**
  ```csharp
  void Merge(int[] arr, int[] left, int[] right)
  {
      int i = 0, j = 0, k = 0;
      while (i < left.Length && j < right.Length)
      {
          if (left[i] <= right[j]) arr[k++] = left[i++];
          else arr[k++] = right[j++];
      }
      while (i < left.Length) arr[k++] = left[i++];
      while (j < right.Length) arr[k++] = right[j++];
  }
  ```

  **Space Complexity Calculation:**
  - The left and right subarrays require additional space of `O(n)`. Thus, space complexity remains `O(n)`.

#### 5. O(n²) - Quadratic Time / Space

- **Time Complexity Example:**
  ```csharp
  void BubbleSort(int[] arr)
  {
      for (int i = 0; i < arr.Length - 1; i++)
      {
          for (int j = 0; j < arr.Length - i - 1; j++)
          {
              if (arr[j] > arr[j + 1])
              {
                  // Swap
                  int temp = arr[j];
                  arr[j] = arr[j + 1];
                  arr[j + 1] = temp;
              }
          }
      }
  }
  ```

  **Time Complexity Calculation:**
  - The outer loop runs `n` times, and for each iteration, the inner loop runs `n-i-1` times:
  
  ```math
  T(n) = \sum_{i=0}^{n-1} (n - i - 1) = \frac{n(n-1)}{2}
  ```
  - Thus, time complexity is `O(n²)`.

- **Space Complexity Example:**
  ```csharp
  void MatrixMultiplication(int[,] A, int[,] B, int[,] C, int n)
  {
      for (int i = 0; i < n; i++)
      {
          for (int j = 0; j < n; j++)
          {
              C[i, j] = 0;
              for (int k = 0; k < n; k++)
              {
                  C[i, j] += A[i, k] * B[k, j];
              }
          }
      }
  }
  ```

  **Space Complexity Calculation:**
  - The matrix multiplication algorithm uses `O(1)` additional space apart from the input matrices.
  - Thus, space complexity is `O(1)`.

#### 6. O(2^n) - Exponential Time / Space

- **Time Complexity Example:**
  ```csharp
  int Fibonacci(int n)
  {
      if (n <= 1) return n;
      return Fibonacci(n - 1) + Fibonacci(n - 2); // Recursive calls
  }
  ```

  **Time Complexity Calculation:**
  - The number of calls doubles with each increase in `n`, leading to:
  
  ```math
  T(n) = 2^n
  ```
  - Thus, time complexity is `O(2^n)`.

- **Space Complexity Example:**
  ```csharp
  int FibonacciWithStack(int n)
  {
      if (n <= 1) return n;
      return FibonacciWithStack(n - 1) + FibonacciWithStack(n - 2);
  }
  ```

  **Space Complexity Calculation:**
  - The maximum depth of the recursion stack can go up to `n`, leading to:
  
  ```math
  S(n) = n
  ```
  - Thus, space complexity is `O(n)`.

#### 7. O(n!) - Factorial Time / Space

- **Time Complexity Example:**
  ```csharp
  void Permute(int[] arr, int l, int r)
  {
      if (l == r)
      {
          Console.WriteLine(string.Join(", ", arr)); // Print permutation
      }
      else
      {
          for (int i = l; i <= r; i++)
          {
              Swap(ref arr[l], ref arr[i]);
              Permute(arr, l + 1, r);
              Swap(ref arr[l], ref arr[i]); // Backtrack
          }
      }
  }

  void Swap(ref int a, ref int b)
  {
      int temp = a;
      a = b;
      b = temp;
  }
  ```

  **Time Complexity Calculation:**
  - The number of permutations of `n` elements is `n!`, leading to:
  
  ```math
  T(n) = n!
  ```
  - Thus, time complexity is `O(n!)`.

- **Space Complexity Example:**
  - The space complexity for storing all permutations is significant, but if we consider the recursion stack, it can reach `n` levels deep.

  **Space Complexity Calculation:**
  - The space used by the recursion stack is:
  
  ```math
  S(n) = n
  ```
  - Thus, space complexity is `O(n)`.

### Summary of Time and Space Complexities

| Notation   | Name                  | Time Complexity                  | Space Complexity |
|------------|-----------------------|----------------------------------|---------------------------------|
| O(1)       | Constant              | Fixed time                       | Constant                        |
| O(log n)   | Logarithmic           | Decreases exponentially          | Logarithmic                    |
| O(n)       | Linear                | Linear                           | Linear                          |
| O(n log n) | Linearithmic          | Linearithmic                    | Linear (or Linearithmic in some cases) |
| O(n²)      | Quadratic             | Quadratic                       | Constant                        |
| O(2^n)     | Exponential           | Exponential                     | Linear                          |
| O(n!)      | Factorial             | Factorial                       | Linear                          |

## Data Structures

### Arrays

Arrays are a collection of elements identified by index or key. They are used to store multiple values in a single variable. In C#, arrays are of fixed size and can hold elements of the same data type. Arrays are reference types. This means that when you create an array, the variable you assign the array to holds a reference (or pointer) to the actual memory location where the array elements are stored. The elements themselves can be value types or reference types, but the array itself is a reference type.

**Use Cases:**
- **Fixed Product Catalog**: Use arrays to store a fixed list of products, such as the days of a sale event.
- **Sales Data for Specific Periods**: Store sales data for a specific month where the number of entries is known beforehand.
- **Product Attributes**: Maintain attributes of a product (e.g., dimensions) that do not change frequently.

**Where Not to Use**: Avoid using arrays when you need to frequently add or remove products, as resizing an array requires creating a new one and copying elements.

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

####

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

#### Get memory address of the array

You will need to enable unsafe code in your project settings to compile this:
1. Right-click on your project in Visual Studio.
2. Go to **Properties**.
3. In the **Build** tab, check **Allow unsafe code**.

```csharp
using System;

unsafe class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        fixed (int* p = array)
        {
            Console.WriteLine($"Memory address of array: {(long)p}");
        }
    }
}
```

#### 2D Array

```csharp
using System;

class Program
{
    static void Main()
    {
        // Declare and initialize a 2D array with 3 rows and 4 columns
        int[,] array2D = new int[3, 4]
        {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

        // Get the number of rows and columns
        int rows = array2D.GetLength(0); // Number of rows
        int columns = array2D.GetLength(1); // Number of columns

        // Print the 2D array
        Console.WriteLine("2D Array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array2D[i, j] + "\t");
            }
            Console.WriteLine(); // New line after each row
        }
    }
}
```

#### Jagged Array

A jagged array in C# is an array of arrays, where each "sub-array" can have a different size. It's sometimes called an "array of arrays."

```csharp
using System;

class Program
{
    static void Main()
    {
        // Declare and initialize a jagged array with 3 arrays of different lengths
        int[][] jaggedArray = new int[3][];
        
        // Initialize each "sub-array" separately
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        // Print the jagged array
        Console.WriteLine("Jagged Array:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + "\t");
            }
            Console.WriteLine(); // New line after each sub-array
        }
    }
}
```

#### Matrix Multiplication

```csharp
using System;

class Program
{
    static void Main()
    {
        // Define two matrices to multiply
        int[,] matrixA = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
        
        int[,] matrixB = {
            { 7, 8 },
            { 9, 10 },
            { 11, 12 }
        };

        // Get the dimensions of the matrices
        int rowsA = matrixA.GetLength(0); // Number of rows in matrix A
        int colsA = matrixA.GetLength(1); // Number of columns in matrix A
        int rowsB = matrixB.GetLength(0); // Number of rows in matrix B
        int colsB = matrixB.GetLength(1); // Number of columns in matrix B

        // Check if the matrices can be multiplied
        if (colsA != rowsB)
        {
            Console.WriteLine("Matrix multiplication is not possible.");
            return;
        }

        // Initialize the result matrix with the appropriate size
        int[,] resultMatrix = new int[rowsA, colsB];

        // Perform matrix multiplication
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                for (int k = 0; k < colsA; k++)
                {
                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        // Print the resulting matrix
        Console.WriteLine("Resulting Matrix after multiplication:");
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                Console.Write(resultMatrix[i, j] + "\t");
            }
            Console.WriteLine(); // New line after each row
        }
    }
}
```

### IEnumerable<T>

`IEnumerable<T>` is an interface that represents a collection of objects that can be enumerated. It is often used for working with collections like lists, arrays, and other data structures in a more flexible way compared to arrays. 

**Use Cases:**
- **Lazy Loading of Products**: Use IEnumerable to fetch products from a database only when needed, improving performance and memory usage.
- **Filtering Sales Data**: Apply LINQ queries to filter sales data based on various criteria (e.g., sales above a certain threshold).
- **Streaming Data Processing**: Process large datasets of sales transactions without loading them entirely into memory.

**Where Not to Use**: Avoid using IEnumerable when you need to access elements by index or require multiple passes over the collection, as it can lead to inefficiencies.

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

### IQueryable<T>

`IQueryable<T>` is an interface that allows for querying data from a data source in a way that enables the execution of queries against a remote data source (like a database) while still providing the capabilities of LINQ. It provides a way to perform queries on data collections that may not be entirely loaded into memory, which makes it ideal for working with databases.

**Use Cases:**
- **Dynamic Sales Queries**: Utilize IQueryable for querying product sales data from a database, allowing for efficient filtering and sorting.
- **Remote Data Access**: Ideal for accessing sales data from remote sources where only necessary records should be retrieved.
- **Complex Reporting**: Create complex reports by chaining multiple query operations on sales data.

**Where Not to Use**: Avoid using IQueryable for in-memory collections where immediate execution is required, as it can complicate the code unnecessarily.

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

**Use Cases:**
- **Dynamic Product Lists**: Use lists to maintain a dynamic list of products that can be easily modified (added/removed).
- **Sales Transactions History**: Store a history of sales transactions where entries are frequently added and removed.
- **Customer Orders Management**: Maintain customer orders in a list for easy access and manipulation.

**Where Not to Use**: Avoid using lists when you need constant-time access by index, as they may have performance overhead compared to arrays.
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

**Use Cases:**
- **Order Processing Queue**: Use linked lists to manage orders that require frequent insertions and deletions at both ends.
- **Undo Functionality in Sales Applications**: Implement an undo feature in applications that allow users to revert changes easily.
- **Dynamic Product Bundles Management**: Maintain product bundles where items can be added or removed dynamically.

**Where Not to Use**: Avoid linked lists when random access is needed, as accessing elements requires traversing the list from the head.

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

**Use Cases:**
- **Sales Order Processing Stack**: Manage pending sales orders using a stack structure for last-in-first-out processing.
- **Function Call Management in Sales Systems**: Track function calls related to sales operations, such as discounts applied during checkout.
- **Backtracking Sales Decisions**: Implement backtracking features in decision-making processes related to pricing or promotions.

**Where Not to Use**: Avoid using stacks when you need random access or frequent modifications at arbitrary positions within the collection.

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

**Use Cases:**
- **Thread-Safe Order Management System**: Manage orders concurrently in multi-threaded applications without locks.
- **Task Scheduling in Sales Applications**: Handle tasks that can be processed in parallel while maintaining order of execution.
- **Real-Time Inventory Updates**: Update inventory levels concurrently as sales occur across multiple threads.

**Where Not to Use**: Avoid using ConcurrentStack when thread safety is not required, as it introduces unnecessary overhead compared to non-thread-safe stacks.

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

### Queue<T>

A `Queue<T>` represents a collection designed to hold a sequence of elements in the order they were added. Items are added to the end and removed from the front, following the FIFO (First-In, First-Out) principle.

**Use Cases:**
- **Customer Service Requests Handling**: Manage incoming customer service requests in a first-in-first-out manner.
- **Sales Lead Management System**: Organize leads that need follow-up based on their arrival time.
- **Event Scheduling for Promotions**: Schedule promotional events based on their order of creation.

**Where Not to Use**: Avoid queues when you need random access or frequent modifications at arbitrary positions within the collection.

#### Example Declaration

You can declare a `Queue<T>` as follows:

```csharp
Queue<int> numbers = new Queue<int>();
```

#### CRUD Operations on Queue<T>

##### 1. Create

To create new items in a `Queue<T>`, you use the `Enqueue()` method, which adds an element to the end of the queue.

```csharp
// Create (Add new elements)
numbers.Enqueue(1); // Adds 1 to the queue
numbers.Enqueue(2); // Adds 2 to the queue
numbers.Enqueue(3); // Adds 3 to the queue
```

##### 2. Read

To read data from a `Queue<T>`, you can use the `Peek()` method to view the front element without removing it. The `Count` property allows you to check the number of elements in the queue.

```csharp
// Read the front element
int frontElement = numbers.Peek();
Console.WriteLine($"Front element: {frontElement}"); // Outputs: 1

// Read the number of elements in the queue
Console.WriteLine($"Number of elements in the queue: {numbers.Count}"); // Outputs: 3
```

##### 3. Update

`Queue<T>` does not directly support updating elements because you can only access the front element. If you want to update an element, you would typically need to dequeue elements until you reach the one you want to modify, change it, and re-enqueue the rest of the elements.

Here’s a workaround to update an element in the queue:

```csharp
// Update the front element
if (numbers.Count > 0) {
    // Remove the front element
    int removedElement = numbers.Dequeue();
    
    // Modify the removed element
    removedElement = 10;

    // Re-add the updated element
    numbers.Enqueue(removedElement);
}

// Note: The updated element will be added at the end of the queue.
```

If you want to update a specific item in the queue (other than the front element), it may require dequeuing and re-enqueuing all items, which is inefficient in most scenarios.

##### 4. Delete

To delete an item from the queue, you use the `Dequeue()` method, which removes and returns the front element of the queue.

```csharp
// Delete the front element
int removedElement = numbers.Dequeue();
Console.WriteLine($"Removed element: {removedElement}"); // Outputs: 1

// Check the number of elements after removal
Console.WriteLine($"Number of elements after dequeue: {numbers.Count}"); // Outputs: 2
```

#### Example of Full CRUD Operations

Here’s a complete example demonstrating CRUD operations using `Queue<T>`:

```csharp
using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        // Create a Queue
        Queue<int> numbers = new Queue<int>();

        // Create: Adding new elements
        numbers.Enqueue(1);
        numbers.Enqueue(2);
        numbers.Enqueue(3);

        // Read: Display the front element
        int frontElement = numbers.Peek();
        Console.WriteLine($"Front element: {frontElement}"); // Outputs: 1

        // Read: Count the number of elements
        Console.WriteLine($"Number of elements in the queue: {numbers.Count}"); // Outputs: 3

        // Update: Modify the front element
        if (numbers.Count > 0) {
            int removedElement = numbers.Dequeue();
            removedElement = 10; // Update the value
            numbers.Enqueue(removedElement); // Add the updated value back at the end of the queue
        }

        Console.WriteLine("\nAfter Update:");
        frontElement = numbers.Peek();
        Console.WriteLine($"Front element: {frontElement}"); // Outputs: 2

        // Delete: Removing the front element
        removedElement = numbers.Dequeue();
        Console.WriteLine("\nAfter Deletion:");
        Console.WriteLine($"Removed element: {removedElement}"); // Outputs: 2
        Console.WriteLine($"Number of elements after dequeue: {numbers.Count}"); // Outputs: 1
    }
}
```

### ConcurrentQueue<T>

`ConcurrentQueue<T>` is a thread-safe collection that allows multiple threads to safely add and remove items without additional locking mechanisms. Like a standard queue, it follows the FIFO (First-In, First-Out) principle.

**Use Cases:**
- **Thread-Safe Lead Processing System**: Safely manage leads being processed by multiple agents concurrently.
- **Real-Time Sales Notifications Handling**: Handle notifications about sales events across multiple threads without locking issues.
- **Task Management in Multi-threaded Environments**: Efficiently manage tasks that require concurrent processing without losing order.

**Where Not to Use**: Avoid using ConcurrentQueue if thread safety is unnecessary, as it may lead to performance overhead compared to standard queues.

#### Example Declaration

You can declare a `ConcurrentQueue<T>` as follows:

```csharp
ConcurrentQueue<int> numbers = new ConcurrentQueue<int>();
```

#### CRUD Operations on ConcurrentQueue<T>

##### 1. Create

To create new items in a `ConcurrentQueue<T>`, you use the `Enqueue()` method, which adds an element to the end of the queue.

```csharp
// Create (Add new elements)
numbers.Enqueue(1); // Adds 1 to the queue
numbers.Enqueue(2); // Adds 2 to the queue
numbers.Enqueue(3); // Adds 3 to the queue
```

##### 2. Read

To read data from a `ConcurrentQueue<T>`, you can use the `TryPeek()` method to view the front element without removing it. The `Count` property allows you to check the number of elements in the queue.

```csharp
// Read the front element
if (numbers.TryPeek(out int frontElement)) {
    Console.WriteLine($"Front element: {frontElement}"); // Outputs: 1
}

// Read the number of elements in the queue
Console.WriteLine($"Number of elements in the queue: {numbers.Count}"); // Outputs: 3
```

##### 3. Update

`ConcurrentQueue<T>` does not directly support updating elements since you can only access the front element. If you want to update an element, you would typically need to dequeue elements until you reach the one you want to modify, change it, and re-enqueue the rest of the elements.

Here’s a workaround to update an element in the queue:

```csharp
// Update the front element
if (numbers.TryDequeue(out int removedElement)) {
    // Modify the removed element
    removedElement = 10;

    // Re-add the updated element
    numbers.Enqueue(removedElement);
}

// Note: The updated element will be added at the end of the queue.
```

If you want to update a specific item in the queue (other than the front element), it may require dequeuing and re-enqueuing all items, which is inefficient in most scenarios.

##### 4. Delete

To delete an item from the queue, you use the `TryDequeue()` method, which removes and returns the front element of the queue if it exists.

```csharp
// Delete the front element
if (numbers.TryDequeue(out int removedElement)) {
    Console.WriteLine($"Removed element: {removedElement}"); // Outputs: 1
}

// Check the number of elements after removal
Console.WriteLine($"Number of elements after dequeue: {numbers.Count}"); // Outputs: 2
```

#### Example of Full CRUD Operations

Here’s a complete example demonstrating CRUD operations using `ConcurrentQueue<T>`:

```csharp
using System;
using System.Collections.Concurrent;

class Program {
    static void Main() {
        // Create a ConcurrentQueue
        ConcurrentQueue<int> numbers = new ConcurrentQueue<int>();

        // Create: Adding new elements
        numbers.Enqueue(1);
        numbers.Enqueue(2);
        numbers.Enqueue(3);

        // Read: Display the front element
        if (numbers.TryPeek(out int frontElement)) {
            Console.WriteLine($"Front element: {frontElement}"); // Outputs: 1
        }

        // Read: Count the number of elements
        Console.WriteLine($"Number of elements in the queue: {numbers.Count}"); // Outputs: 3

        // Update: Modify the front element
        if (numbers.TryDequeue(out int removedElement)) {
            removedElement = 10; // Update the value
            numbers.Enqueue(removedElement); // Add the updated value back at the end of the queue
        }

        Console.WriteLine("\nAfter Update:");
        if (numbers.TryPeek(out frontElement)) {
            Console.WriteLine($"Front element: {frontElement}"); // Outputs: 2
        }

        // Delete: Removing the front element
        if (numbers.TryDequeue(out removedElement)) {
            Console.WriteLine("\nAfter Deletion:");
            Console.WriteLine($"Removed element: {removedElement}"); // Outputs: 2
            Console.WriteLine($"Number of elements after dequeue: {numbers.Count}"); // Outputs: 1
        }
    }
}
```

### Dictionary<TKey, TValue>

A `Dictionary<TKey, TValue>` is a collection that stores key-value pairs, where each key must be unique. It provides efficient retrieval of values based on their associated keys.

**Use Cases:** 
- **Product Lookup by ID or Name:** Quickly retrieve product details based on unique identifiers like SKU or product name.
- **Sales Data Aggregation:** Store aggregated sales data where keys represent products and values represent total sales figures.
- **Configuration Settings Storage:** Maintain application settings where each setting can be accessed via a unique key.

**Where Not to Use:** Avoid dictionaries when order matters since they do not maintain any specific order of elements.

#### Example Declaration

You can declare a `Dictionary<TKey, TValue>` as follows:

```csharp
Dictionary<int, string> students = new Dictionary<int, string>();
```

#### CRUD Operations on Dictionary<TKey, TValue>

##### 1. Create

To add new key-value pairs to a `Dictionary<TKey, TValue>`, you use the `Add()` method or the indexer.

```csharp
// Create (Add new key-value pairs)
students.Add(1, "Alice"); // Adds a new entry with key 1 and value "Alice"
students[2] = "Bob"; // Adds a new entry with key 2 and value "Bob"
```

##### 2. Read

To read data from a `Dictionary<TKey, TValue>`, you can use the indexer to access a value by its key. The `TryGetValue()` method allows you to check if a key exists and retrieve the corresponding value.

```csharp
// Read the value for a specific key
if (students.TryGetValue(1, out string studentName)) {
    Console.WriteLine($"Student with ID 1: {studentName}"); // Outputs: Alice
}

// Read all key-value pairs
foreach (var kvp in students) {
    Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
}
```

##### 3. Update

To update an existing value in the dictionary, you can use the indexer to set the value for a specific key.

```csharp
// Update the value for an existing key
if (students.ContainsKey(1)) {
    students[1] = "Alice Johnson"; // Updates the name for key 1
}

// Check the updated value
Console.WriteLine($"Updated student with ID 1: {students[1]}"); // Outputs: Alice Johnson
```

##### 4. Delete

To delete a key-value pair from the dictionary, you use the `Remove()` method, which removes the entry with the specified key.

```csharp
// Delete a key-value pair
if (students.Remove(2)) {
    Console.WriteLine("Student with ID 2 has been removed.");
}

// Check the number of entries after removal
Console.WriteLine($"Number of students after removal: {students.Count}"); // Outputs: 1
```

#### Example of Full CRUD Operations

Here’s a complete example demonstrating CRUD operations using `Dictionary<TKey, TValue>`:

```csharp
using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        // Create a Dictionary
        Dictionary<int, string> students = new Dictionary<int, string>();

        // Create: Adding new key-value pairs
        students.Add(1, "Alice");
        students[2] = "Bob";

        // Read: Display a specific student's name
        if (students.TryGetValue(1, out string studentName)) {
            Console.WriteLine($"Student with ID 1: {studentName}"); // Outputs: Alice
        }

        // Read: Display all students
        Console.WriteLine("\nAll students:");
        foreach (var kvp in students) {
            Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
        }

        // Update: Modify an existing student's name
        if (students.ContainsKey(1)) {
            students[1] = "Alice Johnson"; // Update the name for key 1
        }

        Console.WriteLine("\nAfter Update:");
        Console.WriteLine($"Updated student with ID 1: {students[1]}"); // Outputs: Alice Johnson

        // Delete: Remove a student
        if (students.Remove(2)) {
            Console.WriteLine("\nStudent with ID 2 has been removed.");
        }

        // Check the number of entries after removal
        Console.WriteLine($"Number of students after removal: {students.Count}"); // Outputs: 1
    }
}
```

### ConcurrentDictionary<TKey, TValue>

`ConcurrentDictionary<TKey, TValue>` is a collection that stores key-value pairs, where each key must be unique. It is designed to handle multi-threaded scenarios, allowing safe access and modification of the dictionary from multiple threads without the need for external synchronization.

**Use Cases:** 
- **Thread-Safe Product Inventory Management:** Safely manage inventory levels across multiple threads without risking data corruption.
- **User Session Management:** Store user sessions in a thread-safe manner for web applications handling concurrent requests.
- **Real-Time Sales Tracking:** Efficiently update and retrieve real-time sales data from multiple threads.

**Where Not to Use:** Avoid using ConcurrentDictionary if thread safety is not required, as it incurs additional overhead compared to regular dictionaries.

#### Example Declaration

You can declare a `ConcurrentDictionary<TKey, TValue>` as follows:

```csharp
using System.Collections.Concurrent;

ConcurrentDictionary<int, string> students = new ConcurrentDictionary<int, string>();
```

#### CRUD Operations on ConcurrentDictionary<TKey, TValue>

##### 1. Create

To add new key-value pairs to a `ConcurrentDictionary<TKey, TValue>`, you can use the `TryAdd()` method or the indexer.

```csharp
// Create (Add new key-value pairs)
students.TryAdd(1, "Alice"); // Adds a new entry with key 1 and value "Alice"
students[2] = "Bob"; // Adds a new entry with key 2 and value "Bob"
```

##### 2. Read

To read data from a `ConcurrentDictionary<TKey, TValue>`, you can use the indexer to access a value by its key. The `TryGetValue()` method allows you to check if a key exists and retrieve the corresponding value.

```csharp
// Read the value for a specific key
if (students.TryGetValue(1, out string studentName)) {
    Console.WriteLine($"Student with ID 1: {studentName}"); // Outputs: Alice
}

// Read all key-value pairs
foreach (var kvp in students) {
    Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
}
```

##### 3. Update

To update an existing value in the dictionary, you can use the indexer to set the value for a specific key. If the key does not exist, it will add a new entry.

```csharp
// Update the value for an existing key
students[1] = "Alice Johnson"; // Updates the name for key 1

// Check the updated value
Console.WriteLine($"Updated student with ID 1: {students[1]}"); // Outputs: Alice Johnson
```

##### 4. Delete

To delete a key-value pair from the dictionary, you use the `TryRemove()` method, which safely removes the entry with the specified key.

```csharp
// Delete a key-value pair
if (students.TryRemove(2, out string removedStudent)) {
    Console.WriteLine($"Student with ID 2 has been removed: {removedStudent}");
}

// Check the number of entries after removal
Console.WriteLine($"Number of students after removal: {students.Count}"); // Outputs: 1
```

#### Example of Full CRUD Operations

Here’s a complete example demonstrating CRUD operations using `ConcurrentDictionary<TKey, TValue>`:

```csharp
using System;
using System.Collections.Concurrent;

class Program {
    static void Main() {
        // Create a ConcurrentDictionary
        ConcurrentDictionary<int, string> students = new ConcurrentDictionary<int, string>();

        // Create: Adding new key-value pairs
        students.TryAdd(1, "Alice");
        students[2] = "Bob";

        // Read: Display a specific student's name
        if (students.TryGetValue(1, out string studentName)) {
            Console.WriteLine($"Student with ID 1: {studentName}"); // Outputs: Alice
        }

        // Read: Display all students
        Console.WriteLine("\nAll students:");
        foreach (var kvp in students) {
            Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
        }

        // Update: Modify an existing student's name
        students[1] = "Alice Johnson"; // Update the name for key 1

        Console.WriteLine("\nAfter Update:");
        Console.WriteLine($"Updated student with ID 1: {students[1]}"); // Outputs: Alice Johnson

        // Delete: Remove a student
        if (students.TryRemove(2, out string removedStudent)) {
            Console.WriteLine($"\nStudent with ID 2 has been removed: {removedStudent}");
        }

        // Check the number of entries after removal
        Console.WriteLine($"Number of students after removal: {students.Count}"); // Outputs: 1
    }
}
```

### Trees

A tree is a hierarchical data structure consisting of nodes, where each node contains a value and references to its child nodes. The topmost node is called the root, and each node can have zero or more child nodes. Trees are used in various applications, such as representing hierarchical data (e.g., file systems) and enabling efficient search operations.

```csharp
public class TreeNode {
    public int Value;
    public List<TreeNode> Children = new List<TreeNode>();
}
```

#### Binary Trees

A binary tree is a specific type of tree where each node has at most two children, referred to as the left child and the right child. Binary trees are used in various algorithms and data structures, such as binary search trees and heaps.

**Use Cases:** Hierarchical representation of product categories; implementing expression trees for pricing calculations.

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

#### Binary Search Trees (BST)

A binary search tree is a binary tree with the additional property that for each node, all values in the left subtree are less than the node's value, and all values in the right subtree are greater. This property allows for efficient searching, insertion, and deletion operations.

**Use Cases:** Fast searching and sorting of products; maintaining sorted lists of customer transactions based on timestamps.

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

#### Segment Tree / Interval Tree
- **Description**: A segment tree is a binary tree used for storing intervals or segments.
- **Use Case**: Useful for answering range queries efficiently, such as finding overlapping search terms or ranges.
- **Implementation**: Provides efficient querying for range minimum/maximum or sum queries.

#### B-Trees

A **B-Tree** is a self-balancing tree data structure that maintains sorted data and allows searches, sequential access, insertions, and deletions in logarithmic time. B-Trees are commonly used in databases and file systems to manage large amounts of data efficiently. They are designed to work well on disk storage systems, minimizing the number of disk reads required.

**Use Cases:** 
- Implementing database indexes.
- Storing and retrieving large datasets efficiently.
- Maintaining sorted data in external storage systems.

```csharp
using System;
using System.Collections.Generic;

public class BTreeNode
{
    public int[] Keys;                  // Array of keys
    public BTreeNode[] Children;        // Array of child nodes
    public int Degree;                  // Minimum degree (defines the range for number of keys)
    public int NumberOfKeys;            // Current number of keys in the node
    public bool IsLeaf;                 // True if the node is a leaf node

    // Constructor
    public BTreeNode(int degree, bool isLeaf)
    {
        Degree = degree;
        IsLeaf = isLeaf;
        Keys = new int[2 * degree - 1]; // Maximum keys in a node
        Children = new BTreeNode[2 * degree]; // Maximum children in a node
        NumberOfKeys = 0;
    }
}

public class BTree
{
    private BTreeNode Root;             // Root node of the B-Tree
    private int Degree;                  // Minimum degree

    // Constructor
    public BTree(int degree)
    {
        Root = null;
        Degree = degree;
    }

    // Method to insert a key in the B-Tree
    public void Insert(int key)
    {
        if (Root == null)
        {
            // Create a new root if the tree is empty
            Root = new BTreeNode(Degree, true);
            Root.Keys[0] = key;
            Root.NumberOfKeys = 1;
        }
        else
        {
            // If the root is full, then the tree grows in height
            if (Root.NumberOfKeys == 2 * Degree - 1)
            {
                var newRoot = new BTreeNode(Degree, false);
                newRoot.Children[0] = Root; // Old root becomes a child of new root
                SplitChild(newRoot, 0);      // Split the old root
                int i = 0;
                if (newRoot.Keys[0] < key)
                    i++;
                newRoot.Children[i].InsertNonFull(key);
                Root = newRoot;              // Update the root
            }
            else
            {
                Root.InsertNonFull(key);      // Insert the key in the non-full root
            }
        }
    }

    // Method to split the child of a node
    private void SplitChild(BTreeNode parent, int index)
    {
        var newChild = new BTreeNode(Degree, parent.Children[index].IsLeaf);
        var oldChild = parent.Children[index];

        newChild.NumberOfKeys = Degree - 1; // New child will have Degree - 1 keys

        // Move keys from old child to new child
        for (int j = 0; j < Degree - 1; j++)
            newChild.Keys[j] = oldChild.Keys[j + Degree];

        // Move children from old child to new child if it is not a leaf
        if (!oldChild.IsLeaf)
        {
            for (int j = 0; j < Degree; j++)
                newChild.Children[j] = oldChild.Children[j + Degree];
        }

        oldChild.NumberOfKeys = Degree - 1; // Reduce the number of keys in old child

        // Move children of parent to make room for new child
        for (int j = parent.NumberOfKeys; j >= index + 1; j--)
            parent.Children[j + 1] = parent.Children[j];

        // Link the new child to the parent
        parent.Children[index + 1] = newChild;

        // Move a key from the old child to the parent
        for (int j = parent.NumberOfKeys - 1; j >= index; j--)
            parent.Keys[j + 1] = parent.Keys[j];

        parent.Keys[index] = oldChild.Keys[Degree - 1];
        parent.NumberOfKeys++;
    }

    // Method to insert a key in a non-full node
    public void InsertNonFull(this BTreeNode node, int key)
    {
        int i = node.NumberOfKeys - 1;

        if (node.IsLeaf)
        {
            // Find the location where the new key should be inserted
            while (i >= 0 && node.Keys[i] > key)
            {
                node.Keys[i + 1] = node.Keys[i]; // Move keys to make space
                i--;
            }
            node.Keys[i + 1] = key; // Insert the new key
            node.NumberOfKeys++;
        }
        else
        {
            // Find the child that will have the new key
            while (i >= 0 && node.Keys[i] > key)
                i--;

            // Check if the found child is full
            if (node.Children[i + 1].NumberOfKeys == 2 * Degree - 1)
            {
                SplitChild(node, i + 1);
                if (node.Keys[i + 1] < key)
                    i++;
            }
            node.Children[i + 1].InsertNonFull(key); // Insert the key in the appropriate child
        }
    }
}

// Example usage
class Program
{
    static void Main()
    {
        BTree bTree = new BTree(3); // Create a B-Tree with degree 3

        // Insert keys into the B-Tree
        bTree.Insert(10);
        bTree.Insert(20);
        bTree.Insert(5);
        bTree.Insert(6);
        bTree.Insert(12);
        bTree.Insert(30);
        bTree.Insert(7);
        bTree.Insert(17);

        // Display the B-Tree structure (not implemented)
        // You can implement a method to visualize or traverse the B-Tree
    }
}
```

1. **BTreeNode Class**: This class defines a node in the B-Tree, containing an array of keys, an array of child nodes, the degree of the tree, the number of keys in the node, and a flag indicating if the node is a leaf.
2. **BTree Class**: This class manages the overall B-Tree structure and contains methods for inserting keys and splitting child nodes.
3. **Insert Method**: The method handles inserting a key into the B-Tree. It checks if the root is null or if it's full, and it appropriately splits the root if needed.
4. **SplitChild Method**: This method splits a full child node into two nodes and adjusts the parent node.
5. **InsertNonFull Method**: This method inserts a key into a non-full node by finding the appropriate location and moving keys as necessary.
6. **Example Usage**: The `Main` method demonstrates how to create a B-Tree and insert keys. The method to display the structure of the B-Tree is left for implementation.

#### Heaps

A heap is a special tree-based data structure that satisfies the heap property. In a max-heap, for any given node, the value of the node is greater than or equal to the values of its children, and in a min-heap, the value of the node is less than or equal to the values of its children. Heaps are commonly used in priority queues and sorting algorithms like heap sort.

**Use Cases:** Priority queue implementations for managing high-priority sales tasks; optimizing inventory replenishment strategies based on demand forecasts.

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

#### Trie

A trie, or prefix tree, is a tree-like data structure used to store a dynamic set of strings, where the keys are usually strings. Tries are particularly useful for tasks involving retrieval of keys with a common prefix, such as autocomplete systems.

- **Use Cases:** Efficiently storing and retrieving product names for autocomplete features in e-commerce platforms; managing keyword searches in product catalogs.

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

**Use Cases:** 
- **Network Analysis for Sales Channels:** Model relationships between different sales channels and their performance metrics.
- **Customer Relationship Mapping:** Visualize connections between customers based on purchasing behavior and referrals.

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

### Sorting Algorithms

Sorting algorithms are methods for arranging the elements of a list or array in a specific order, typically in ascending or descending order. Different sorting algorithms have different characteristics in terms of complexity, efficiency, and stability.

#### Bubble Sort

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

#### Selection Sort

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

#### Insertion Sort

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

#### Merge Sort

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

#### Quick Sort

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

#### Heap Sort

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

### **Inverted Index**
- **Description**: An inverted index is a mapping from content (like words or terms) to its locations in a database or a document.
- **Use Case**: Essential for full-text search engines, allowing quick lookup of documents containing specific keywords.
- **Implementation**: Typically involves a hash table or trie structure for storing terms and their associated document IDs.

### **Bloom Filter**
- **Description**: A space-efficient probabilistic data structure used to test whether an element is a member of a set.
- **Use Case**: Quickly checking for the presence of search terms, reducing the need for costly lookups.
- **Implementation**: Utilizes multiple hash functions and bit arrays.

### **Caching Mechanisms**
- **Description**: Caching can significantly improve the performance of search queries by storing frequently accessed data.
- **Use Case**: Using data structures like LRU (Least Recently Used) Cache can optimize repeated search requests.
- **Implementation**: Combines a hash map with a doubly linked list to keep track of usage.

### **Matrix Factorization / Collaborative Filtering**
- **Description**: Techniques used in recommendation systems to predict user preferences based on past behavior.
- **Use Case**: Enhancing search results with personalized recommendations.
- **Implementation**: Algorithms like Singular Value Decomposition (SVD) or Alternating Least Squares (ALS).

### Graph Algorithms

#### 1. **Graph Representations**
   - 1.1 **Adjacency Matrix**
   - 1.2 **Adjacency List**
   - 1.3 **Edge List**

#### 2. **Traversal Algorithms**
   - 2.1 **Breadth-First Search (BFS)**

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

   - 2.2 **Depth-First Search (DFS)**

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

#### 3. **Shortest Path Algorithms**
   - 3.1 **Dijkstra's Algorithm**

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

   - 3.2 **Bellman-Ford Algorithm**

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

   - 3.3 **Floyd-Warshall Algorithm**

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

   - 3.4 **A* Search Algorithm**
   - 3.5 **Johnson's Algorithm**

#### 4. **Minimum Spanning Tree (MST) Algorithms**
   - 4.1 **Prim's Algorithm**
   - 4.2 **Kruskal's Algorithm**
   - 4.3 **Borůvka's Algorithm**

#### 5. **Network Flow Algorithms**
   - 5.1 **Ford-Fulkerson Algorithm**
   - 5.2 **Edmonds-Karp Algorithm**


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

   - 5.3 **Dinic's Algorithm**
   - 5.4 **Push-Relabel Algorithm**

#### 6. **Cycle Detection**
   - 6.1 **Cycle Detection using DFS**
   - 6.2 **Union-Find (Disjoint Set) for Cycle Detection**
   - 6.3 **Tarjan’s Strongly Connected Components Algorithm**

#### 7. **Topological Sorting**
   - 7.1 **Kahn's Algorithm**
   - 7.2 **Topological Sort using DFS**

#### 8. **Graph Coloring Algorithms**
   - 8.1 **Greedy Coloring**
   - 8.2 **Backtracking Coloring**
   - 8.3 **Welsh-Powell Algorithm**

#### 9. **Strongly Connected Components (SCC) Algorithms**
   - 9.1 **Kosaraju's Algorithm**
   - 9.2 **Tarjan's Algorithm**
   - 9.3 **Gabow's Algorithm**

#### 10. **Bipartite Graph Algorithms**
   - 10.1 **Bipartite Graph Check using BFS/DFS**
   - 10.2 **Hopcroft-Karp Algorithm (Maximum Matching)**

#### 11. **Eulerian and Hamiltonian Paths**
   - 11.1 **Fleury's Algorithm (Eulerian Path)**
   - 11.2 **Hierholzer's Algorithm (Eulerian Circuit)**
   - 11.3 **Backtracking for Hamiltonian Path/Circuit**

#### 12. **Matching and Covering Algorithms**
   - 12.1 **Hungarian Algorithm (Maximum Bipartite Matching)**
   - 12.2 **Blossom Algorithm for General Matching**
   - 12.3 **Vertex Cover Problem**

#### 13. **Planarity Testing**
   - 13.1 **Kuratowski’s Theorem**
   - 13.2 **Hopcroft and Tarjan’s Planarity Testing Algorithm**

#### 14. **Graph Decomposition**
   - 14.1 **Tree Decomposition**
   - 14.2 **Graph Partitioning**
   - 14.3 **Clique Decomposition**

#### 15. **Randomized and Approximation Algorithms**
   - 15.1 **Randomized Contraction Algorithm for Minimum Cut**
   - 15.2 **Approximation Algorithms for TSP (Traveling Salesman Problem)**

