﻿// <copyright file="Utils.cs" company="Matrix Becker">
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
// </copyright

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WheelOfFortune
{
    /// <summary>
    /// Weather Base Class
    /// </summary>
    [Serializable]
    public class WeatherSerialized
    {

        public Request request;
        public Location location;
        public Current current;
    }
}
