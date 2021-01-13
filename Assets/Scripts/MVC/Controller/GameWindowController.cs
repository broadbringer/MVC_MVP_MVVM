using MVC.Model;
using MVC.View;

namespace MVC.Controller
{
    public class GameWindowController
    {
        public readonly GameWindowModel Model;
        
        private readonly GameWindow view;
        
        public GameWindowController(GameWindow view)
        {
            this.view = view;
            Model = new GameWindowModel();
            
            Model.DisplayedValueChanged += UpdateDisplayedValue;
        }

        public void IncreaseValue() => Model.IncreaseValue();
        public void DecreaseValue() => Model.DecreaseValue();
        public void ClearValue() => Model.SetValueOnZero();
        
        private void UpdateDisplayedValue(int value) => view.DrawNewValue();
        
    }
}










