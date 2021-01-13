using MVVM.Model;
using UniRx;

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
        
        public void IncreaseValue() => model.IncreaseValue();
        public void DecreaseValue() => model.DecreaseValue();
        public void SetByDefault() => model.SetValueByDefault();
        
        private void Bind()
        {
            model.AmountOfTree
                .ObserveEveryValueChanged(x => x.Value)
                .Subscribe(xs => SomeValue.Value = xs);
        }

        
    }
}