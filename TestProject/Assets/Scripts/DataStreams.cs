﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStreams : MonoBehaviour
{
    public Stream stream;
    public List<DataHolder> streams = new List<DataHolder>();
    public int currentamountofstreams;


    public void OnTempClick()
    {
        for(int i = 0; i < streams.Count; i++)
        {
            if (stream.StartPoint == streams[i].stream.StartPoint && stream.EndPoint == streams[i].stream.EndPoint)
            {
                currentamountofstreams++;
                streams[i].stream.DataIDs.Add(currentamountofstreams);
                streams[i].amount++;
                return;
            }
        }
        DataHolder dat = new DataHolder();
        dat.stream = stream;
        currentamountofstreams++;
        dat.stream.DataIDs.Add(currentamountofstreams);
        dat.amount++;
        streams.Add(dat);
    }
}
