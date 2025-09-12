using UnityEngine;

[System.Serializable]
public class Stats
{
    public float Speed;
    public float Hp;
    public float Atk;
    public float Def;
    public float Range;
    public void CopyFrom(Stats other)
    {
        Hp = other.Hp;
        Atk = other.Atk;
        Speed = other.Speed;
        Def = other.Def;
        Range = other.Range;
    }
}


