using MVC.Models;
using MVC.Views;


namespace MVC.Controllers
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

        private void UpdateDisplayedValue(int value) => view.DrawNewValue();

        public void IncreaseValue() => Model.IncreaseValue();
        public void DecreaseValue() => Model.DecreaseValue();
        public void ClearValue() => Model.SetValueOnZero();
    }
}










