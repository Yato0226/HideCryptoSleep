// Decompiled with JetBrains decompiler
// Type: HideCryptoSleep.HideCryptoSleep_Init
// Assembly: HideCryptoSleep, Version=1.0.7237.40439, Culture=neutral, PublicKeyToken=null
// MVID: 6B59709B-B073-454E-9BD1-72737FDE8763
// Assembly location: C:\Users\louiz\source\repos\HideCryptoSleep\Assemblies\HideCryptoSleep.dll

using Harmony;
using System.Reflection;
using Verse;

#nullable disable
namespace HideCryptoSleep
{
  [StaticConstructorOnStartup]
  internal static class HideCryptoSleep_Init
  {
    static HideCryptoSleep_Init()
    {
      HarmonyInstance.Create("com.github.rimworld.mod.HideCryptoSleep").PatchAll(Assembly.GetExecutingAssembly());
    }
  }
}
