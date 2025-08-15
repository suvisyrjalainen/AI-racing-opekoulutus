using UnityEngine;
using System.Collections;
using TMPro;

public class Countdown : MonoBehaviour
{
    public TMP_Text uiText;              // Vedä tähän TMP-teksti canvasiin
    public int countdownFrom = 3;
    public float stepSeconds = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private IEnumerator Start()
    {

        // Laskenta
        for (int i = countdownFrom; i > 0; i--)
        {
            if (uiText) uiText.text = i.ToString();

            yield return new WaitForSecondsRealtime(stepSeconds);
        }

        // Kun numerot loppuvat kirjoitetaan GO!
        if (uiText) uiText.text = "GO!";



        yield return new WaitForSecondsRealtime(0.5f);
        if (uiText) uiText.gameObject.SetActive(false); // siivoa UI
        
        GameManager.Instance.Phase = RacePhase.Racing; // Vaihda pelivaihe Racingiksi
    }

    // Update is called once per frame
    void Update()
    {

    }
}
