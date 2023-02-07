namespace OperatorExercise
{
    public class Program
    {
      

        static void Main(string[] args)
        {
           //EXERCISE 1
            
            int numberA = 17;
            int numberB = 4;

             int Add()
            {
                return numberA + numberB;
            }

            int Subtract()
            { 
                return numberA - numberB; 
            }

            int Multiply() 
            { 
                return numberA * numberB; 
            }

            int Divide()
            {
                return numberA / numberB;
            }

            int quotient = Divide();

            int remainder = numberA % numberB;

            Console.WriteLine($"{numberA}/{numberB} is {quotient} remainder {remainder}");


            //EXERCISE 2

            Console.WriteLine("What is the radius of your Circle?");

            var radius = double.Parse(Console.ReadLine());

            double AreaOfCircle() 
            {
                return Math.PI * Math.Pow(radius, 2);
            }

            Console.WriteLine($"The area of a circle with the radius of {radius} is {AreaOfCircle()}");



            //THOUGHT EXERCISE

            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine($"Outputs 16 and officially - {k}");

            //outputs 16 because at time of storing variable "k" i is 4 and j is also 4. (J doesn't add to five due to the post fix increment)//

        }


    }
}
