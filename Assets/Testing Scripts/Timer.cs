using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class Timer : MonoBehaviour
{
    [SerializeField] Image uiFill;
    [SerializeField] Text uiText;

    public int Duration;
    private int remainingDuration;

    bool Pause;

    // Start is called before the first frame update
    void Start()
    {
        Begin(Duration); // Start the timer with the given duration.
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Begin(int Second)
    {
        remainingDuration = Second;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (remainingDuration >= 0)
        {
            if (!Pause)
            {
                uiText.text = $"{remainingDuration / 60:00} : {remainingDuration % 60:00}";
                uiFill.fillAmount = Mathf.InverseLerp(0, Duration, remainingDuration);
                remainingDuration--;
                yield return new WaitForSeconds(1f);
            }

            yield return null;
        }

        OnEnd();
    }

    private void OnEnd()
    {
        print("End");
    }
}
