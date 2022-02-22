using System.Windows.Input;

namespace CsStarter.UI
{
    internal sealed record ViewPanelCommandInfo(string Name, ICommand Command);
}
