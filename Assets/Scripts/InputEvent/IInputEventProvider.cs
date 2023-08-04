using System;
using UniRx;
using UnityEngine;

namespace InputEvent
{
    public interface IInputEventProvider
    {

        IObservable<float> HorizontalObservable { get; }    //水平方向の入力

        IReadOnlyReactiveProperty<bool> IsJump { get; }
    }
}