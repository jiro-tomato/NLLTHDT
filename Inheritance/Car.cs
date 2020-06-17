namespace Inheritance
{
    public class Car : Vehicle
    {
        public Car( string registationNumber)
        : base(registationNumber)
       {
           System.Console.WriteLine("Car beign inittualize. {0}",registationNumber);
       }
    }
}
