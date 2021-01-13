using MVVM.Context;
using MVVM.ViewModel;
using TMPro;
using UniRx;
using UnityEngine;

namespace MVVM.View
{
    public class GameWindowView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI someValue;
        [SerializeField] private ButtonSettings increaseButton;
        [SerializeField] private ButtonSettings decreaseButton;
        [SerializeField] private ButtonSettings clearingButton;

        private GameWindowViewModel viewModel;
        
        private void Start()
        {
            viewModel = new GameWindowViewModel();
            
            var context = new DataContext();
            
            increaseButton.Initialize();
            decreaseButton.Initialize();
            clearingButton.Initialize();
            
            context.BindMethodToButton(increaseButton,x => viewModel.IncreaseValue());
            context.BindMethodToButton(decreaseButton, y=> viewModel.DecreaseValue());
            context.BindMethodToButton(clearingButton, z => viewModel.SetByDefault());
            
            context.BindTextToValue(someValue, viewModel.SomeValue);
        }
    }
}