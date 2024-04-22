using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animals
{
    public abstract class Animal
    {
        public virtual void Eat() { }
        public virtual void Move() { }
    }

    public class Man:Animal
    {
        private int _pattes = 2;
        public override void Eat() {
            System.Console.WriteLine($"I eat...I have {_pattes} legs");
        }
        public override void Move() {
            System.Console.WriteLine("I move");
        }
    }
    public class Monkey : Animal
    {
        private int _pattes = 2;
        public override void Eat() {
            System.Console.WriteLine($"I eat...I have {_pattes} legs");
        }
        public override void Move() { }
    }
    public class Elephant : Animal
    {
        private int _pattes = 4;
        public override void Eat() {
            System.Console.WriteLine($"I eat...I have {_pattes} legs");
        }
        public override void Move() { }
    }
    public class Turtle : Animal
    {
        private int _pattes = 4;
        public override void Eat() {
            System.Console.WriteLine($"I eat...I have {_pattes} legs");
        }
        public override void Move() { }
    }
    public class Lizard : Animal
    {
        private int _pattes = 4;
        public override void Eat() {
            System.Console.WriteLine($"I eat...I have {_pattes} legs");
        }
        public override void Move() { }
    }
}
