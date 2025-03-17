using UnityEngine;

public class EggController : MonoBehaviour
{
    public GameObject EggBroken;
    private void OnCollisionEnter2D(Collision2D col)
    {
       if (col.gameObject.name.Equals("platfrom"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(this);
        }

       if (col.gameObject.name.Equals("box"))
        {
            Destroy(this);
        }
    }
}
