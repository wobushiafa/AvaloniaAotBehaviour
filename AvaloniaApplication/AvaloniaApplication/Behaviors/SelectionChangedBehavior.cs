using System;
using Avalonia.Controls.Primitives;

namespace AvaloniaApplication.Behaviors;

public class SelectionChangedBehavior:Event2CommandBehaviour<SelectingItemsControl>
{
    protected override void RegistEvent(SelectingItemsControl obj)
    {
        obj.SelectionChanged += ProxyMethod;
        base.RegistEvent(obj);
    }

    protected override void UnRegistEvent(SelectingItemsControl obj)
    {
        obj.SelectionChanged -= ProxyMethod;
        base.UnRegistEvent(obj);
    }
}