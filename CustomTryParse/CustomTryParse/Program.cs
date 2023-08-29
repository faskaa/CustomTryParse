namespace CustomTryParse
{
   
   

    internal class Program
    {
        public static bool MyTryParse(out int a)
        {
            try
            {
                a= int.Parse("123");
                Console.WriteLine(true);
                return true;
               
            }
            catch (Exception ex)
            {

                a = 0;
                Console.WriteLine(false);
                return false;
                

            }
            

        }


        static void Main(string[] args)
        {
            
        } 
    }
}