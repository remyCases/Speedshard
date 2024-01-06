using ModShardLauncher;
using ModShardLauncher.Mods;
using UndertaleModLib;
using UndertaleModLib.Models;
using System.Collections.Generic;
using Serilog;

namespace SpeedShardCampbed;
public class SpeedShardCampbed : Mod
{
    public override string Author => "zizani";
    public override string Name => "Speedshard - Campbed";
    public override string Description => "Campbed can last longer";
    public override string Version => "0.1.0.0";
    
    public override void PatchMod()
    {
        ModLoader.LoadGML("gml_Object_c_bed_sleep_crafted_Alarm_0")
            .MatchFrom("if (_days")
            .ReplaceBy("if (_days >= global.campbed_despawn_days)")
            .Peek()
            .Save();
    }
}