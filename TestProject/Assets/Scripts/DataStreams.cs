using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DataStreams : MonoBehaviour
{
    public Stream streamAdd;
    public List<DataHolder> streams = new List<DataHolder>();
    public int currentamountofstreams;
    

    public void terminate(string s)
    {
        int x = Int32.Parse(s);
        print(x);
        for (int i = 0; i < streams.Count; i++)
        {
            for (int o = 0; o < streams[i].stream.DataIDs.Count; o++)
            {
                if (streams[i].stream.DataIDs[0] == x)
                {
                    streams[i].stream.DataIDs.Remove(x);
                    streams[i].amount--;
                    if (streams[i].amount == 0)
                    {
                        streams.Remove(streams[i]);
                    }
                    return;
                }
            }
        }
    }
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
