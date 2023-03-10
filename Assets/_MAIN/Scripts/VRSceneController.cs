using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRSceneController : MonoBehaviour
{
    public GameObject popUpWindow;

    // Start is called before the first frame update
    void Start()
    {
        // mematikan pop up window pada saat start
        popUpWindow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // fungsi mengganti ke scene berikutnya
    public void NextScene(string nextScene)
    {
        IEnumerator LoadChangeScene()
        {
            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene(nextScene);
        }
        StartCoroutine(LoadChangeScene());
    }

    // fungsi memunculkan pop up window
    public void PopUp()
    {
        popUpWindow.SetActive(true);
    }

    // fungsi keluar aplikasi
    public void QuitVR()
    {
        Application.Quit();
    }
}
