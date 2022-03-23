//https://codefinder.janndk.com/22
using UnityEngine;
using UnityEngine.UI;

public class MouseMove : MonoBehaviour
{
    public RectTransform transform_cursor;
    //public RectTransform transform_icon;
    public Text text_mouse;

    // Start is called before the first frame update
    void Start()
    {
        Init_Cursor();    
    }

    // Update is called once per frame
    void Update()
    {
        Update_MousePosition();
    }

    private void Init_Cursor()
    {
        Cursor.visible = true;
        transform_cursor.pivot = Vector2.up;

        if (transform_cursor.GetComponent<Graphic>())
            transform_cursor.GetComponent<Graphic>().raycastTarget = false;
        //if (transform_icon.GetComponent<Graphic>())
            //transform_icon.GetComponent<Graphic>().raycastTarget = false;
    }

    private void Update_MousePosition()
    {
        Vector2 mousePos = Input.mousePosition;
        transform_cursor.position = mousePos;
        //float w = transform_icon.rect.width;
        //float h = transform_icon.rect.height;
       // transform_icon.position = transform_cursor.position + (new Vector3(w, h) * 0.5f);

        string message = mousePos.ToString();
        text_mouse.text = message;
        Debug.Log(message);
    }
}
