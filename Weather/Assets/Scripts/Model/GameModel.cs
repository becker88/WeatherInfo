// <copyright file="GameModel.cs" company="Matrix Becker">
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
    /// <summary>
    /// Root of All Game Model
    /// </summary>
    public class GameModel : Model<ApplicationGameManager>
    {
        private Location m_locationInfo;
        private CurrentObservation m_curObserve;

        /// <summary>
        /// Reference to the Location Info Model.
        /// </summary>
        public Location locationInfo { get { return m_locationInfo = Assert<Location>(m_locationInfo); } }

        /// <summary>
        /// Reference to the Current Weather Observation Info Model.
        /// </summary>
        public CurrentObservation curObserve { get { return m_curObserve = Assert<CurrentObservation>(m_curObserve); } }
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
