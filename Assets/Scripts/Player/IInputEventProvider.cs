using System;
using UniRx;

namespace Merusenne.Player
{
    public interface IInputEventProvider
    {

        IReadOnlyReactiveProperty<float> AxisH { get; }    //水平方向の入力
        IReadOnlyReactiveProperty<bool> IsJump { get; }
        IReadOnlyReactiveProperty<bool> IsUpSwitch { get; }
        IReadOnlyReactiveProperty<bool> IsDownSwitch { get; }

    }
}