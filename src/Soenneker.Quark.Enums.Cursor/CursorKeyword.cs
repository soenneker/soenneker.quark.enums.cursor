using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// An enumeration for Quark, representing html/css cursor types.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public partial class CursorKeyword
{
    public static readonly CursorKeyword Auto = new("auto");

    /// <summary>
    /// The default cursor, typically an arrow.
    /// </summary>
    public static readonly CursorKeyword Default = new("default");

    /// <summary>
    /// A pointer, typically a hand, used for links and clickable items.
    /// </summary>
    public static readonly CursorKeyword Pointer = new("pointer");

    /// <summary>
    /// The text selection cursor (I-beam).
    /// </summary>
    public static readonly CursorKeyword Text = new("text");

    /// <summary>
    /// Indicates that an element is movable.
    /// </summary>
    public static readonly CursorKeyword Move = new("move");

    /// <summary>
    /// A hand indicating an element can be grabbed.
    /// </summary>
    public static readonly CursorKeyword Grab = new("grab");

    /// <summary>
    /// A hand indicating an element is currently being grabbed.
    /// </summary>
    public static readonly CursorKeyword Grabbing = new("grabbing");

    /// <summary>
    /// Indicates the program is busy; the user must wait.
    /// </summary>
    public static readonly CursorKeyword Wait = new("wait");

    /// <summary>
    /// Indicates activity in the background; user can still interact.
    /// </summary>
    public static readonly CursorKeyword Progress = new("progress");

    /// <summary>
    /// Indicates help is available (usually a question mark).
    /// </summary>
    public static readonly CursorKeyword Help = new("help");

    /// <summary>
    /// Indicates that the action is not allowed (slashed circle).
    /// </summary>
    public static readonly CursorKeyword NotAllowed = new("not-allowed");

    public static readonly CursorKeyword None = new("none");
    public static readonly CursorKeyword ContextMenu = new("context-menu");
    public static readonly CursorKeyword Cell = new("cell");
    public static readonly CursorKeyword VerticalText = new("vertical-text");
    public static readonly CursorKeyword Alias = new("alias");
    public static readonly CursorKeyword Copy = new("copy");
    public static readonly CursorKeyword NoDrop = new("no-drop");

    /// <summary>
    /// A crosshair, often used for precise selection.
    /// </summary>
    public static readonly CursorKeyword Crosshair = new("crosshair");

    /// <summary>
    /// Indicates the user can zoom in (magnifying glass with +).
    /// </summary>
    public static readonly CursorKeyword ZoomIn = new("zoom-in");

    /// <summary>
    /// Indicates the user can zoom out (magnifying glass with -).
    /// </summary>
    public static readonly CursorKeyword ZoomOut = new("zoom-out");

    /// <summary>
    /// Indicates that panning is possible in any direction.
    /// </summary>
    public static readonly CursorKeyword AllScroll = new("all-scroll");

    public static readonly CursorKeyword ColResize = new("col-resize");
    public static readonly CursorKeyword RowResize = new("row-resize");
    public static readonly CursorKeyword NResize = new("n-resize");
    public static readonly CursorKeyword EResize = new("e-resize");
    public static readonly CursorKeyword SResize = new("s-resize");
    public static readonly CursorKeyword WResize = new("w-resize");
    public static readonly CursorKeyword NeResize = new("ne-resize");
    public static readonly CursorKeyword NwResize = new("nw-resize");
    public static readonly CursorKeyword SeResize = new("se-resize");
    public static readonly CursorKeyword SwResize = new("sw-resize");

    /// <summary>
    /// Indicates vertical resizing (north–south).
    /// </summary>
    public static readonly CursorKeyword ResizeNorthSouth = new("ns-resize");

    /// <summary>
    /// Indicates horizontal resizing (east–west).
    /// </summary>
    public static readonly CursorKeyword ResizeEastWest = new("ew-resize");

    /// <summary>
    /// Indicates diagonal resizing (north-east to south-west).
    /// </summary>
    public static readonly CursorKeyword ResizeNorthEastSouthWest = new("nesw-resize");

    /// <summary>
    /// Indicates diagonal resizing (north-west to south-east).
    /// </summary>
    public static readonly CursorKeyword ResizeNorthWestSouthEast = new("nwse-resize");
}
