namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Man man = new Man();
            man.Eat();
            man.Move();
            Monkey monkey = new Monkey();
            monkey.Eat();
            monkey.Move();
            Lizard  lizard = new Lizard();
            lizard.Eat();
            lizard.Move();
            Turtle turtle = new Turtle();
            turtle.Eat();
            turtle.Move();
        }
    }
}
