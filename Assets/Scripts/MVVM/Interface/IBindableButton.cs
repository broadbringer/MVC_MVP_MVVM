using UniRx;
using UnityEngine.UI;

namespace MVVM.Interface
{
    public interface IBindableButton
    {
        Button Button { get; set; }
        ReactiveCommand Command { get; set; }
    }
}