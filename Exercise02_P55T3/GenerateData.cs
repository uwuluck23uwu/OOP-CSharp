namespace Exercise02_P55T3
{
    internal class GenerateData
    {
        public List<Employee> Employees;
        public GenerateData(int num = 5)
        {
            Employees = new List<Employee>();
            CreateEmployee(num);
        }

        public void CreateEmployee(int number)
        {
            Random r = new Random();
            for (int i = 0; i < number; i++)
            {
                Employees.Add(new Employee
                {
                    Id = i,
                    Section = r.Next(1,6),
                    Age = r.Next(25,61)
                });
            }
        }
        public List<Employee> SortBySection() => Employees.OrderBy(p => p.Section).ToList();
        public List<IGrouping<int,Employee>> GroupOfSection()
        {
            return Employees.GroupBy(p => p.Section).ToList();
        }
        
    }
}
