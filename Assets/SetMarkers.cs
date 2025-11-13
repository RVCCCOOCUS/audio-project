using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMarkers : MonoBehaviour
{
    public GameObject marker;

    // Start is called before the first frame update
    void Start()
    {

        Transform Markers = GameObject.Find("Markers").transform;
        for (int x = -100; x <= 100; x+=10)
        {
            for (int z = -100; z <= 100; z+=10)
            {
                GameObject tMarker = Instantiate(marker,Markers);
                tMarker.transform.position = new Vector3(x,0, z);
            }
        }
        
    }


}
