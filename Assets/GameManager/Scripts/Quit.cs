using UnityEngine;

namespace GameManager
{
    public class Quit : MonoBehaviour
    {
        public void QuitGame()
        {
            Time.timeScale = 1;
            Application.Quit();
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #endif
        }
    }
}