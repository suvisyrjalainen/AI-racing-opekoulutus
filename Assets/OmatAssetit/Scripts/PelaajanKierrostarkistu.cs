using UnityEngine;

public class PelaajanKierrostarkistu : MonoBehaviour
{
        public int checkpointCount = 2; // Määrittele tarkistettavien porttien määrä
    
    // Tarkistaa, onko portit käyty läpi tällä kierroksella
    private bool[] visited;
    private int visitedCount;

    void Awake()
    {
        ResetLap();
    }

    public void ResetLap()
    {
        visited = new bool[checkpointCount];
        visitedCount = 0;
    }

    public void MarkVisited(int index)
    {
        if (!visited[index])
        {
            visited[index] = true;
            visitedCount++;
        }
    }
        
    // Tarkistaa, onko kaikki portit käyty läpi tällä kierroksella
    public bool AllVisitedThisLap => visitedCount == checkpointCount;
}
