using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStreams : MonoBehaviour
{
    public Stream streamAdd;
    public List<DataHolder> streams = new List<DataHolder>();
    public int currentamountofstreams;

    public void OnTempClick()
    {
        for(int i = 0; i < streams.Count; i++)
        {
            if (streamAdd.StartPoint == streams[i].stream.StartPoint && streamAdd.EndPoint == streams[i].stream.EndPoint)
            {
                currentamountofstreams++;
                streams[i].stream.DataIDs.Add(currentamountofstreams);
                streams[i].amount++;
                streamAdd = new Stream();
                return;
            }
        }
        DataHolder dat = new DataHolder();
        dat.stream = streamAdd;
        currentamountofstreams++;
        dat.stream.DataIDs.Add(currentamountofstreams);
        dat.amount++;
        streams.Add(dat);
        streamAdd = new Stream();
    }
}
