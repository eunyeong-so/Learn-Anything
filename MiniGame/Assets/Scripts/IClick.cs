using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
  
public delegate void ClcikEventHandler(bool isTrue);
public interface IClick
{  
    event ClcikEventHandler ClickEvent;
}
 