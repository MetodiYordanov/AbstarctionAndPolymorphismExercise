namespace Raiding.Models.Heroes
{
    public class Rogue : Fighter
    {
        private const int ROGUE_POWER = 80;

        public Rogue(string name) : base(name)
        {
        }

        public override int Power => ROGUE_POWER;

        public override string CastAbility()
        {
            return base.CastAbility();
        }
    }
}
