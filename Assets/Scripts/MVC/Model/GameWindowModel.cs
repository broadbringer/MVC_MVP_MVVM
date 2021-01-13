using System;

namespace MVC.Models
{
    public class GameWindowModel
    {
        public event Action<int> DisplayedValueChanged;
        public int DisplayedValue => displayedValue;
        
        private int displayedValue;

        public GameWindowModel()
        {
            displayedValue = 0;
        }

        public void IncreaseValue(int value = 1)
        {
            displayedValue += value;
            DisplayedValueChanged?.Invoke(displayedValue);
        }
        
        public void DecreaseValue(int value = 1)
        {
            if (displayedValue <= 0) return;
            
            displayedValue -= value;
            DisplayedValueChanged?.Invoke(displayedValue);
        }

        public void SetValueOnZero()
        {
            displayedValue = 0;
            DisplayedValueChanged?.Invoke(displayedValue);
        }
    }
}
