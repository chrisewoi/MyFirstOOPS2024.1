using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Materials
{
    Wood,
    Bronze,
    Iron,
    Steel,
    Diamonds,
    Gems,
}

public class Sword : MeleeWeapon
{
    public Materials hilt;
    public Materials blade;
    public Materials pommel;
}
