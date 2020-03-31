using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void HighScore()
    {
        SceneManager.LoadScene("HighScore");
    }
    public void Options()
    {
        SceneManager.LoadScene("Option");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Sounds()
    {
    }
}
