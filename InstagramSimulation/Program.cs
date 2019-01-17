using System;
using InstagramSimulation.Entites;

namespace InstagramSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("waw that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("18/01/2019 11:25:45"),
                "Traveling to Angola",
                "I was deported to this wonderfull country! ",
                1023
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine();

            Comment c3 = new Comment("Good nigth ");
            Comment c4 = new Comment("Bro keep your mind strong it's normal, I hope u will back soon");
            Post p2 = new Post(
                DateTime.Parse("20/01/2019 22:39:23"),
                "Good nigth guys! ",
                "See you tommorow, to show how life is better in Africa! ",
                3023
                );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine("\tInstagram Simulation");
            Console.WriteLine("\t-----------------------------\n");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
