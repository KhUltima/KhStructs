using System.Runtime.CompilerServices;

namespace KhStructs.Kh2.Scenario.World;

// size=variable
/// <summary>
/// Represents a world's event list in memory. This struct expects that its entries follow it in memory, so copying
/// it is invalid. Do not use this if the preconditions are not met.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct WorldEventList {
    public int Dword0;
    public uint NumEntries;

    public Span<WorldEventEntry> Entries =>
        new((WorldEventList*)Unsafe.AsPointer(ref this) + 1, 0x4 * (int)this.NumEntries);
}
