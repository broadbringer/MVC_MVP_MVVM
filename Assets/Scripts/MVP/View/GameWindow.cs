using MVP.Presenter;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MVP.View
{
    public class GameWindow : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI displayedValue;
        [SerializeField] private Button increasingValueButton;
        [SerializeField] private Button decreasingValueButton;
        [SerializeField] private Button clearingValueButton;
        
        public GameWindowPresenter Presenter { get; private set; }

        
        private void Start()
        {
            Presenter = new GameWindowPresenter(this);
           
            increasingValueButton.onClick.AddListener(Presenter.IncreaseValue);
            decreasingValueButton.onClick.AddListener(Presenter.DecreaseValue);
            clearingValueButton.onClick.AddListener(Presenter.ClearValue);
        }

        public void DrawNewValue(int value)
        {
            displayedValue.text = value.ToString();
        }
    }
}
