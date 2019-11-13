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
        private byte[] rawData = null;

        // Use this for initialization
        void Start()
        {
            if ((Application.internetReachability != NetworkReachability.NotReachable))
            {

            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        /// <summary>
        /// Fetchs the master data.
        /// </summary>
        /// <returns>The master data.</returns>
        IEnumerator FetchMasterData()
        {
            //title.text = "Configuring for the first time...please be patient";
            float startTime = Time.realtimeSinceStartup;

            WWWForm wwwform = new WWWForm();
            rawData = null;
            WWW www = new WWW(("http://api.weatherstack.com/current?access_key=fb5b798ccedcb92923e9662b89363042&query=Kolkata"), rawData);
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                Debug.Log(www.text);
            }
            else
            {
                print("Failure...!!!:" + www.error);
            }
            float elapsedTime = Time.realtimeSinceStartup - startTime;
            Debug.Log("Total Download Time:" + elapsedTime.ToString());

        }
    }
}
