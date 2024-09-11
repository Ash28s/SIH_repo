using UnityEngine;

public class ActivateObjectOnCollision : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming your player has the "Player" tag
        {
            objectToActivate.SetActive(true);
        }
    }
}
