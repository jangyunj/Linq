int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("Sum: ");
Console.WriteLine(numbers.Sum());

Console.WriteLine("Average: ");
Console.WriteLine(numbers.Average());

Console.WriteLine("Numbers in Ascending order: ");
numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));

Console.WriteLine("Numbers in Descending order: ");
numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));

Console.WriteLine("Numbers greater than 6: ");
numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));

Console.WriteLine("Numbers in Ascending order but only 4 of them: ");
var ordered = numbers.OrderBy(x => x);
foreach (var item in ordered.Take(4))
{
    Console.WriteLine(item);
}

//OR
//numbers.OrderBy(x => x).Take(4).ToList().ForEach(x => Console.WriteLine(x));

Console.WriteLine("Change the value at index 4 to 100, then print the numbers in ascending order: ");
numbers.SetValue(100, 4);
//OR numbers[4] = 100;
numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
