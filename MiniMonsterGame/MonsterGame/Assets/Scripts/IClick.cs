using UnityEngine;

public delegate void ClcikEventHandler(GameObject selected);
public interface IClick
{  
    event ClcikEventHandler ClickEvent;
}
 