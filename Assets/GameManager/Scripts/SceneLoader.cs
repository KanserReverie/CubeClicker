using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameManager
{
	public class SceneLoader : MonoBehaviour
	{
		public void LoadScene(int level)
		{
			SceneManager.LoadScene(level);
		}
	}
}