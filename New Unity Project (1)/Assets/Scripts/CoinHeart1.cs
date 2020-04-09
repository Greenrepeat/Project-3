using UnityEngine;
using UnityEngine.Events;

public class CoinHeart1 : MonoBehaviour
{
    public UnityEvent OnPickUp;

    public string PickUp;

    private void OnTriggerEnter(Collider Other)
    {
        OnPickUp.Invoke();
      
    

    }
}