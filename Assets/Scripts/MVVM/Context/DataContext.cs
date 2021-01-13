using System;
using MVVM.Interface;
using MVVM.View;
using TMPro;
using UniRx;

namespace MVVM.Context
{
    public class DataContext
    {
        public void BindMethodToButton(IBindableButton button, Action<Unit> action)
        {
            button.Command.Subscribe(action);
            button.Command.BindTo(button.Button);
        }

        public void BindTextToValue(TextMeshProUGUI text, ReactiveProperty<int> value)
        {
            value
                .ObserveEveryValueChanged(x => x.Value)
                .Subscribe( x => text.text = x.ToString());
        }
    }
}