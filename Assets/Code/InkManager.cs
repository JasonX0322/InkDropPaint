using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkManager : MonoBehaviour
{
    [SerializeField] Object obj;
    [SerializeField] Transform canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int x = Random.Range(-960, 960);
            int y = Random.Range(-540, 540);
            float size = Random.Range(1.0f, 2.0f);
            GameObject go = GameObject.Instantiate(obj) as GameObject;
            go.transform.SetParent(canvas);
            go.transform.localScale = Vector3.one * size;
            go.transform.localPosition = new Vector2(x, y);

        }
    }
}
