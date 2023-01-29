using Linq;

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


List<Employee> employees = CreateEmployees();

Console.WriteLine("FirstName starting with C or S in ascending order");
employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName[0] == 'S')
         .OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"{x.FullName} {x.Age}"));

Console.WriteLine("Employees whose ages greater than 26 - order them by age then firstname");
employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x));

Console.WriteLine("Sum & Average of Employees' Years of experience, if less than or equal to 10 and age is greater than 35");
var sum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
Console.WriteLine(sum);

var average = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
Console.WriteLine(average);

Console.WriteLine("Add an employee to the end of the list without using employees.Add()");
employees.Append(new Employee("Michael", "Scott", 35, 10)).ToList().ForEach(x => Console.WriteLine($"Full name: {x.FullName}, Age: {x.Age}, YOE: {x.YearsOfExperience}"));

//OR -- 
//employees.Append(new Employee() { FirstName = "Michael", LastName = "Scott" });

#region

static List<Employee> CreateEmployees()
{
    List<Employee> employees = new List<Employee>();
    employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
    employees.Add(new Employee("Steven", "Bustamento", 56, 5));
    employees.Add(new Employee("Micheal", "Doyle", 36, 8));
    employees.Add(new Employee("Daniel", "Walsh", 72, 22));
    employees.Add(new Employee("Jill", "Valentine", 32, 43));
    employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
    employees.Add(new Employee("Big", "Boss", 23, 14));
    employees.Add(new Employee("Solid", "Snake", 18, 3));
    employees.Add(new Employee("Chris", "Redfield", 44, 7));
    employees.Add(new Employee("Faye", "Valentine", 32, 10));

    return employees;
}

#endregion