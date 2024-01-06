// Copyright (C) 2023 Rémy Cases
// See LICENSE file for extended copyright information.
// This file is part of the Speedshard repository from https://github.com/remyCases/Speedshard.

using ModShardLauncher;
using ModShardLauncher.Mods;
using Serilog;

namespace Speedshard_MorePointAtStart;
public class Speedshard_MorePointAtStart : Mod
{
    public override string Author => "zizani";
    public override string Name => "SpeedShard - MorePointAtStart";
    public override string Description => "Increase the AP and SP avalaible when creating a new character";
    public override string Version => "1.0.0.0";

    public override void PatchMod()
    {
        ModLoader.LoadGML("gml_GlobalScript_scr_characterMapInit")
            .MatchBelow("OldXP", 2) // match the 2 lines below the moment I found OldXP
            .ReplaceBy(ModFiles, "more_point_at_start.gml") // replace by the code in that file
            .Peek()
            .Save(); // save it back
    }
}
