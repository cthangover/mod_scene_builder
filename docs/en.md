# Scene Builder — Godot scenes of a mod with a live preview

The Scene Builder edits a mod's Godot scenes (`.tscn`: panels, HUD pieces, banners) on top of a running game screen. You see the scene where it will appear, drag its nodes, change their properties in an inspector and the file is written back without losing the parts of it the builder does not show.

## Opening it

Hammer button on the in-game toolbar → **Scene Builder**.

## Editing a scene

1. **Base scene** — the game screen the mod scene is shown over (or an empty one).
2. **Mod** and **Mod scene (.tscn)** — the file to edit.
3. Pick a node by clicking it in the preview or in **Hierarchy**. Gold is the mod scene's root, bright nodes are editable, faint ones belong to the base scene and are read-only.
4. Drag a node by its body or handles, or change its properties in **Inspector** (numbers, text, colours, switches, positions). Inspector and handle edits save themselves.
5. Add a node of the chosen type into the selected node, or delete the selected node with its children (Del).
6. The **.tscn source** tab shows the text; hand edits there are saved with Ctrl+S, which also rebuilds the preview. **Reload from disk** drops unsaved edits.

Only the changed values are rewritten in the file; resources, connections and properties the inspector does not know stay as they were.

## Limits

- Folder mods only; a packed mod cannot be saved (“the mod is read-only”).
- Nodes of the base scene are shown for orientation and are never written.

## Dependencies

`tools_base`, `ui_base`.
The older `editor_tools` package installs this mod together with the other authoring windows.
