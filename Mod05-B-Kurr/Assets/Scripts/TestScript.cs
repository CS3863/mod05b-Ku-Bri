using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    float TestNumber = 10f;
    // Start is called before the first frame update
    void Start()
    {
        print(TestNumber);
        
    }

    // Update is called once per frame
    void Update()
    {
        TestNumber = TestNumber + 0.1f;
        print(TestNumber);
    }
}
