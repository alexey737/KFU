// TASK 3
List<int> numbers = new List<int> {5, 8, 3, 16, 17 };
numbers.Remove(3);
numbers.Add(50);
Console.WriteLine(string.Join(",", numbers));
Console.WriteLine(numbers.Count);