namespace Inheritance
{
    public class Vehicle
    {
        private readonly string _registationNumber;
        public Vehicle( string registationNumber)
        {   
            _registationNumber = registationNumber;
            System.Console.WriteLine("Vehicle being initualize.{0} ",registationNumber);
        }
    }
}
