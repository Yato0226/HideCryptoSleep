using HarmonyLib;
using System.Reflection;
using Verse;

namespace HideCryptoSleep
{
  [StaticConstructorOnStartup]
  internal static class HideCryptoSleep_Init
  {
    static HideCryptoSleep_Init()
    {
            var harmony = new Harmony("com.github.rimworld.mod.HideCryptoSleep");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
  }
}
