using UnityEngine;

public class scaleScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float scalingFactor = 1.0f;
    private float reverseTime = 2.0f;
    private float scaleSign = 1.0f;
    private float timer = 0.0f;
    private Vector3 originalScale;
    void Start()
    {
        // initial scale of the object
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        // inrementing timer by the time since last frame
        timer += Time.deltaTime;

        // checking if its time to reverse direction of scale
        if (timer >= reverseTime)
        {
            // reset timer
            timer = 0.0f;

            // reverse scaling direction by changing to negative
            scaleSign *= -1;

            Debug.Log("Scaling changed");
        }
        // calculating scaling for this frame
        float scaleAmout = scalingFactor * scaleSign * Time.deltaTime;

        // scaling gameobject local scale
        transform.localScale += new Vector3(scaleAmout, scaleAmout, scaleAmout);
    }
}
