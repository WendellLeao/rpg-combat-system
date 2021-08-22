using UnityEngine;

namespace RPG.Controllers
{
    public abstract class MenuController : MonoBehaviour
    {
        [SerializeField] private MenuType _menuType;
        
        public void ShowMenu()
        {
            this.gameObject.SetActive(true);
        }

        public void HideMenu()
        {
            this.gameObject.SetActive(false);
        }
        
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

        public MenuType GetMenuType()
        {
            return _menuType;
        }
    }
}
