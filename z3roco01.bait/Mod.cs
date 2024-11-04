using GDWeave;

namespace z3roco01.bait;

public class Mod : IMod {
    public static IModInterface ModInterface;

    public Mod(IModInterface modInterface) {
        ModInterface = modInterface;
        modInterface.Logger.Information("getting baited rn");
    }

    public void Dispose() {
    }
}
