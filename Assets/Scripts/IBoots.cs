﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBoots {

    List<DefaultStats> Stats { get; set; }
    CombatantStats CombatantStats { get; set; }
}
