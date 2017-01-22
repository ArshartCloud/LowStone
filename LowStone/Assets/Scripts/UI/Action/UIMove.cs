using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMove : MonoBehaviour {
    public Transform targetTrans;
    public float gap = 0.2f;
    private float startTime;
    private float speedPos;
    private float speedRot;
    private float speedScale;

    void Start()
    {
        startTime = Time.time;
        speedPos = Vector3.Distance(transform.position, targetTrans.position)*Time.deltaTime / gap;
        speedRot = Vector3.Distance(transform.eulerAngles, targetTrans.eulerAngles) * Time.deltaTime / gap;
        speedScale = Vector3.Distance(transform.localScale, targetTrans.localScale) * Time.deltaTime / gap;
    }

    void Update()
    {
        float delta = Time.time - startTime;
        if (delta > gap)
        {
            transform.position = targetTrans.position;
            transform.rotation = targetTrans.rotation;
            transform.localScale = targetTrans.localScale;
            Destroy(this);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, targetTrans.position, speedPos);
            transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, targetTrans.eulerAngles, speedRot);
            transform.localScale = Vector3.MoveTowards(transform.localScale, targetTrans.localScale, speedScale);
            //transform.eulerAngles = oriTrans.eulerAngles + (targetTrans.eulerAngles - oriTrans.eulerAngles) * delta / gap;
        }
    }
}
