// Decompiled with JetBrains decompiler
// Type: HideCryptoSleep.RecachePawns_Patch
// Assembly: HideCryptoSleep, Version=1.0.7237.40439, Culture=neutral, PublicKeyToken=null
// MVID: 6B59709B-B073-454E-9BD1-72737FDE8763
// Assembly location: C:\Users\louiz\source\repos\HideCryptoSleep\Assemblies\HideCryptoSleep.dll

using Harmony;
using RimWorld;
using System.Collections.Generic;
using Verse;

#nullable disable
namespace HideCryptoSleep
{
  [HarmonyPatch(typeof (ColonistBar), "CheckRecacheEntries")]
  public static class RecachePawns_Patch
  {
    [HarmonyPostfix]
    private static void Postfix(ref PawnTable __instance)
    {
      List<ColonistBar.Entry> entryList = Traverse.Create((object) __instance).Field("cachedEntries").GetValue<List<ColonistBar.Entry>>();
      for (int index = 0; index < entryList.Count; ++index)
      {
        if (ThingOwnerUtility.ContentsSuspended(entryList[index].pawn.ParentHolder))
          entryList.Remove(entryList[index]);
      }
    }
  }
}
