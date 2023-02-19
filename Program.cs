using System.Globalization;
using Entities;

internal class Program
{
    private static void Main(String[] args)
    {
        Post post1 = new Post(
            DateTime.Now,
            "Traveling to New Zeland",
            "I'm going to visit this wonderfull country!",
            12
            );
        
        Comment comment1 = new Comment("Have a nice trip");
        Comment comment2 = new Comment("Wow thats awesome!");
        Comment comment3 = new Comment("Take me with you plss");
        post1.addComment(comment1);
        post1.addComment(comment2);
        post1.addComment(comment3);

        Post post2 = new Post(
            DateTime.Now,
            "",
            "Good morning guys, how are you?",
            25
            );
        
        Comment comment4 = new Comment("Just fine u?");
        Comment comment5 = new Comment("I wish I'd still sleeping :c");
        post2.addComment(comment4);
        post2.addComment(comment5);

        Console.WriteLine(post1);
        Console.WriteLine(post2);
    }
}
