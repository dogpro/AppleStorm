using UnityEngine;

public class MissTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("1");
        if (other.TryGetComponent(out Ball ball))
        {
            Debug.Log("222");
            StatesController.onMissAction?.Invoke();
            InstantiateBallsController.onSetBall?.Invoke();
        }
    }
}