namespace LabExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double positiveRadius = 20;
            double negativeRadius = -20;
            double zeroRadius = 0;

            Circle positiveCircle = new Circle();
            positiveCircle.SetRadius(positiveRadius);
            Console.WriteLine(positiveCircle.ToString());

            try
            {
                Circle negativeCircle = new Circle();
                negativeCircle.SetRadius(negativeRadius);
                
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine("The radius " + ex.Radius + " is not valid but you can still continue.");
            }

            try
            {
                Circle zeroCircle = new Circle();
                zeroCircle.SetRadius(zeroRadius);
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine("The radius " + ex.Radius + " is not valid but you can still continue.");
            }

        }    
            
    }
}