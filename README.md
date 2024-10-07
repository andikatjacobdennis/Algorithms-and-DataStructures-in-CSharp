## Introduction

In this document, we will explore various data structures and algorithms that are essential for efficient programming in C#. Understanding these concepts will help you write better code, optimize performance, and solve complex problems effectively.

## Data Structures

### Arrays

Arrays are a collection of elements identified by index or key. They are used to store multiple values in a single variable.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
```

### Linked Lists

A linked list is a linear data structure where each element is a separate object, and each element (node) contains a reference (link) to the next node in the sequence.

```csharp
public class Node {
    public int Data;
    public Node Next;
}

public class LinkedList {
    public Node Head;
}
```

### Stacks

A stack is a collection of elements that follows the Last In First Out (LIFO) principle. Elements can be added or removed from only one end.

```csharp
public class Stack {
    private List<int> elements = new List<int>();

    public void Push(int item) {
        elements.Add(item);
    }

    public int Pop() {
        int lastIndex = elements.Count - 1;
        int lastItem = elements[lastIndex];
        elements.RemoveAt(lastIndex);
        return lastItem;
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
