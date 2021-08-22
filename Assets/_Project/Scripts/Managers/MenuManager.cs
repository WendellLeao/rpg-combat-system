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

		[SerializeField] private DifficultyMenuController _difficultyMenuController;
		
		protected override void AddEventListeners()
		{
			_mainMenuController.OnPlayIsPressed += OnPlayIsPressed_ShowDifficultyMenu;
		}

		protected override void RemoveEventListeners()
		{
			_mainMenuController.OnPlayIsPressed -= OnPlayIsPressed_ShowDifficultyMenu;
		}
		
		private void ShowMenu(MenuType menuType)
		{
			foreach (MenuController menuController in _menuControllers)
			{
				menuController.HideMenu();

				if (menuType == menuController.GetMenuType())
				{
					menuController.ShowMenu();

					return;
				}
			}
		}

		private void OnPlayIsPressed_ShowDifficultyMenu()
		{
			ShowMenu(MenuType.DIFFICULTY);
		}
	}
}
