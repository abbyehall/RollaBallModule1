using UnityEngine;

public class Circular : MonoBehaviour
{
    public float speed = 3f;
    public float radius = 8f;
    public float direction = 1;
    public float count = 0;

    void Update()
    {
        count -= .1f;
        float zNew = direction * radius * Mathf.Sin(count);
        float xNew = direction * radius * Mathf.Cos(count);

        transform.position = new Vector3(xNew, 0.75f, zNew);
    }
}
