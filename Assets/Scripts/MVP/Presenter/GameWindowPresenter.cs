using MVP.Model;
using MVP.View;

namespace MVP.Presenter
{
    public class GameWindowPresenter
    {
        private readonly GameWindowModel model;
        private readonly GameWindow view;
        
        public GameWindowPresenter(GameWindow view)
        {
            this.view = view;
            model = new GameWindowModel();
            
            model.DisplayedValueChanged += UpdateDisplayedValue;
        }

        private void UpdateDisplayedValue(int value) => view.DrawNewValue(value);

        public void IncreaseValue() => model.IncreaseValue();
        public void DecreaseValue() => model.DecreaseValue();
        public void ClearValue() => model.SetValueOnZero();
    }
}