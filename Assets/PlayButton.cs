using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {
    // Start is called before the first frame update
    public void Playgame() {

        SceneManager.LoadSceneAsync(1);
    }
    public void QuitGame() {
        Application.Quit();
    }
}
