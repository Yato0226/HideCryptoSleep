﻿using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using Verse;

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
        if (ThingOwnerUtility.ContentsSuspended(entryList[index].pawn.ParentHolder) || entryList[index].pawn.InContainerEnclosed)
          entryList.Remove(entryList[index]);
      }
    }
  }
}