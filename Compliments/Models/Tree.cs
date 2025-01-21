namespace Compliments.Models
{
    public class Tree
    {
        private static int nextId = 1;
        public Tree(string name, string location, int size, string species)
        {
            Id = nextId;
            nextId++;
            Name = name;
            Location = location;
            Size = size;
            Species = species;
            Compliments = [];
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Size { get; set; }
        public string Species { get; set; }
        public List<Compliment> Compliments { get; set; }
    }
}
