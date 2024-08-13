namespace ObjectOrientedAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal(1);  שגיאה איו אפשרות ליצור אוביקט ממחלקה אבסטרקטית
            Animal dog = new Dog((EMood)1);
            Animal cat = new Cat((EMood)2);
            Animal frog = new Frog((EMood)1);

            dog.SayHello();
            dog.SayHello(2);

            cat.SayHello();
            cat.SayHello(2);

            frog.SayHello();
            frog.SayHello(2);
           
            Console.ReadKey();
        }
    }
}