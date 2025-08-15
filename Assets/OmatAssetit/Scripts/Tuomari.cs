using UnityEngine;
using TMPro;


public class Tuomari : MonoBehaviour
{

    public TMP_Text resultText; 
    private bool winnerDeclared = false;

    private void Start()
    {
        
        resultText.text = ""; // Tyhjennä tulosteksti alussa
        
    }
    private void OnTriggerEnter(Collider auto)
    {
        CarIdentify id = auto.GetComponent<CarIdentify>();
        // Ilmoita voittaja
        string winnerName = id.displayName;

        if (id.kind == CarKind.Player)
        {
            var validator = auto.GetComponentInParent<PelaajanKierrostarkistu>();
            if (validator == null || !validator.AllVisitedThisLap)
            {
                Debug.Log("Pelaaja ylitti maalin, mutta kaikki checkpointit eivät ole kunnossa → ei voittoa.");
                return;
            }
        }

        if (!winnerDeclared)
        {
            
                resultText.text = $"WINNER: {winnerName}";
                resultText.gameObject.SetActive(true);
            
        }

        winnerDeclared = true; // Vain kerran voittaja ilmoitetaan
        GameManager.Instance.Phase = RacePhase.Finished; // Vaihda pelivaihe Finishediksi

        Debug.Log($"WINNER: {winnerName}");
    }
}
