using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Test : MonoBehaviour
{
    [SerializeField] private RawImage rawImage;
    [SerializeField] private List<Vector2> horizontal;

    private void Update()
    {
        Texture2D texture2D = new Texture2D(1920, 1080);

        for (int i = 0; i < 1920; i++)
        {
            for (int k = 0; k < 1080; k++)
            {
                texture2D.SetPixel(i, k, Color.white);
            }
        }

        for (int i = 0; i < 1920; i++)
        {
            var pos = Cosine.Interpolation(horizontal, i / 1920f, i);
            int size = 3;
            for (int q = 0; q < size; q++)
            {
                for(int p = 0; p < size; p++)
                {
                texture2D.SetPixel((int)pos.x + p, (int)pos.y + q, Color.black);
                }
            }
            //Debug.Log(pos + $"{i / 1920f}");
        }
        texture2D.Apply();
        rawImage.texture = texture2D;

    }
}