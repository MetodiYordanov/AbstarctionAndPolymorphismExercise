namespace Raiding.Models.Heroes
{
    public class Druid : Healer
    {
        private const int DRUID_POWER = 80;

        public Druid(string name) : base(name)
        {
        }

        public override int Power => DRUID_POWER;

        public override string CastAbility()
        {
            return base.CastAbility();
        }
    }
}
