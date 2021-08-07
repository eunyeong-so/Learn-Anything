using UnityEngine;

public class InputManager : MonoBehaviour, IClick
{
    public event ClcikEventHandler ClickEvent;
      
    void Update()
    {
        ClickedMonster();
    }

    void ClickedMonster()
    { 
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D[] hits = Physics2D.GetRayIntersectionAll(ray, Mathf.Infinity);
            foreach (var hit in hits)
            {
                if (hit.collider)
                {
                    GameObject selected = hit.collider.gameObject;
                   
                    if (ClickEvent != null)
                    {
                        Debug.Log("ClickEvent");
                        ClickEvent?.Invoke(selected);
                    }
                    else
                        Debug.Log("ClickEvent is null");
                }
            }
        }
    }
}
