namespace ClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Engineer[] engineers = new Engineer[3];
            engineers[0] = new Engineer();
            engineers[1] = new Engineer();
            engineers[2] = new Engineer();

            engineers[0].FullName = "Murad Aliyev";
            engineers[0].Salary = 200;

            engineers[1].FullName = "Mahammad Aliyev";
            engineers[1].Salary = 2000;

            engineers[2].FullName = "Lionel Messi";
            engineers[2].Salary = 10000;

            AverageSalary(engineers);
        }


        static void AverageSalary( Engineer[] array)
        {
            double sum = 0;
            int count = 0;

            foreach (Engineer i in array)
            {
                sum += i.Salary;
                if (i.Salary != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(sum / count);
        }

    }
}