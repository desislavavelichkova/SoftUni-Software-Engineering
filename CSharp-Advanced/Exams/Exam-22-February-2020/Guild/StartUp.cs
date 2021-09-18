namespace Guild
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Initialize the repository (guild)
           Guild guild = new Guild("Weekend Raiders", 20);
            //Initialize entity
            Player player = new Player("Mark", "Rogue");
            //Print player
            System.Console.WriteLine(player); ; //Player Mark: Rogue
                                       //Rank: Trial
                                       //Description: n/a


        }
    }
}
