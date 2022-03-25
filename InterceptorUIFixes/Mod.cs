using PulsarModLoader;

namespace InterceptorUIFixes
{
    public class Mod : PulsarMod
    {
        public override string Version => "0.0.1";

        public override string Author => "Dragon";

        public override string Name => "InterceptorUIFixes";

        public override string LongDescription => "Changes coolant button color to stand out.";

        public override string HarmonyIdentifier()
        {
            return $"{Author}.{Name}";
        }
    }
}
