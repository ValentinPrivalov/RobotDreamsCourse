using System.Collections;
using UnityEngine;

public class RainbowCoroutine : MonoBehaviour
{
    [SerializeField] private float changeSpeed = 0.2f;

    void Start()
    {
        StartCoroutine(SetColor());
    }

    IEnumerator SetColor()
    {
        Material material = GetComponent<Renderer>().material;
        float hue = 0;

        while (true)
        {
            material.color = Color.HSVToRGB(hue, 1, 1);

            hue += Time.deltaTime * changeSpeed;
            if (hue > 1)
            {
                hue = 0;
            }

            yield return null;
        }
    }
}
