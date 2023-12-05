using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using MonsieurMeatman.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;

namespace MonsieurMeatman
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class MonsieurMeatman : BaseUnityPlugin
    {
        private const string ModId = "com.MonsieurMeatman.Mod.Id";
        private const string ModName = "MonsieurMeatman";
        public const string Version = "0.0.1"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "MM";
        public static MonsieurMeatman instance { get; private set; }

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;
            CustomCard.BuildCard<ElvisSandwich>();
        }
    }
}
