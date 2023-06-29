﻿using FFXIVClientStructs.FFXIV.Client.UI.Agent;
using GatherBuddy.Interfaces;

namespace GatherBuddy.Utility;

public static class Maps
{
    public static int MarkerToMap(double coord, double scale)
        => (int)(2 * coord / scale + 100.9);

    public static int NodeToMap(double coord, double scale)
        => (int)(2 * coord + 2048 / scale + 100.9);

    public static int IntegerToInternal(int coord, double scale)
        => (int)(coord - 100 - 2048 / scale) / 2;

    public static unsafe void SetFlagMarker(AgentMap* instance, IMarkable location, uint iconId = 60561U)
    {
        instance->IsFlagMarkerSet = 0;
        var x = IntegerToInternal(location.IntegralXCoord, location.Territory.SizeFactor);
        var y = IntegerToInternal(location.IntegralYCoord, location.Territory.SizeFactor);
        instance->SetFlagMapMarker(location.Territory.Id, location.Territory.Data.Map.Row, x, y, iconId);
    }
}
