using System.Windows;
using System.Windows.Data;
using Simple.Wpf.Terminal.Common;

namespace Simple.Wpf.Terminal;

public interface ITerminalEx : ITerminal
{
    ///     The error color for the bound items.
    IValueConverter LineColorConverter { get; set; }

    ///     The individual line height for the bound items.
    int ItemHeight { get; set; }

    ///     The margin around the bound items.
    Thickness ItemsMargin { get; set; }
}
