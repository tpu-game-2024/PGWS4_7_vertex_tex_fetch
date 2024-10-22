using UnityEngine;

public class SphereBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition =
            new Vector3(0.5f * Mathf.Sin(1.0f * Time.time), 0.0f, 1.0f);
    }
}
