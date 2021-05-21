using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string SceneToLoad;
    public Vector2 PlayerPosition;
    public VectorValue PlayerStorage;
    public GameObject FadeInPanel;
    public GameObject FadeOutPanel;
    public float FadeWait;

    private void Awake()
    {
        if (FadeInPanel != null)
        {
            GameObject panel = Instantiate(FadeInPanel, Vector3.zero, Quaternion.identity) as GameObject;
            Destroy(panel, 1);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !other.isTrigger)
        {
            PlayerStorage.InitialValue = PlayerPosition;
            //SceneManager.LoadScene(SceneToLoad);
            StartCoroutine(FadeCo());
        }
    }

    public IEnumerator FadeCo()
    {
        if (FadeOutPanel != null)
        {
            Instantiate(FadeOutPanel, Vector3.zero, Quaternion.identity);
        }
        yield return new WaitForSeconds(FadeWait);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(SceneToLoad);
        while(!asyncOperation.isDone)
        {
            yield return null;
        }
    }
}
