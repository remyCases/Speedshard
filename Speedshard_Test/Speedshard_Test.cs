﻿// Copyright (C) 2023 Rémy Cases
// See LICENSE file for extended copyright information.
// This file is part of the Speedshard repository from https://github.com/remyCases/Speedshard.

using ModShardLauncher;
using ModShardLauncher.Mods;
using System.Collections.Generic;
using System.Linq;

namespace SpeedShard
{
    public class SpeedShard : Mod
    {
        public override string Author => "zizani";
        public override string Name => "SpeedShard - Test";
        public override string Description => "Testing purpose only";
        public override string Version => "1.0.0.0";

        public override void PatchMod()
        {
            SetVerrenRewards();
        }
        
        /// <summary>
        /// Verren is generous
        /// </summary>
        public void SetVerrenRewards()
        {  
            ModLoader.LoadGML("gml_GlobalScript_scr_npc_verren_dlc_ring_reward")
                .MatchFrom("}")
                .InsertAbove(ModFiles, "verren.gml")
                .Peek()
                .Save();
        }
    }
}