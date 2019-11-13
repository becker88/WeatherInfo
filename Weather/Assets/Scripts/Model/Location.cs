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
using System;
using UnityEngine;
using Becker.MVC;

namespace WheelOfFortune
{
    [Serializable]
    public class Location : Model<ApplicationGameManager>
    {
        private string location;
        private string country;
        private string localTime;
        private Location m_locationInfo;


        /// <summary>
        /// Reference to the Location Info Model.
        /// </summary>
        public Location locationInfo { get { return m_locationInfo = Assert<Location>(m_locationInfo); } }

        /// <summary>
        /// Get and Set Location
        /// </summary>
        public string LocationArea { get { return location; } set { location = value; } }

        /// <summary>
        /// Get and Set Country
        /// </summary>
        public string Country { get { return country; } set { country = value; } }

        /// <summary>
        /// Get and Set Local Time
        /// </summary>
        public string LocalTime { get { return localTime; } set { localTime = value; } }

    }
}

