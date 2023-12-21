namespace Raiding.Models.Heroes
{
    public class Paladin : Healer
    {
        private const int PALADIN_POWER = 100;

        public Paladin(string name) : base(name)
        {
        }

        public override int Power => PALADIN_POWER;

        public override string CastAbility()
        {
            return base.CastAbility();
        }
    }
}
