using HarmonyLib;
using UnityEngine;

namespace InterceptorUIFixes
{
    [HarmonyPatch(typeof(PLScientistComputerScreen), "Update")]
    class ScientistComputerScreenPatch
    {
        static void Postfix(PLScientistComputerScreen __instance, UISprite ___Status_ModulateBtn, UISprite ___Status_StaticBtn)
        {
            if(__instance != null && __instance.MyScreenHubBase.OptionalShipInfo.ShipTypeID == EShipType.OLDWARS_HUMAN)
            {
                if (__instance.MyScreenHubBase.OptionalShipInfo.ShieldFreqMode == 0)
                {
                    ___Status_ModulateBtn.color = Color.white;
                }
                else
                {
                    ___Status_StaticBtn.color = Color.white;
                }
            }
        }
    }
}
