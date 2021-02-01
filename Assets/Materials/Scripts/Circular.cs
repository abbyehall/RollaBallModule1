using UnityEngine;

public class Circular : MonoBehaviour
{
    public float speed = 3f;
    public float radius = 8f;
    public float direction = 1;
    private float count = 0;

    void FixedUpdate()
    {
        count += speed/100;
        float zNew = direction * radius * Mathf.Sin(count);
        float xNew = direction * radius * Mathf.Cos(count);

        transform.position = new Vector3(xNew, 0.75f, zNew);
    }
}
