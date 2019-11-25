using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PictureHandler : MonoBehaviour
{
    private void Start() {

    }
    
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            ScreenshotHandler.TakeScreenshot_Static(Screen.width, Screen.height);
            SceneManager.LoadScene("PhotoEnding");
        }
    }
    
    public void ContinueToTakePhoto() {
        SceneManager.LoadScene("PhotoScene");
    }

    public void TakeAnotherPhoto() {
        SceneManager.LoadScene("CharacterSelection");
    }
}
