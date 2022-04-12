using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    public void GotoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
