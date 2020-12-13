using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] measurements = { 5, 24, -12, 34, -1, 8, -21, 100, 200, 14, 36, -48, 60 };
            string[] names = {"John", "Bob", "Alice", "Donald", "Euzebiusz", ""};
            */
            // Console.WriteLine(names.Min());
            // Console.WriteLine(measurements.Min());

            // Display(measurements.Where(x => x > 10));
            // Display(measurements.Where(x => x > 0 && x % 2 == 0));
            // Display(measurements.OrderByDescending(x => x));
            // Display(names.OrderBy(x=>x));
            // Display(names.OrderBy(x=>x.Length));
            //
            // Display(names.Where(x=>x.Length > 0).Select(x => x[0]));
            // Display(names.Select(x => x.Length > 0 ? x[0].ToString() : ""));
            // Display(names.Select(x => x.FirstOrDefault()));
            //
            // Display(names.Skip(2).Take(2));
            // Console.WriteLine(names.Skip(1).FirstOrDefault());

            /* var collection = measurements
                 .Where(x => x % 12 == 0)
                 .OrderBy(x => x)
                 .Select(x => Math.Abs(x));

              Display(collection);

              var aenames = names
                  .Where(x => x.StartsWith("A") || x.StartsWith("E"))
                  .OrderByDescending(x => x.Length)
                  .Select(x => x.Last())
                  .Skip(1);
              Display(aenames);


              */

            var employees = Employee.GetEmployees();
            var people = PersonalData.GetPersonalData();

            var seniors = employees.Where(x => x.Seniority > 8);
            var women = employees.Where(x => x.Gender == Gender.Woman);
            var aver = employees.Select(x => x.BaseSalary).Average();
            var task4 = employees.Where(x => x.BaseSalary > employees.Select(x => x.BaseSalary).Average());
            var task5 = employees.Where(x => x.Bonus > x.BaseSalary * 0.1M);
            var task6SumofSalaries = employees.Select(x => (decimal)x.BaseSalary).Sum();

            
            var task7seniorWoman = employees.Where(x => x.Gender == Gender.Woman);
            var highestWomSen = task7seniorWoman.Select(x => x.Seniority).Max();
            task7seniorWoman = task7seniorWoman.Where(x => x.Seniority == highestWomSen);


            var task8sumOfNoticeBonuses = employees.Where(x => x.Role == Role.OnNotice).Select(y => y.Bonus).Sum();

            var task9tax13perc = Convert.ToDouble(employees.Select(x => (decimal)x.BaseSalary).Sum()) * 0.13f;

            var task10employeesInThirties = employees.Where(x => x.Age >= 30 && x.Age < 40);

            var task11experiencedIntern = employees.Where(x => x.Role == Role.Intern);
            var longest_int_experience = task11experiencedIntern.Select(x => x.Seniority).Max();
            task11experiencedIntern = task11experiencedIntern.Where(x => x.Seniority == longest_int_experience);

            var task12SalaryIterns = employees.Where(x => x.Role == Role.Intern).Select(x => x.BaseSalary).Sum();

            var task13AverAge = Convert.ToInt32(employees.Select(x => x.Age).Average());

            var task14YoungerAver = employees.Where(x => x.Age < task13AverAge);

            var task15NameLongerSurname = employees.Where(x => x.FirstName.Length > x.LastName.Length);

            var task16WomenInterns = employees.Where(x => x.Role == Role.Intern && x.Gender == Gender.Woman).Count();

            var task17WomenOnNotice = employees.Where(x => x.Gender == Gender.Woman && x.Role == Role.OnNotice).Count();

            var task18 = aver;

            //var task19Places = people.Select(x=>x.City);
            //var task19IndPeople = people.Select(x => x.Id);
            //var task19Places = people.Select(x => x.City);
            //var task19PeopleWithPlaces = employees.Where(x => x.Id == task19IndPeople)

            //var task19Joined = people.Join(employees,  )
            var task19NamesWithCities = from person in people
                          join empl in employees on person.Id equals empl.Id
                          select new { place = person.City, LastName = empl.LastName };

            var task20WhoBornsWhen = from pers in people
                                     join empl in employees on pers.Id equals empl.Id
                                     select new { name = empl.FirstName, surname = empl.LastName, DateBirth = pers.BirthDate };

            var task21MostPopularCity = people.GroupBy(x => x.City).OrderByDescending(x => x.Count()).Take(1).Select(x => x.Key);

            var task22WorkersByCities = from pers in people
                                        join empl in employees on pers.Id equals empl.Id
                                        select new { FullName = $"{empl.FirstName} {empl.LastName}", City = pers.City };
            var task22WorkersByCitiesRes = task22WorkersByCities.GroupBy(x => x.City);


            var forTask23CitiesAge = from pers in people
                                     join empl in employees on pers.Id equals empl.Id
                                     select new { city = pers.City, age = empl.Age };
            var task23AverAgeKrakow = forTask23CitiesAge.Where(x => x.city == "Krakow").Select(x => x.age).Average();

            string flatIdent = "/";
            var placePlusName = from pers in people
                                join empl in employees on pers.Id equals empl.Id
                                select new { FullName = $"{empl.FirstName} {empl.LastName}", appartment = pers.House };
            var task24whoInHouse = placePlusName.Where(x => !(x.appartment.Contains(flatIdent))).Select(x => x.FullName);

            var peopleWithBirthdates = from pers in people
                                       join empl in employees on pers.Id equals empl.Id
                                       select new { FullName = $"{empl.FirstName} {empl.LastName}", bDate = pers.BirthDate };
            var task25whoInFebr = peopleWithBirthdates.Where(x => x.bDate.Month == 2).Select(x => x.FullName);

            //Console.WriteLine(task23AverAgeKrakow);
            //Display(task25whoInFebr);
        }

        public static void Display<T>(IEnumerable<T> collection)
        {
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("------------------------------------");
        }

    }
}
