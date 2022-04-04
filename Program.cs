using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var LogString = new Loger<string>("LogString.txt");
            LogString.LogInfo("Животный мир");
            LogString.LogWarning("Предупреждение");
            LogString.LogError("Oшибка", new ArgumentNullException());

            var LogAnimal = new Loger<Animal>("LogAnimal.txt");
            LogAnimal.LogInfo("Животный мир");
            LogAnimal.LogWarning("Предупреждение");
            LogAnimal.LogError("Oшибка", new NullReferenceException());
        }
    }

}