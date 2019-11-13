// <copyright file="GameController.cs" company="Matrix Becker">
// Copyright (C) 2019 Matrix Becker. All Rights Reserved.
//
//@ Author: Mr. Saikat Patra
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Becker.MVC;
using LitJson;

namespace WheelOfFortune
{
    /// <summary>
    /// Root of All Game Controller
    /// </summary>
    public class GameController : Controller<ApplicationGameManager>
    {
        private byte[] rawData      = null;
        private string baseURL      = "http://api.weatherstack.com/";
        private string curObserve   = "current?";
        private string accessKey    = "access_key=fb5b798ccedcb92923e9662b89363042&";
        private string queryInfo    = "query=";

        string JSON_Name;
        string JSON_Country;
        string JSON_Region;
        string JSON_LocalTime;
        float JSON_Temperature;
        string JSON_Weather;
        string path;
        string Url;
        string temperature;

        // Use this for initialization
        void Start()
        {
            StartCoroutine("FetchWeatherData", "");
        }

        // Update is called once per frame
        void Update()
        {

        }

        /// <summary>
        /// On Click Function to fetch weather data
        /// </summary>
        public void WeatherGo()
        {
            if ((Application.internetReachability != NetworkReachability.NotReachable))
            {
                StartCoroutine("FetchWeatherData","delhi");
            }
        }

        /// <summary>
        /// Fetchs the master data.
        /// </summary>
        /// <returns>The master data.</returns>
        IEnumerator FetchWeatherData(string cityInfo)
        {
            //title.text = "Configuring for the first time...please be patient";
            float startTime = Time.realtimeSinceStartup;

            WWWForm wwwform = new WWWForm();
            rawData = null;
            WWW www = new WWW(("http://api.weatherstack.com/current?access_key=fb5b798ccedcb92923e9662b89363042&query=delhi"), rawData);
            //WWW www = new WWW((baseURL+curObserve+accessKey+queryInfo+cityInfo), rawData);
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                Debug.Log(www.text);
                ParseWeatherAPI(www.text);
            }
            else
            {
                print("Failure...!!!:" + www.error);
            }
            float elapsedTime = Time.realtimeSinceStartup - startTime;
            Debug.Log("Total Download Time:" + elapsedTime.ToString());

        }

        /// <summary>
        /// After getting weather Data it will be parse and Disply Properly
        /// </summary>
        public void ParseWeatherAPI(string weatherData)
        {
            //JsonData jsonWeather = JsonMapper.ToObject(weatherData);
            _Particle fields = JsonUtility.FromJson<_Particle>(weatherData);
            JSON_Name = fields.location.name;
            JSON_Country = fields.location.country;
            JSON_Region = fields.location.region;
            JSON_LocalTime = fields.location.localTime;
            //JSON_Weather = fields.current.condition.data;
            JSON_Temperature = fields.current.temp_c;
            Debug.Log(JSON_Name);
            Debug.Log(JSON_Country);
            Debug.Log(JSON_Region);
            Debug.Log(JSON_LocalTime);
            //Debug.Log(JSON_Weather);
            Debug.Log(JSON_Temperature);
        }

        [System.Serializable]
        public class _condition
        {
            public string data;

        }

        [System.Serializable]
        public class _location
        {
            public string name;
            public string country;
            public string region;
            public string localTime;

        }

        [System.Serializable]
        public class _current
        {
            //public _condition condition;
            public float temp_c;

        }


        [System.Serializable]
        public class _Particle
        {
            public _condition condition;
            public _location location;
            public _current current;
            public string temp;
            public string main;
        }
    }
}
