using HarmonyLib;
using Verse;

namespace ProgressionLESSGravship
{
    public class ProgressionLESSGravshipMod : Mod
    {
        public ProgressionLESSGravshipMod(ModContentPack pack) : base(pack)
        {
            new Harmony("cruesoe.progressionlessgravship").PatchAll();
        }
    }
    
    
}
