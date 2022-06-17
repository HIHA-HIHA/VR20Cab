using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoaderScene : MonoBehaviour
{
    [SerializeField]
    private GameObject loadingPanel;

    [SerializeField]
    private Image progressBar;

    [SerializeField]
    private string nameScene;

    [SerializeField]
    private float timeAwaitBeforStart;

    private List<AsyncOperation> operations;
    public void StartLoading()
    {
        loadingPanel.SetActive(true);
        operations = new List<AsyncOperation>();
        StartCoroutine(AsyncLoadScene());
    }

    private IEnumerator AsyncLoadScene()
    {
        yield return new WaitForSeconds(timeAwaitBeforStart);

        operations.Add(SceneManager.LoadSceneAsync(nameScene));

        foreach (var operation in operations)
        {
            while (!operation.isDone)
            {
                float totalProgress = 0;

                foreach(var _operation in operations)
                {
                    totalProgress += _operation.progress;
                }


                Debug.Log(operation.progress);
                progressBar.fillAmount = (totalProgress /2) * 100f;
                yield return null;
            }
        }
       
    }
}
