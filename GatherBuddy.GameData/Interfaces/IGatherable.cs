using System.Collections.Generic;
using GatherBuddy.Utility;
using Lumina.Excel.GeneratedSheets;

namespace GatherBuddy.Interfaces;

public enum ObjectType : byte
{
    Invalid,
    Gatherable,
    Fish,
}

public interface IGatherable
{
    public MultiString            Name            { get; }
    public IEnumerable<ILocation> Locations       { get; }
    public int                    InternalLocationId { get; }
    public uint                   ItemId          { get; }
    public Item                   ItemData        { get; }
    public ObjectType             Type            { get; }
}
