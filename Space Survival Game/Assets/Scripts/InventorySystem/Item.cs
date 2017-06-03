using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {

    public Texture texture = null;

    public string itemname;

    public GameObject itemmodel;

	public Item(Texture _texture, string _itemname) {
        this.texture = _texture;
        this.itemname = _itemname;
	}

    public void setTexture(Texture _texture)
    {
        this.texture = _texture;
    }
	
    public string getItemName()
    {
        return itemname;
    }
    
}
