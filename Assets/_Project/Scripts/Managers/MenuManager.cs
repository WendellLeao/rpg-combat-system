using System.Collections.Generic;
using RPG.Controllers;
using UnityEngine;

namespace RPG.Managers
{
	public sealed class MenuManager : GameManager
	{
		[Header("Menu Controllers")]
		[SerializeField] private List<MenuController> _menuControllers;

		[SerializeField] private MainMenuController _mainMenuController;

		protected override void Initialize()
		{
			StopGame();
			
			ShowMenu(MenuType.MAIN);
		}

		protected override void AddEventListeners()
		{
			_mainMenuController.OnPlayIsPressed += delegate { ShowMenu(MenuType.DIFFICULTY); };
		}

		protected override void RemoveEventListeners()
		{
			_mainMenuController.OnPlayIsPressed -= delegate { ShowMenu(MenuType.DIFFICULTY); };
		}
		
		private void ShowMenu(MenuType menuType)
		{
			foreach (MenuController menuController in _menuControllers)
			{
				menuController.HideMenu();

				if (menuType == menuController.GetMenuType())
				{
					menuController.ShowMenu();
				}
			}
		}
	}
}
