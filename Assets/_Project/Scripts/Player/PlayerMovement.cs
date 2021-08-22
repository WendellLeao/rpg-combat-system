using UnityEngine.AI;
using UnityEngine;

namespace RPG.Player.Inputs
{
	public sealed class PlayerMovement : Player
	{
		[Header("Camera")]
		[SerializeField] private Camera _camera;

		[Header("A.I")]
		[SerializeField] private NavMeshAgent _navMeshAgent;
	
		private void Update()
		{
			HandleMovement();
		}

		private void HandleMovement()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

				if (Physics.Raycast(ray, out RaycastHit hit))
				{
					_navMeshAgent.SetDestination(hit.point);
				}
			}
		}
	}
}
