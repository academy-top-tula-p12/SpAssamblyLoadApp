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
            {
                Console.WriteLine($"\t{t.Name}");
                try
                {
                    object? obj = null;
                    if (t.Name == "Person")
                        obj = Activator.CreateInstance(t, new object[] { "Bobby", 25 });
                    else if (t.Name == "Employee")
                        obj = Activator.CreateInstance(t, new object[] { "Bobby", 25, 50000.0m });
                    MethodInfo? info = t.GetMethod("Info");
                    info?.Invoke(obj, null);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
                
        }
    }
}
