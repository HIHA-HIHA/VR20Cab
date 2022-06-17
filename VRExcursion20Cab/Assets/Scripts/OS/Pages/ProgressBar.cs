using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField]
    private Image Image_ProgressBar;

    [SerializeField]
    private UnityEvent onEndFillProgressBar;

    [SerializeField]
    private float timeWaitBeforeStart;

    [SerializeField]
    private float timeWait;

    public void Start()
    {
        StartCoroutine(FillProgressBar());
    }

    private IEnumerator FillProgressBar()
    {
        yield return new WaitForSeconds(timeWaitBeforeStart);
        while (Image_ProgressBar.fillAmount <= 0.9f)
        {
            Image_ProgressBar.fillAmount += 0.1f;
            yield return new WaitForSeconds(timeWait);
        }
        onEndFillProgressBar?.Invoke();
    }
}
