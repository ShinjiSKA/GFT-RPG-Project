namespace ProjetoRPG.src.Entities
{
    public class BlackWizard : Wizard
    {
        public BlackWizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
    }
}