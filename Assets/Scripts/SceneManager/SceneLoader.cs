using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
    {
        public void LoadMyLevel(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }

