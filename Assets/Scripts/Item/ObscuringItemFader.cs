using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ObscuringItemFader : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;

    private void Awake() {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void FadeOut() {
        StartCoroutine(FadeOutRoutine());
    }

    public void FadeIn() {
        StartCoroutine(FadeInRoutine());
    }

    private IEnumerator FadeInRoutine() {
        float currentAlpha = spriteRenderer.color.a;

        float distance = 1 - currentAlpha;

        while (1 - currentAlpha > .01f) {
            currentAlpha = currentAlpha + distance / Settings.fadeInSeconds * Time.deltaTime;
            spriteRenderer.color = new Color(1, 1, 1, currentAlpha);
            yield return null;
        }

        spriteRenderer.color = new Color(1, 1, 1, 1);
    }

    private IEnumerator FadeOutRoutine() {
        float currentAlpha = spriteRenderer.color.a;

        float distance = currentAlpha - Settings.targetAlpha;

        while (currentAlpha - Settings.targetAlpha > .01f) {
            currentAlpha = currentAlpha - distance / Settings.fadeOutSeconds * Time.deltaTime;
            spriteRenderer.color = new Color(1, 1, 1, currentAlpha);
            yield return null;
        }

        spriteRenderer.color = new Color(1, 1, 1, Settings.targetAlpha);
    }
}
