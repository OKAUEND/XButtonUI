using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat : MonoBehaviour {

    //GameObject Character_image;
    Image Character_image;
    Texture2D texture;

    // Use this for initialization
    void Start () {
        Character_image = GameObject.Find("Character").GetComponent<Image>();
        texture = Resources.Load("DousiteCat") as Texture2D;
        //Character_image.transform.parent = GameObject.Find("Canvas").transform;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetCharacterImage()
    {
        Character_image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
    }
}
