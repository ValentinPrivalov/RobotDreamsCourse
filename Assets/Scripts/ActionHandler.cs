using Unity.Loading;
using UnityEngine;
using UnityEngine.UI;

public class ActionHandler : MonoBehaviour
{
    [SerializeField] Slider loadingBar;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter (fall)");
        DecreaseHP();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("OnTriggerEnter (Player)");
            DecreaseHP();
        }
    }

    private void DecreaseHP()
    {
        loadingBar.value -= 0.1f;

        if (loadingBar.value < 0)
        {
            loadingBar.value = 0;
        }
    }
}
