using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStreams : MonoBehaviour
{
    public DataHolder dataholder;
    public List<DataHolder> streams = new List<DataHolder>();


    public void OnTempClick()
    {
        streams.Add(dataholder);
        dataholder = new DataHolder();
    }
}
