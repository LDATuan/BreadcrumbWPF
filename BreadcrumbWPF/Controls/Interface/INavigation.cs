using BreadcrumbWPF.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BreadcrumbWPF.Controls.Interface;

public class INavigation
{
    int SelectedPageIndex { get; set; }

    INavigationItem Current { get; set; }

    [Bindable(true)]
    Frame Frame { get; set; }

    [Bindable(true)]
    ObservableCollection<INavigationItem> Items { get; set; }

    [Category("Behavior")]
    event RoutedNavigationEvent Navigated;
}