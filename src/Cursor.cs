using Intellenum;

namespace Soenneker.Quark;

/// <summary>
/// An enumeration for Quark, representing html/css cursor types.
/// </summary>
[Intellenum<string>]
public partial class Cursor
{
    /// <summary>
    /// The default cursor, typically an arrow.
    /// </summary>
    public static readonly Cursor Default = new("default");

    /// <summary>
    /// A pointer, typically a hand, used for links and clickable items.
    /// </summary>
    public static readonly Cursor Pointer = new("pointer");

    /// <summary>
    /// The text selection cursor (I-beam).
    /// </summary>
    public static readonly Cursor Text = new("text");

    /// <summary>
    /// Indicates that an element is movable.
    /// </summary>
    public static readonly Cursor Move = new("move");

    /// <summary>
    /// A hand indicating an element can be grabbed.
    /// </summary>
    public static readonly Cursor Grab = new("grab");

    /// <summary>
    /// A hand indicating an element is currently being grabbed.
    /// </summary>
    public static readonly Cursor Grabbing = new("grabbing");

    /// <summary>
    /// Indicates the program is busy; the user must wait.
    /// </summary>
    public static readonly Cursor Wait = new("wait");

    /// <summary>
    /// Indicates activity in the background; user can still interact.
    /// </summary>
    public static readonly Cursor Progress = new("progress");

    /// <summary>
    /// Indicates help is available (usually a question mark).
    /// </summary>
    public static readonly Cursor Help = new("help");

    /// <summary>
    /// Indicates that the action is not allowed (slashed circle).
    /// </summary>
    public static readonly Cursor NotAllowed = new("not-allowed");

    /// <summary>
    /// A crosshair, often used for precise selection.
    /// </summary>
    public static readonly Cursor Crosshair = new("crosshair");

    /// <summary>
    /// Indicates the user can zoom in (magnifying glass with +).
    /// </summary>
    public static readonly Cursor ZoomIn = new("zoom-in");

    /// <summary>
    /// Indicates the user can zoom out (magnifying glass with -).
    /// </summary>
    public static readonly Cursor ZoomOut = new("zoom-out");

    /// <summary>
    /// Indicates that panning is possible in any direction.
    /// </summary>
    public static readonly Cursor AllScroll = new("all-scroll");

    /// <summary>
    /// Indicates vertical resizing (north–south).
    /// </summary>
    public static readonly Cursor ResizeNorthSouth = new("ns-resize");

    /// <summary>
    /// Indicates horizontal resizing (east–west).
    /// </summary>
    public static readonly Cursor ResizeEastWest = new("ew-resize");

    /// <summary>
    /// Indicates diagonal resizing (north-east to south-west).
    /// </summary>
    public static readonly Cursor ResizeNorthEastSouthWest = new("nesw-resize");

    /// <summary>
    /// Indicates diagonal resizing (north-west to south-east).
    /// </summary>
    public static readonly Cursor ResizeNorthWestSouthEast = new("nwse-resize");

    public static implicit operator Cursor(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}