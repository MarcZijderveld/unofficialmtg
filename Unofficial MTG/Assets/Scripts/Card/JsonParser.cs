using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

public class JsonParser : MonoBehaviour
{
    private string cardUrl = "http://mtgjson.com/json/AllSets.json";
    private string setUrl = "http://mtgjson.com/json/SetCodes.json";
    private string setPath = "/Json/Sets.json";
    private string cardPath = "/Json/AllSets.json";

    public List<Set> sets = new List<Set>();
    private List<Card> cards = new List<Card>();

    private List<string> setCodes = new List<string>();

    public void Start()
    {
        DownloadCards();
    }

    public void DownloadCards()
    {
        if (!File.Exists(Application.dataPath + setPath) || !File.Exists(Application.dataPath + cardPath))
        {
            Debug.Log("Doesnt exist!");
            using (WebClient webClient = new WebClient())
            {
                WebClient wc = new WebClient();

                string setJson = wc.DownloadString(setUrl);
                string cardJson = wc.DownloadString(cardUrl);

                File.WriteAllText(Application.dataPath + cardPath, cardJson);
                File.WriteAllText(Application.dataPath + setPath, setJson);

                //ParseJson(setJson, cardJson);
            }
        }
        else
        {
            Debug.Log("Exists!");
            ParseJson(File.ReadAllText(Application.dataPath + setPath), File.ReadAllText(Application.dataPath + cardPath));
        }
    }

    public void ParseJson(string setJson, string cardJson)
    {
        setCodes = JsonConvert.DeserializeObject<List<string>>(setJson);

        JObject obj = JObject.Parse(cardJson);

        List<JToken> results = new List<JToken>();

        foreach (string str in setCodes)
        {
            results.Add(obj[str]);
        }

        foreach (JToken jt in results)
        {
            sets.Add(JsonConvert.DeserializeObject<Set>(jt.ToString()));
        }

        foreach (Set set in sets)
        {
            foreach (Card c in set.cards)
            {
                cards.Add(c);
            }
        }

        Debug.Log(cards[981].name);

        sets.Clear();
    }
}
