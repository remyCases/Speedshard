// Copyright (C) 2023 Rémy Cases
// See LICENSE file for extended copyright information.
// This file is part of the Speedshard repository from https://github.com/remyCases/Speedshard.

using ModShardLauncher;
using ModShardLauncher.Mods;

namespace Speedshard_Reputation;
public class Speedshard_Reputation : Mod
{
    public override string Author => "zizani";
    public override string Name => "Speedshard - Reputation";
    public override string Description => "Changing reputation gained in-game.";
    public override string Version => "1.0.0.0";

    public override void PatchMod()
    {
        ModLoader.LoadGML("gml_GlobalScript_scr_village_reputation_add")
            .MatchFrom("_reputation_prev + argument0")
            .InsertAbove(ModFiles, "village_reputation_add.gml")
            .Peek()
            .Save();
            
        ModLoader.LoadGML("gml_GlobalScript_scr_reputationLog")
            .MatchFrom(@"ds_map_set(_logDataMap, ""reputation"", argument1)")
            .InsertAbove(ModFiles, "reputationLog.gml")
            .Peek()
            .Save();
    }
}
