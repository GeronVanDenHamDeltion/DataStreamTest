using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyData : MonoBehaviour {
    public int myID;
    public int myIncommingData;
    public DataStreams ds;

    public void IncommingData(){
            print("2");
            myIncommingData++;
            gameObject.transform.localScale = new Vector3(myIncommingData,myIncommingData,1);
    }
}
