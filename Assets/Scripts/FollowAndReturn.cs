using UnityEngine;

public class FollowAndReturn : MonoBehaviour
{
    public Transform player;        // De speler of het doelwit om te volgen
    public float followSpeed = 2f;  // Snelheid van volgen
    public float returnSpeed = 3f;  // Snelheid van terugkeren
    public float reachDistance = 0.5f;  // Hoe dicht het object bij de speler moet zijn voordat het terugkeert

    private Vector3 startPosition;  // Startpositie van het object
    private bool returning = false; // Boolean om te bepalen of we aan het terugkeren zijn

    void Start()
    {
        // Sla de startpositie op
        startPosition = transform.position;
    }

    void Update()
    {
        // Roep ReturnToStart of FollowTarget aan, afhankelijk van de boolean
        if (returning)
        {
            ReturnToStart();
        }
        else
        {
            FollowTarget();
        }
    }

    private void FollowTarget()
    {
        // Beweeg richting de speler met Lerp
        transform.position = Vector3.Lerp(transform.position, player.position, followSpeed * Time.deltaTime);

        // Bereken afstand tot speler
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Als dichtbij genoeg, keer terug naar beginpositie
        if (distanceToPlayer < reachDistance)
        {
            returning = true;
        }
    }

    private void ReturnToStart()
    {
        // Bereken de richting naar startpositie en normaliseer die
        Vector3 directionStep = (startPosition - transform.position).normalized;

        // Beweeg het object met Translate
        transform.Translate(directionStep * returnSpeed * Time.deltaTime);

        // Bereken afstand tot startpositie
        float distToStart = Vector3.Distance(transform.position, startPosition);

        // Stop als we dichtbij genoeg zijn
        if (distToStart < 0.1f)
        {
            returning = false;
        }
    }
}
