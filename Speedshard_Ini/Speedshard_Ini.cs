// Copyright (C) 2023 Rémy Cases
// See LICENSE file for extended copyright information.
// This file is part of the Speedshard repository from https://github.com/remyCases/Speedshard.

using ModShardLauncher;
using ModShardLauncher.Mods;
using System.Collections.Generic;
using System.Linq;

namespace SpeedShardIni
{
    public class SpeedShardIni : Mod
    {
        public override string Author => "zizani";
        public override string Name => "SpeedShard - Ini";
        public override string Description => "Base component of Speedshard";
        public override string Version => "1.0.0.0";

        public override void PatchMod()
        {
            ModLoader.LoadGML("gml_GlobalScript_scr_sessionDataInit")
                .MatchFrom("scr_sessionDataInit\n{")
                .InsertBelow(ModFiles, "load_ini.gml")
                .Peek()
                .Save();
        }
    }
}