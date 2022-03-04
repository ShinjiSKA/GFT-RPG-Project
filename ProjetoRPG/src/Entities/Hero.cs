namespace ProjetoRPG.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public Hero()
        {

        }

        public string Name;
        public int Level;
        public string HeroType;
        public int HP;
        public int MP;

        public override string ToString()
        {
            return this.Name + " " + Level + " " + HeroType + " " + HP + " " + MP;
        }

        public virtual string Attack()
        {
            return this.Name + " attacked with a sword";
        }

    }
}