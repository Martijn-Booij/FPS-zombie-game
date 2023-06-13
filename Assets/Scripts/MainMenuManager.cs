using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        Cursor.lockState = CursorLockMode.Locked;   // Vergrendel de cursor in het midden van het scherm
        SceneManager.LoadScene(1);   // Laad het spel door over te schakelen naar de tweede scène
    }

    public void QuitGame()
    {
        Debug.Log("Quit");   // Toon een debugbericht in de console om aan te geven dat het spel wordt afgesloten (Dit is in principe niet nodig, maar zo kan je wel zien dat de knop werkt)
        Application.Quit();   // Sluit de toepassing af (werkt alleen bij builds, niet in de editor)
    }
}
