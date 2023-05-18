using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Merchant : MonoBehaviour
{
    public string Text;

    public int fontSize;

    public Transform Canvas;

    public Font font;

    static Text CreatingText(Transform parent)
    {
        // MIT meint nicht du Universität sonder Merchant Interaction Text Bitte nichts Ändern ohne mich zu informieren Beste Grüße Quark \\

        var go = new GameObject();
        go.transform.parent = parent;
        var text = go.AddComponent<Text>();
        text.name = "MIT";
        text.tag = "MIT";
        return text;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int widht = Screen.width / 2;

        Vector3 textPos = new(widht, 100, 0);

        var mytext = CreatingText(Canvas.transform);
        mytext.transform.Translate(textPos);
        mytext.horizontalOverflow = HorizontalWrapMode.Overflow;
        mytext.fontSize = fontSize;
        mytext.font = font;
        mytext.text = Text;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            print("HAns");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        GameObject mit = GameObject.FindWithTag("MIT");

        Destroy(mit);
    }
}
