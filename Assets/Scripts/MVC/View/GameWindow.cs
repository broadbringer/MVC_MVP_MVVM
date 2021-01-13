using MVC.Controller;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MVC.View
{
    public class GameWindow : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI displayedValue;
        [SerializeField] private Button increasingValueButton;
        [SerializeField] private Button decreasingValueButton;
        [SerializeField] private Button clearingValueButton;

        private GameWindowController Controller { get; set; }
        
        private void Start()
        {
            Controller = new GameWindowController(this);
           
            increasingValueButton.onClick.AddListener(Controller.IncreaseValue);
            decreasingValueButton.onClick.AddListener(Controller.DecreaseValue);
            clearingValueButton.onClick.AddListener(Controller.ClearValue);
        }

        public void DrawNewValue()
        {
            displayedValue.text = Controller.Model.DisplayedValue.ToString();
        }
    }
}
