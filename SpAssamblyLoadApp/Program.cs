using System.Reflection;

namespace SpAssamblyLoadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom("MyLibrary.dll");

            Console.WriteLine(assembly.FullName);

            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
                Console.WriteLine($"\t{t.Name}");
        }
    }
}
