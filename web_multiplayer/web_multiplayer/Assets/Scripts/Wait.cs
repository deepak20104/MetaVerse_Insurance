using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAfterTime : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 2f;
    [SerializeField]
    private string sceneNameToLoad;
    private float timeElapsed;

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene("login_screen");
        }
    }
}