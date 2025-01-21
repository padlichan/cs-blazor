namespace Compliments.Models
{
    public class Compliment
    {
        private static int nextId = 1;
        private static List<Compliment> compliments = new List<Compliment>();

        static Compliment()
        {
            compliments.Add(new Compliment("You may not be evergreen, but you are to me."));
            compliments.Add(new Compliment("I bet squirrels consider you prime real estate."));
            compliments.Add(new Compliment("You're so down to earth."));
            compliments.Add(new Compliment("You're very grounded."));
            compliments.Add(new Compliment("Your leaves are soothing."));
            compliments.Add(new Compliment("You sway nicely in the wind."));
            compliments.Add(new Compliment("You're blooming brilliant."));
            compliments.Add(new Compliment("You're really good at standing still and doing nothing."));
            compliments.Add(new Compliment("Let's get to the root of your beauty."));
            compliments.Add(new Compliment("I will never leaf you."));
            compliments.Add(new Compliment("You've really branched out lately."));
            compliments.Add(new Compliment("You provide the perfect amount of shade on a hot day."));
            compliments.Add(new Compliment("I'm really pine-ing for you."));
        }
        public Compliment(string text)
        {
            Id = nextId++;
            Text = text;
        }

        public int Id { get; set; }
        public string Text { get; set; }

        public static Compliment GetCompliment()
        {
            int index = new Random().Next(0, compliments.Count);
            return compliments[index];
        }
    }
}
