using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoard : MonoBehaviour
{
    public GameObject itemLBTemplate;

    public void updateInfo(int idx, string name, int value)
    {
        GameObject obj = Instantiate(itemLBTemplate, gameObject.transform) as GameObject;
        obj.GetComponent<Text>().text = (idx + 1) + ". " + name + ": " + value;
        obj.SetActive(true);
    }

    public void RemoveAllChildrent(){
        foreach(Transform child in gameObject.transform){
            Destroy(child.gameObject);
        }
    }
}
