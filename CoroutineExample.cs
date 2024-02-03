using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private bool isFading = false;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isFading)
        {
            Color c = meshRenderer.material.color;
            Debug.Log("isFading: " + isFading + " Color: " + c);
            isFading = true;
            StartCoroutine(FadeOut());
        }
    }

    IEnumerator FadeOut()
    {
        Color startColor = meshRenderer.material.color;
        float elapsedTime = 0f;
        float fadeDuration = 2f; // Set your desired fade duration here

        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(startColor.a, 0f, elapsedTime / fadeDuration);
            Color newColor = new Color(startColor.r, startColor.g, startColor.b, alpha);
            meshRenderer.material.color = newColor;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the final color is fully transparent
        Color finalColor = new Color(startColor.r, startColor.g, startColor.b, 0f);
        meshRenderer.material.color = finalColor;

        isFading = false;
    }
}


