using Avalonia.Controls;

namespace AvaloniaApplication.Behaviors;

public class PointerMovedBehavior:Event2CommandBehaviour<Control>
{
    protected override void RegistEvent(Control obj)
    {
        obj.PointerMoved += ProxyMethod;
        base.RegistEvent(obj);
    }

    protected override void UnRegistEvent(Control obj)
    {
        obj.PointerMoved -= ProxyMethod;
        base.UnRegistEvent(obj);
    }
}