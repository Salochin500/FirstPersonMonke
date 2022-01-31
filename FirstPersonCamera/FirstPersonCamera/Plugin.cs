using BepInEx;
using System;
using UnityEngine;

namespace FirstPersonCamera
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Start()
        {
            HarmonyPatches.ApplyHarmonyPatches();

            var camera = GameObject.Find("Shoulder Camera")?.GetComponent<Camera>();

            camera.enabled = false;
            Console.WriteLine("Set to first person");
        }
    }
}
