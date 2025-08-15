using UnityEngine;
public enum CarKind { Player, AI }
public class CarIdentify : MonoBehaviour
{
        public string displayName = "Player";   // näkyvä nimi esim. UI:ssa
        public CarKind kind = CarKind.Player;   // onko pelaaja vai AI

}
