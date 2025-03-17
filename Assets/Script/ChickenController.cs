using UnityEngine;

public class FarmerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject egg;
    private int count = 0;
    void Update()
    {
        count++;
        if (count > 100)
        {
            Instantiate(egg, transform.position, Quaternion.identity);
            count = 0;
        }
        
    }
}
