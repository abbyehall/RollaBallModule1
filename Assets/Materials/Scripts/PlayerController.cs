using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour{

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        countText.text = "Count:" + count.ToString();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        var pickUpScript = other.gameObject.GetComponent<PickUp>();

        if (pickUpScript != null)
        {
            switch (pickUpScript.PickupType)
            {
                case PickUp.PickUpType.SpeedUp:
                    speed = speed + 5;
                    break;
                case PickUp.PickUpType.Regular:
                    count++;
                    break;
            }

            other.gameObject.SetActive(false);
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 15)
        {
            winText.text = "You Win!!";
        }
    }
}