using UnityEngine;
using UnityEngine.UI;
using RPG.GameEvents;

namespace RPG.Health
{
	public sealed class HealthBar : MonoBehaviour
	{
		[Header("Game Events")]
		[SerializeField] private LocalGameEvents _localGameEvents;

		[Header("UI Elements")]
		[SerializeField] private Image _healthBarImage;

		private void OnEnable()
		{
			AddEventListeners();
		}

		private void OnDisable()
		{
			RemoveEventListeners();
		}

		private void AddEventListeners()
		{
			_localGameEvents.OnPlayerGetHitted += OnPlayerGetHitted_UpdateHealthBar;
		}

		private void RemoveEventListeners()
		{
			_localGameEvents.OnPlayerGetHitted -= OnPlayerGetHitted_UpdateHealthBar;
		}

		private void OnPlayerGetHitted_UpdateHealthBar(int currentHealthAmount, int maxHealthAmount)
		{
			float healthPercent = (float) currentHealthAmount / maxHealthAmount;

			_healthBarImage.fillAmount = healthPercent;
		}
	}
}
