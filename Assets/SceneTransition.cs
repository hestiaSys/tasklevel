using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void GoToStatusScene()
    {
        SceneManager.LoadScene("StatusScene");
    }
    
    public void GoToTaskScene()
    {
        SceneManager.LoadScene("TaskScene");
    }
    
    public void GoToItemScene()
    {
        SceneManager.LoadScene("ItemScene");
    }
    
    public void GoToSettingsScene()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}