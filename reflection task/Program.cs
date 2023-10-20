namespace reflection_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee employee = new Employee();
                Console.WriteLine("Fullname daxil edin");
                string Flnm = Console.ReadLine();
                


                Console.WriteLine("Yasinizi daxil edin");
                string Agestr = Console.ReadLine();
                sbyte age = sbyte.Parse(Agestr);

                employee.Age = age;

                Console.WriteLine("Enter department No");
                string dpmn = Console.ReadLine();
                employee.DepartmentNo = dpmn;

                Console.WriteLine("enter experience");
                string expstr = Console.ReadLine();
                double experience = double.Parse(expstr);














            }
            catch (InvalidNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Invalid Age: " + ex.Message);
            }
            catch (InvalidDepartmentNo ex)
            {
                Console.WriteLine("Invalid DepartmentNo: " + ex.Message);
            }
            catch (InvalideExperience ex)
            {
                Console.WriteLine("Invalide Experience: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
        }
    }
}