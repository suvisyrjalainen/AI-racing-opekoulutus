using UnityEngine;

public class CheckpointTarkistus : MonoBehaviour
{
    
    public int orderIndex = 0; // anna jokaiselle portille 0..N-1

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"Portti {orderIndex} osui: {other.name}");
        // Pelaajan collider voi olla childissa → hae vanhemmista
        PelaajanKierrostarkistu validator = other.GetComponent<PelaajanKierrostarkistu>();
        if (validator != null)
        {
            validator.MarkVisited(orderIndex);
        }
    }
}
