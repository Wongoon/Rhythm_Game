using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    static public void ToListScene() {
        SceneManager.LoadScene("ListScene");
    }

    static public void ToSettingScene() {
        SceneManager.LoadScene("SettingScene");
    }

    static public void ToStartScene() {
        SceneManager.LoadScene("StartScene");
    }

    static public void ToGameScene() {
        SceneManager.LoadScene("GameScene");
    }

    static public void ToResultScene() {
        SceneManager.LoadScene("ResultScene");
    }

    static public void ExitGame() {
        Application.Quit();
    }
}
