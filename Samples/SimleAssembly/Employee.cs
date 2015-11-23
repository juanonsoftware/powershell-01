namespace SimleAssembly
{
    public class Employee
    {
        public string FullName { get; set; }

        public int Age { get; set; }

        public string Print()
        {
            return string.Format("FullName {0}, Age {1}", FullName, Age);
        }
    }
}
