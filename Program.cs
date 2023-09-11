namespace leacture11_9
{
    enum beverage
    {
        coffee,
        tea,
        vatten,
        soda,
    }
    internal class Program
    {   
        static void Main(string[] args)
        
       
        
        
        {
            Console.WriteLine("hi and welcome");
            Console.WriteLine(" choose ur dring ");
            string userinput = Console.ReadLine();
            switch (userinput.ToLower())
            {
                case "coffee":
                    respond(beverage.coffee);
                    break;
                case "tea":
                    respond(beverage.tea);
                    break;
                case "vatten":
                    respond(beverage.vatten);
                    break;
                case "sode":
                    respond(beverage.soda);
                    break;
                default:
                    Console.WriteLine("we dont have that");
                    break;
            }

        }
        static void respond(beverage drink)
        {
            switch (drink)
            {
                case beverage.coffee:
            Console.WriteLine(" u have ur coffee");
            break;
            case beverage.tea:
                Console.WriteLine(" its tea time");
                break;
            case beverage.vatten:
                Console.WriteLine("nothing better then some water");
                break;
            case beverage.soda:
                Console.WriteLine("yummy");
                break;
            }





        }



    }
}    