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
    }
}
