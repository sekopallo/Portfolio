﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Zenject;

public class GameManager : IInitializable
{
    public void Initialize()
    {
        Debug.Log("GameManager initialized.");
    }
}