using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THEfinalcountdown : MonoBehaviour
{
    public float deathTime = 150f;   //How long before the bullet dies  
    // Start is called before the first frame update
    void Start()
    {
    }
    //Waits till timer is out then destroys the bullet 
    private IEnumerator Death()
    {
        yield return new WaitForSeconds(deathTime);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
