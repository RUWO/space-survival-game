using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items {

    public Item iron;
    
	public Items()
    {
        iron = new Item(null, "Iron");
    }

    public enum ITEMS
    {
        IRON
    }

}
