using System.Collections;
using System.Collections.Generic;
using System;

public class EventData
{
    public static List<EventType> eventList = new List<EventType>();
}

[Serializable]
public class EventType
{
    public int date_Y;
    public int date_M;
    public string title;
    public string eventContents;
    public string[] eventSelection;
    public string[] eventAdditionalBox;
    public int[] effect;
    public string[] effectType;
}
