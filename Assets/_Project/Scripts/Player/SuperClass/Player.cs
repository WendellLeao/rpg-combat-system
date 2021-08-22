using RPG.GameEvents;
using UnityEngine;

namespace RPG.Player
{
	public abstract class Player : MonoBehaviour
	{
		[Header("Game Events")]
		[SerializeField] protected LocalGameEvents _localGameEvents;
	
		protected virtual void Initialize()
		{
		
		}
	
		private void Start()
		{
			Initialize();
		}
	}
}
