using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

public class DatabaseParser : MonoBehaviour
{
    private string url = "http://mtgjson.com/json/AllSets.json";

    public void Start()
    {
        DownloadCards();
    }

    public void DownloadCards()
    {
        using (WebClient webClient = new WebClient())
        {
            WebClient wc = new WebClient();

            var json = wc.DownloadString(url);

            JObject j = JObject.Parse(json);
            Debug.Log(j.ToString());
        }
    }
}
