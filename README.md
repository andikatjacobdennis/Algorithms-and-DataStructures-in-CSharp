## Table of Contents

- [Introduction](#introduction)
- [Data Structures](#data-structures)
  - [Arrays](#arrays)
  - [Linked Lists](#linked-lists)
  - [Stacks](#stacks)
  - [Queues](#queues)
  - [Hash Tables](#hash-tables)
  - [Trees](#trees)
  - [Graphs](#graphs)
- [Algorithms](#algorithms)
  - [Sorting Algorithms](#sorting-algorithms)
    - [Bubble Sort](#bubble-sort)
    - [Merge Sort](#merge-sort)
    - [Quick Sort](#quick-sort)
  - [Searching Algorithms](#searching-algorithms)
    - [Linear Search](#linear-search)
    - [Binary Search](#binary-search)
  - [Graph Algorithms](#graph-algorithms)
    - [Depth-First Search (DFS)](#depth-first-search-dfs)
    - [Breadth-First Search (BFS)](#breadth-first-search-bfs)
- [Conclusion](#conclusion)
- [References](#references)

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

### Trees

A tree is a hierarchical data structure consisting of nodes, with a single node as the root and other nodes as children.

```csharp
public class TreeNode {
    public int Value;
    public List<TreeNode> Children = new List<TreeNode>();
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

### Sorting Algorithms

#### Bubble Sort

Bubble sort is a simple sorting algorithm that repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order.

```csharp
public void BubbleSort(int[] arr) {
    for (int i = 0; i < arr.Length - 1; i++) {
        for (int j = 0; j < arr.Length - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                // Swap
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}
```

#### Merge Sort

Merge sort is a divide-and-conquer algorithm that divides the array into halves, sorts them, and then merges them back together.

```csharp
public int[] MergeSort(int[] array) {
    if (array.Length <= 1) return array;

    int mid = array.Length / 2;
    int[] left = MergeSort(array.Take(mid).ToArray());
    int[] right = MergeSort(array.Skip(mid).ToArray());
    
    return Merge(left, right);
}

private int[] Merge(int[] left, int[] right) {
    // Merging logic here
}
```

#### Quick Sort

Quick sort is an efficient sorting algorithm that uses a divide-and-conquer strategy to sort elements.

```csharp
public void QuickSort(int[] arr, int low, int high) {
    if (low < high) {
        int pi = Partition(arr, low, high);
        QuickSort(arr, low, pi - 1);
        QuickSort(arr, pi + 1, high);
    }
}

private int Partition(int[] arr, int low, int high) {
    // Partitioning logic here
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

Here's an updated version of your **Graph Algorithms** section, including **Edmonds-Karp** and **All Paths** algorithms along with the previously mentioned ones:

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
