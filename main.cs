using System;

namespace BodybuildingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bodybuilder ronnieColeman = new Champion(136.00, "8 times");
            ronnieColeman.Comp = "Ronnie Coleman";
            ronnieColeman.Height = 180;
            ronnieColeman.Country = "USA";
            ronnieColeman.ShowAchievement();

            Bodybuilder jayCutler = new Second(105.00, "4 times");
            jayCutler.Comp = "Jay Cutler";
            jayCutler.Height = 178;
            jayCutler.Country = "USA";
            jayCutler.ShowAchievement();

            Bodybuilder francoColumbu = new Third(84.00, "3 times");
            francoColumbu.Comp = "Franco Columbu";
            francoColumbu.Height = 165;
            francoColumbu.Country = "Italy";
            francoColumbu.ShowAchievement();

            Trainer charlesGlass = new Trainer("Charles Glass", 65);
            charlesGlass.Train();

            Nutritionist chrisAceto = new Nutritionist("Chris Aceto", "Nutritionist");
            chrisAceto.Consult();
        }
    }

    public abstract class Bodybuilder
    {
        
        public string Comp { get; set; }
        public double Height { get; set; }
        public string Country { get; set; }

        
        protected string Won { get; set; }
        protected double Weight { get; set; }

        
        private string Nickname { get; set; }

        
        public Bodybuilder() { }

        public Bodybuilder(double weight)
        {
            Weight = weight;
        }

        public Bodybuilder(double weight, string won) : this(weight)
        {
            Won = won;
        }

        public Bodybuilder(double weight, string won, string comp) : this(weight, won)
        {
            Comp = comp;
        }

        
        public abstract void ShowAchievement();

        public void SetNickname(string nickname)
        {
            Nickname = nickname;
        }

        public string GetNickname()
        {
            return Nickname;
        }
    }

    public class Champion : Bodybuilder
    {
        public Champion(double weight) : base(weight) { }

        public Champion(double weight, string won) : base(weight, won) { }

        public Champion(double weight, string won, string comp) : base(weight, won, comp) { }

        public override void ShowAchievement()
        {
            Console.WriteLine($"{Comp} - {Won} - {Weight} kg - Champion!");
        }

        public void Lightweight()
        {
            Console.WriteLine($"{Comp} - {Won} - {Weight} kg - Lightweight!");
        }
    }

    public class Second : Bodybuilder
    {
        public Second(double weight) : base(weight) { }

        public Second(double weight, string won) : base(weight, won) { }

        public Second(double weight, string won, string comp) : base(weight, won, comp) { }

        public override void ShowAchievement()
        {
            Console.WriteLine($"{Comp} - {Won} - {Weight} kg - Second Place!");
        }

        public void Lift()
        {
            Console.WriteLine($"{Comp} - {Won} - {Weight} kg - Lift!");
        }
    }

    public class Third : Bodybuilder
    {
        public Third(double weight) : base(weight) { }

        public Third(double weight, string won) : base(weight, won) { }

        public Third(double weight, string won, string comp) : base(weight, won, comp) { }

        public override void ShowAchievement()
        {
            Console.WriteLine($"{Comp} - {Won} - {Weight} kg - Third Place!");
        }

        public void Last()
        {
            Console.WriteLine($"{Comp} - {Won} - {Weight} kg - Last!");
        }
    }

    public interface ITrainer
    {
        void Train();
    }

    public interface INutritionist
    {
        void Consult();
    }

    public class Trainer : ITrainer
    {
        public string Name { get; set; }
        public int Experience { get; set; }

        public Trainer(string name, int experience)
        {
            Name = name;
            Experience = experience;
        }

        public void Train()
        {
            Console.WriteLine($"{Name} with {Experience} years of experience is training the bodybuilders.");
        }
    }

    public class Nutritionist : INutritionist
    {
        public string Name { get; set; }
        public string Specialty { get; set; }

        public Nutritionist(string name, string specialty)
        {
            Name = name;
            Specialty = specialty;
        }

        public void Consult()
        {
            Console.WriteLine($"{Name} specializes in {Specialty} and is consulting the bodybuilders.");
        }
    }
}
