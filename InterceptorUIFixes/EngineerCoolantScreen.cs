using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace InterceptorUIFixes
{
    [HarmonyPatch(typeof(PLEngineerCoolantScreen), "Update")]
    class EngineerCoolantScreen
    {
        static void Postfix(PLEngineerCoolantScreen __instance, List<UISprite> ___CoolantPumpBtns)
        {
            if (__instance != null && __instance.MyScreenHubBase.OptionalShipInfo.ShipTypeID == EShipType.OLDWARS_HUMAN)
            {
                ___CoolantPumpBtns[__instance.MyScreenHubBase.OptionalShipInfo.ReactorCoolingPumpState].color = Color.white;
            }
        }
    }
}
