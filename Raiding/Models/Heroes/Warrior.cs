namespace Raiding.Models.Heroes
{
    public class Warrior : Fighter
    {
        private const int WARRIOR_POWER = 100;

        public Warrior(string name) : base(name)
        {
        }

        public override int Power => WARRIOR_POWER;

        public override string CastAbility()
        {
            return base.CastAbility();
        }
    }
}
