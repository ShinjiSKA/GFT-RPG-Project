namespace ProjetoRPG.src.Entities

{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public Wizard()
        {

        }

        public override string Attack()
        {
            return this.Name + " cast a spell";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " cast a very efective speel with a bonus of " + Bonus;
            }
            else
            {
                return this.Name + " cast a very weakened speel with a bonus of " + Bonus;
            }
        }
    }

}