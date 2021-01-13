using MVVM.Model;
using MVVM.View;
using UniRx;
using UnityEngine;

namespace MVVM.ViewModel
{
    public class GameWindowViewModel
    {
        private GameWindowModel model;
        
        public GameWindowViewModel()
        {
            model = new GameWindowModel();
            SomeValue = new ReactiveProperty<int>(0);
            Bind();
        }

        public ReactiveProperty<int> SomeValue;
        
        private void Bind()
        {
            model.AmountOfTree
                .ObserveEveryValueChanged(x => x.Value)
                .Subscribe(xs => SomeValue.Value = xs);
        }

        public void IncreaseValue() => model.IncreaseValue();
        public void DecreaseValue() => model.DecreaseValue();
        public void SetByDefault() => model.SetValueByDefault();
    }
}