using System.Drawing;
using ExileCore2;
using ExileCore2.PoEMemory;
using ExileCore2.PoEMemory.Components;
using ExileCore2.PoEMemory.Elements;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.Shared.Helpers;
using Vector2 = System.Numerics.Vector2;

namespace UniqueFinder;

public class GroundItemInstance(LabelOnGround labelOnGround, WorldItem worldItem, Mods mods, RenderItem renderItem, string itemName, GameController gc)
{
    public Entity WorldEntity => labelOnGround.ItemOnGround;
    public Vector2 Location => WorldEntity.GridPos;
    public float Distance => gc?.Player?.GridPos.Distance(Location) ?? float.MaxValue;

    public Color TextColor => labelOnGround.Label.TextColor;
    public Color BorderColor => labelOnGround.Label.BordColor;
    public Color BackgroundColor => labelOnGround.Label.BgColor;

    public string ItemName => itemName;

    public Element Label => labelOnGround.Label;
}