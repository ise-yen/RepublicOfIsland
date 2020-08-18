using System.Collections;
using System.Collections.Generic;
using System;

public class EventData
{
    public List<EventType> eventList = new List<EventType>();

    public EventData()
    {
        eventList.Add(new EventType {
            date_Y = 1400, date_M = 1,
            title = "Welcome to ROI",
            eventContents = "로이 세계에 오신 것을 진심으로 환영합니다. 여러분을 위해 준비한 작은 선물입니다.",
            eventSelection = new string[3] { "왕은 똑똑해야지", "왕도 돈이 있어야 돼", "왕은 힘이 제일이지" },
            eventAdditionalBox = new string[3] { "행정력 + 1", "경제력 + 1", "군사력 + 1" },
            effect = 1 });

        eventList.Add(new EventType
        {
            date_Y = 1400,
            date_M = 2,
            title = "밤이 지났습니다 마피아는 일어나 주세요",
            eventContents = "첫 달이 지났습니다 마피아가 시민 한 명을 죽였습니다.",
            eventSelection = new string[2] { "의사가 시민을 살렸습니다. 치료비를 주시죠", "시민이 죽었습니다. 애도를 표합니다"},
            eventAdditionalBox = new string[2] { "브리킷 - 3", "브리킷 - 3"},
            effect = 3
        });

        eventList.Add(new EventType
        {
            date_Y = 1401,
            date_M = 1,
            title = "새해 복 많이 받으세요!",
            eventContents = "새해 복 많이 받으세요!",
            eventSelection = new string[3] { "올해는 돈을 많이 벌게 해주세요!", "올해는 열심히 공부해야지!", "올해는 금주 금연이다!" },
            eventAdditionalBox = new string[3] { "브리킷 + 30", "행정력 + 1", "범죄율 - 1, 불만도 + 1"},
            effect = 3
        });
    }
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
    public int effect;
}
