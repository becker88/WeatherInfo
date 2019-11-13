
// <copyright file="GameView.cs" company="Matrix Becker">
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

namespace WheelOfFortune
{
    [SerializeField]
    public class CurrentObservation : Model<ApplicationGameManager>
    {

        private int _temperature;
        private int _precipitation;
        private int _humidity;
        private int _windSpeed;
        private int _windDirection;
        private int _windDegree;
        private int _pressure;

        /// <summary>
        /// Get and Set Temperature
        /// </summary>
        public int Temperature { get { return _temperature; } set { _temperature = value; } }

        /// <summary>
        /// Get and Set Precipitation
        /// </summary>
        public int Precipitation { get { return _precipitation; } set { _precipitation = value; } }

        /// <summary>
        /// Get and Set Humidity
        /// </summary>
        public int Humidity { get { return _humidity; } set { _humidity = value; } }

        /// <summary>
        /// Get and Set WindSpeed
        /// </summary>
        public int WindSpeed { get { return _windSpeed; } set { _windSpeed = value; } }

        /// <summary>
        /// Get and Set Pressure
        /// </summary>
        public int Pressure { get { return _pressure; } set { _pressure = value; } }

    }
}
