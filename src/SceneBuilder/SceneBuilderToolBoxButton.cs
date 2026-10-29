namespace Cthangover.Core.UI.Tool.SceneBuilder
{
    /// <summary>Exposes the Godot scene builder in the in-game toolbar's tools list.</summary>
    public class SceneBuilderToolBoxButton : IToolBoxButton
    {
        /// <inheritdoc />
        public string ToolId => "scene_builder";

        /// <inheritdoc />
        public string IconPath => "";

        /// <inheritdoc />
        public string LocaleKey => "tools/scene_builder/title";

        /// <inheritdoc />
        public bool IsVisible() => true;
    }
}
