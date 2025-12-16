using System;

class Program
{
    static void Main()
    {
        try
        {
            string[] studentData = Console.ReadLine().Split();
            string studentFirstName = studentData[0];
            string studentLastName = studentData[1];
            string facultyNumber = studentData[2];

            Student student = new Student(studentFirstName, studentLastName, facultyNumber);

            string[] workerData = Console.ReadLine().Split();
            string workerFirstName = workerData[0];
            string workerLastName = workerData[1];
            decimal weekSalary = decimal.Parse(workerData[2]);
            double hoursPerDay = double.Parse(workerData[3]);

            Worker worker = new Worker(workerFirstName, workerLastName, weekSalary, hoursPerDay);

            Console.WriteLine(student);
            Console.WriteLine();
            Console.WriteLine(worker);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}