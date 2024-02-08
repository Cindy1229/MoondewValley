using Cinemachine;
using UnityEngine;

public class SwitchConfineBoundingShape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SwitchBoundingShape();
    }

    /// <summary>
    /// switch collider that cinemachine uses to define the edges of the screen
    /// </summary>

    private void SwitchBoundingShape() {
        // get polygon collider 2d
        PolygonCollider2D polygonCollider2D = GameObject.FindGameObjectWithTag(Tags.BoundsConfiner).GetComponent<PolygonCollider2D>();

        CinemachineConfiner cinemachineConfiner = GetComponent<CinemachineConfiner>();

        cinemachineConfiner.m_BoundingShape2D = polygonCollider2D;

        // clear cache since the cinemachine bounds have changes
        cinemachineConfiner.InvalidatePathCache();
    }
}
