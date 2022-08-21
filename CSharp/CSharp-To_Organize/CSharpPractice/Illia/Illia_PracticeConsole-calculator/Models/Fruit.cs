namespace ConsoleCalculator.Models
{
    public class Fruit
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Fruit(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
