﻿// Copyright (C) 2023 Rémy Cases
// See LICENSE file for extended copyright information.
// This file is part of the Speedshard repository from https://github.com/remyCases/Speedshard.

using ModShardLauncher;
using ModShardLauncher.Mods;
using System.Collections.Generic;
using System.Linq;

namespace SpeedShardWater
{
    public class SpeedShardWater : Mod
    {
        public override string Author => "zizani";
        public override string Name => "SpeedShard - Water";
        public override string Description => "Expand the charges of some water container";
        public override string Version => "1.0.0.0";

        public List<string> WaterContainers = new List<string>();

        public override void PatchMod()
        {
            LoadWaterContainers();
            SetWaterCharge();
        }
        
        /// <summary>
        /// load all water containers need to set
        /// </summary>
        public void LoadWaterContainers()
        {
            WaterContainers.Add("gml_Object_o_inv_wooden_bucket_water_Create_0");
            WaterContainers.Add("gml_Object_o_inv_hunting_horn_water_Create_0");
            WaterContainers.Add("gml_Object_o_inv_golden_cup_water_Create_0");
            WaterContainers.Add("gml_Object_o_inv_clay_pot_water_Create_0");
            WaterContainers.Add("gml_Object_o_inv_wineskin_Create_0");
        }
        /// <summary>
        /// add this code
        /// </summary>
        public void SetWaterCharge()
        {
            foreach(var item in WaterContainers)
                ModLoader.LoadGML(item)
                    .MatchFrom("charge")
                    .InsertBelow(ModFiles, "water.gml")
                    .Peek()
                    .Save();
        }
    }
}