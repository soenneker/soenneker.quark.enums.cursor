[![](https://img.shields.io/nuget/v/soenneker.quark.enums.cursor.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.cursor/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.cursor/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.cursor/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.cursor.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.cursor/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.cursor/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.cursor/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.Cursor

An enumeration for Quark, representing html/css cursor types.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.Cursor
```

## What you get

- `CursorKeyword` — An enumeration for Quark, representing html/css cursor types.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `CursorKeyword.Default` | The default cursor, typically an arrow. | The default cursor, typically an arrow. |
| `CursorKeyword.Pointer` | A pointer, typically a hand, used for links and clickable items. | A pointer, typically a hand, used for links and clickable items. |
| `CursorKeyword.Text` | The text selection cursor (I-beam). | The text selection cursor (I-beam). |
| `CursorKeyword.Move` | Indicates that an element is movable. | Indicates that an element is movable. |
| `CursorKeyword.Grab` | A hand indicating an element can be grabbed. | A hand indicating an element can be grabbed. |
| `CursorKeyword.Grabbing` | A hand indicating an element is currently being grabbed. | A hand indicating an element is currently being grabbed. |
| `CursorKeyword.Wait` | Indicates the program is busy; the user must wait. | Indicates the program is busy; the user must wait. |
| `CursorKeyword.Progress` | Indicates activity in the background; user can still interact. | Indicates activity in the background; user can still interact. |
| `CursorKeyword.Help` | Indicates help is available (usually a question mark). | Indicates help is available (usually a question mark). |
| `CursorKeyword.NotAllowed` | Indicates that the action is not allowed (slashed circle). | Indicates that the action is not allowed (slashed circle). |
| `CursorKeyword.Crosshair` | A crosshair, often used for precise selection. | A crosshair, often used for precise selection. |
| `CursorKeyword.ZoomIn` | Indicates the user can zoom in (magnifying glass with +). | Indicates the user can zoom in (magnifying glass with +). |
| `CursorKeyword.ZoomOut` | Indicates the user can zoom out (magnifying glass with -). | Indicates the user can zoom out (magnifying glass with -). |
| `CursorKeyword.AllScroll` | Indicates that panning is possible in any direction. | Indicates that panning is possible in any direction. |
| `CursorKeyword.ResizeNorthSouth` | Indicates vertical resizing (north–south). | Indicates vertical resizing (north–south). |
| `CursorKeyword.ResizeEastWest` | Indicates horizontal resizing (east–west). | Indicates horizontal resizing (east–west). |
| `CursorKeyword.ResizeNorthEastSouthWest` | Indicates diagonal resizing (north-east to south-west). | Indicates diagonal resizing (north-east to south-west). |
| `CursorKeyword.ResizeNorthWestSouthEast` | Indicates diagonal resizing (north-west to south-east). | Indicates diagonal resizing (north-west to south-east). |
