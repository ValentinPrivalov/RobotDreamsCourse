using System.Collections;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private float changeSpeed = 1f;

    void Update()
    {
        Material material = GetComponent<Renderer>().material;

        float currentColor = Mathf.PingPong(Time.time * changeSpeed, 1f);
        material.color = Color.Lerp(Color.red, Color.blue, currentColor);
    }
}
