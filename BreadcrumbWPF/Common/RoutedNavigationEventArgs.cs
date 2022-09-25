using BreadcrumbWPF.Controls.Interface;
using System.Windows;

namespace BreadcrumbWPF.Common;

public class RoutedNavigationEventArgs : RoutedEventArgs
{
    public INavigationItem CurrentPage { get; set; }

    public RoutedNavigationEventArgs(RoutedEvent routedEvent, object source, INavigationItem currentPage) : base(
        routedEvent, source)
    {
        CurrentPage = currentPage;
    }
}
