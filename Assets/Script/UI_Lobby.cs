using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Lobby : MonoBehaviour
{
    
    void Start()
    {
        
    }
    
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
