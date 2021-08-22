using System;
using UnityEngine;

namespace RPG.Managers
{
    public abstract class GameManager : MonoBehaviour
    {
        protected abstract void AddEventListeners();

        protected abstract void RemoveEventListeners();
        
        protected virtual void OnEnable()
        {
            AddEventListeners();
        }

        protected virtual void OnDisable()
        {
            RemoveEventListeners();
        }

        protected virtual void Initialize()
        {
            
        }

        protected void StopGame()
        {
            Time.timeScale = 0;
        }

        protected void ResumeGame()
        {
            Time.timeScale = 1;
        }

        private void Start()
        {
            Initialize();
        }
    }
}
