using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DeckOfCardsAPI.Models
{
    public class CardsDAL
    {
        public Hand GetCards()
        {
            string url = "https://deckofcardsapi.com/api/deck/new/draw/?count=5";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string JSON = rd.ReadToEnd();
            rd.Close();

            Hand h = JsonConvert.DeserializeObject<Hand>(JSON);
            return h;
        }

        public Hand DrawCards(string deckId, int count)
        {
            string url = $"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count={count}";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string JSON = rd.ReadToEnd();
            rd.Close();

            Hand h = JsonConvert.DeserializeObject<Hand>(JSON);
            return h;
        }
    }
}
