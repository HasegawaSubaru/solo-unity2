using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HS_TitleController : MonoBehaviour
{
    public Button[] buttons;
    private int selectedIndex = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SelectButton();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxisRaw("Vertical");

        if(vertical > 0.5f)
        {

        }
    }
}
