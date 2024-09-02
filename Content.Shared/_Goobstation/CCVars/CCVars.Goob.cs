using Robust.Shared.Configuration;

namespace Content.Shared._Goobstation.CCVar;

[CVarDefs]
public sealed partial class GoobCVars
{
    /// <summary>
    ///     Should the player automatically get up after being knocked down
    /// </summary>
    public static readonly CVarDef<bool> AutoGetUp =
        CVarDef.Create("white.auto_get_up", true, CVar.CLIENT | CVar.ARCHIVE | CVar.REPLICATED); // WD EDIT
}
