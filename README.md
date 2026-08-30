[![](https://img.shields.io/nuget/v/soenneker.quark.enums.cursor.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.cursor/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.cursor/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.cursor/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.cursor/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.cursor/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.cursor.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.cursor/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.cursor/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.cursor/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.Cursor

Strongly named CSS cursor keyword values for Quark component properties and utility-class composition.

## Installation

```bash
dotnet add package Soenneker.Quark.Enums.Cursor
```

## Usage

```csharp
using Soenneker.Quark;

CursorKeyword cursor = CursorKeyword.Pointer;

string css = $"cursor: {cursor.Value};";
// cursor: pointer;

string tailwindClass = $"cursor-{cursor.Value}";
// cursor-pointer
```

Common values include `Auto`, `Default`, `Pointer`, `Text`, `Move`, `Grab`, `Grabbing`, `Wait`, `Progress`, `Help`, `NotAllowed`, `None`, `Crosshair`, `ZoomIn`, `ZoomOut`, `Copy`, and `NoDrop`.

Resize values cover column/row, cardinal directions, and the CSS combined forms:

| Value | CSS keyword |
| --- | --- |
| `ResizeNorthSouth` | `ns-resize` |
| `ResizeEastWest` | `ew-resize` |
| `ResizeNorthEastSouthWest` | `nesw-resize` |
| `ResizeNorthWestSouthEast` | `nwse-resize` |

The type also includes Quark's global CSS keywords such as `Inherit`, `Initial`, and `Unset` through `GlobalKeyword`.
