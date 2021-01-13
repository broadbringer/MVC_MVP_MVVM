using UniRx;

namespace MVVM.Model
{
    public class GameWindowModel
    {
        public ReactiveProperty<int> AmountOfTree { get; }

        public GameWindowModel()
        {
            AmountOfTree = new ReactiveProperty<int>();
        }
        
        public void IncreaseValue() => AmountOfTree.Value++;
        public void DecreaseValue() => AmountOfTree.Value--;
        public void SetValueByDefault() => AmountOfTree.Value = 0;
    }
}
