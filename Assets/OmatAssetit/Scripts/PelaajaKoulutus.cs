using UnityEngine;

public class PelaajaKoulutus : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 50f;

    public AudioClip PrumPrumSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        if (GameManager.Instance.Phase != RacePhase.Racing)
        {
            return; // Pelaaja ei voi liikkua, jos peli ei ole käynnissä
        }
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * move);
        transform.Rotate(Vector3.up * turn);
        
        if (move != 0 || turn != 0)
        {
            AudioManager.Instance.PlaySFX(PrumPrumSound);
        }
    }
}
