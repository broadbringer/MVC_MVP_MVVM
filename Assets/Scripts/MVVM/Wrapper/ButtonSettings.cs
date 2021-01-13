using MVVM.Interface;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace MVVM.View
{
    public class ButtonSettings : MonoBehaviour, IBindableButton
    {
        public Button Button { get; set; }
        public ReactiveCommand Command { get; set; }
        
        public void Initialize()
        {
            Button = GetComponent<Button>();
            Command = new ReactiveCommand();
        }
    }
}