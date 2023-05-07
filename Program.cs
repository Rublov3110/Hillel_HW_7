namespace PRO_HW_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

           var newArr = arr
               .Where(x => x % 2 != 0)
               .Select(x=> x * x)
               .ToArray();

            foreach ( var x in newArr ) 
            {
                Console.WriteLine(x);
            }

            Console.WriteLine(new string('-', 50));

            int sum = arr.Sum(x => x);
            Console.WriteLine(sum);


            Console.WriteLine(new string('-', 50));


            List<Person> people = new List<Person>();
            for (int i = 1; i <= 20; i++)
            {
                Person person = new Person();
                person.Name = "Person" + i;
                person.Id = i;
                person.Age = i + 10;
                people.Add(person);
            }

            var filteredPeople = people.Where(p => p.Age > 20);
            foreach (var person in filteredPeople)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine(new string('-', 50));

            var result = people
                .Where(p => p.Age > 20)
                .OrderBy(p => p.Name)
                .Select(p => new { p.Id, p.Name });
            foreach (var item in result)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
            }

            Console.WriteLine(new string('-', 50));

            var groupedPeople = people.Where(p => p.Age > 20)
                          .Select(p => new { p.Id, p.Name, p.Age})
                          .GroupBy(p => p.Age)
                          .ToDictionary(g => g.Key, g => g.Select(p => p.Name).ToList());

            foreach (var group in groupedPeople)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach (var name in group.Value)
                {
                    Console.WriteLine($"  Name: {name}");
                }
            }

            Console.WriteLine(new string('-', 50));
            var penultimate = arr.Penultimate();
            Console.WriteLine(penultimate);

        }
    }
}