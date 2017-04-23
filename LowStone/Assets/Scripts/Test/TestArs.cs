using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestArs : MonoBehaviour {

    public bool trigger = true;
    public int counter = 0;
    
	void Start () {
        EventDispatcher.AddEventListener<DrawEventData>(EventEnum.DrawCard, Drawed);
	}
	
	private void Drawed (DrawEventData data) {
        if (trigger)
        {
            counter++;
            Debug.Log(counter);
            //trigger = false;
        }		
	}
}
