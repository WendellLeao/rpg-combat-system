using System;
using UnityEngine;
using UnityEngine.UI;

namespace RPG.Controllers
{
    public sealed class MainMenuController : MenuController
    {
        [Header("Events")]
        public Action OnPlayIsPressed;

        [Header("UI")]
        [SerializeField] private Button _playButton;
        
        protected override void AddEventListeners()
        {
            _playButton.onClick.AddListener(delegate { OnPlayIsPressed?.Invoke(); });
        }

        protected override void RemoveEventListeners()
        {
            _playButton.onClick.RemoveAllListeners();
        }
    }
}
