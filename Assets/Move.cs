using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move: MonoBehaviour
{
   // Vector3[] a = new Vector3[9];
   // float speed = 40;
    //float y, z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GameObject.Find("sun").transform.Rotate(Vector3.up * Time.deltaTime * 5);

        GameObject.Find("mercury").transform.RotateAround(Vector3.zero, new Vector3(0.1f, 1, 0), 60 * Time.deltaTime);
        GameObject.Find("mercury").transform.Rotate(Vector3.up * Time.deltaTime * 1 / 58);

        GameObject.Find("venus").transform.RotateAround(Vector3.zero, new Vector3(0, 1, -0.1f), 55 * Time.deltaTime);
        GameObject.Find("venus").transform.Rotate(Vector3.up * Time.deltaTime * 10 / 243);

        GameObject.Find("earth").transform.RotateAround(Vector3.zero, new Vector3(0, 1, 0), 50 * Time.deltaTime);
        GameObject.Find("earth").transform.Rotate(Vector3.up * Time.deltaTime * 10);
        //只设置公转 不设置自转
        GameObject.Find("earth_1").transform.RotateAround(Vector3.zero, new Vector3(0, 1, 0), 50 * Time.deltaTime);
        //令Moon相对与不自转的EarthClone公转
        GameObject.Find("moon").transform.RotateAround(GameObject.Find("earth_1").transform.position, new Vector3(0, 1, 0), 250 * Time.deltaTime);
        GameObject.Find("moon").transform.Rotate(Vector3.up * Time.deltaTime * 10 / 27);

        GameObject.Find("mars").transform.RotateAround(Vector3.zero, new Vector3(0.2f, 1, 0), 45 * Time.deltaTime);
        GameObject.Find("mars").transform.Rotate(Vector3.up * Time.deltaTime * 10);

        GameObject.Find("jupiter").transform.RotateAround(Vector3.zero, new Vector3(-0.1f, 2, 0), 35 * Time.deltaTime);
        GameObject.Find("jupiter").transform.Rotate(Vector3.up * Time.deltaTime * 10 / 0.3f);

        GameObject.Find("saturn").transform.RotateAround(Vector3.zero, new Vector3(0, 1, 0.2f), 20 * Time.deltaTime);
        GameObject.Find("saturn").transform.Rotate(Vector3.up * Time.deltaTime * 10 / 0.4f);

        GameObject.Find("uranus").transform.RotateAround(Vector3.zero, new Vector3(0, 2, 0.1f), 15 * Time.deltaTime);
        GameObject.Find("uranus").transform.Rotate(Vector3.up * Time.deltaTime * 10 / 0.6f);

        GameObject.Find("neptune").transform.RotateAround(Vector3.zero, new Vector3(-0.1f, 1, -0.1f), 10 * Time.deltaTime);
        GameObject.Find("neptune").transform.Rotate(Vector3.up * Time.deltaTime * 10 / 0.7f);

    }
}
