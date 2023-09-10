using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string levelToLoad = "Level1";
    public string shopScreen = "Shop";
    // Start is called before the first frame update

   

    public void Play () {
        SceneManager.LoadScene(levelToLoad);
    }

    public void Shop () {
        SceneManager.LoadScene(shopScreen);
    }

    public void Quit () {
        Application.Quit();
    }


    

    
}
