using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Funny Cat Compilation", "CuteAnimals123", 240);
        Video v2 = new Video("Cooking Tutorial: Homemade Pizza", "ChefCookingMaster", 780);
        Video v3 = new Video("Guitar Lesson: Beginner Chords", "GuitarGuru88", 360);
        Video v4 = new Video("Travel Vlog: Exploring Paris", "WanderlustAdventures", 600);
        
        v1.AddComment(new Comment("John Doe", "Hilarious! Can't stop laughing."));
        v1.AddComment(new Comment("Emma Wilson", "These cats are too cute!"));
        v1.AddComment(new Comment("David Thompson", "Best cat video ever!"));
        v1.AddComment(new Comment("Sophia Davis", "I could watch this all day."));
        v1.AddComment(new Comment("Daniel Martinez", "Made my day brighter. Thanks!"));
        
        v2.AddComment(new Comment("Olivia Anderson", "Delicious recipe! Can't wait to try it."));
        v2.AddComment(new Comment("Sarah Johnson", "I never knew making pizza could be so easy."));
        v2.AddComment(new Comment("Michael Brown", "Your instructions were clear and helpful."));
        v2.AddComment(new Comment("Emily Clark", "My family loved the pizza. Thank you!"));
        v2.AddComment(new Comment("William Taylor", "Now I can make my favorite pizza at home!"));
        
        v3.AddComment(new Comment("Sophia Rodriguez", "Great tutorial for beginners. Thanks!"));
        v3.AddComment(new Comment("Daniel Lewis", "Your explanations are really helpful."));
        v3.AddComment(new Comment("Jennifer Adams", "I've been struggling with chords, but this made it easier."));
        v3.AddComment(new Comment("Alex Roberts", "Now I can finally play my favorite songs!"));
        v3.AddComment(new Comment("Olivia Parker", "Clear and concise. Awesome lesson!"));

        v4.AddComment(new Comment("Mark Thompson", "Paris looks stunning! Adding it to my bucket list."));
        v4.AddComment(new Comment("Emma Roberts", "I feel like I'm there. Amazing footage!"));
        v4.AddComment(new Comment("David Anderson", "Your vlogs always inspire me to travel."));
        v4.AddComment(new Comment("Jennifer Wilson", "Loved the cultural insights. Thank you!"));
        v4.AddComment(new Comment("Michael Davis", "Paris is truly a city of wonders. Great vlog!"));
        
        Console.WriteLine(v1);
        Console.WriteLine(v2);
        Console.WriteLine(v3);
        Console.WriteLine(v4);
    }
}