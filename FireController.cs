using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    //1. x, y 번지게 함.
    //2. z축으로도 번지게 함.(계단으로만)
    //3. 연기 이펙트

    public GameObject fire_prefeb;

    private float t = 0.0f;
    private float spread_threshold = 3.0f;
    private int rand_x;
    private int rand_z;

    private void Update()
    {
        
        //fire_spread();
    }

    public void Fire_start()
    {
        rand_x = Random.Range(0, 31);
        rand_z = Random.Range(0, 31);
        Vector3 randPos = new Vector3(rand_x, 10.45f, rand_z);
        Instantiate(fire_prefeb, randPos, Quaternion.identity);
    }

    void fire_spread()
    {
        /*
        t += Time.deltaTime;
        
        if(t > spread_threshold)
        {
            
            t = 0;
        }*/
    }

}
