using UnityEngine;
using System.Collections;

public class ObstacleInstantiate : MonoBehaviour {

    // Use this for initialization
    public GameObject boxPrefab;

    private GameObject clonePrefab;

	void Start () {
        ObstacleInstantiateHelper(boxPrefab, "ObstacleBox");
        //boxPrefab.transform.eulerAngles = new Vector3(-90, 0, 0); 
        //clonePrefab.transform.eulerAngles = new Vector3(-90, 0, 0);
    }

    private void ObstacleInstantiateHelper(GameObject prefab, string tag)
    {
        GameObject[] allObj = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject cloneObst in allObj)
        {
            clonePrefab = Instantiate(prefab, cloneObst.transform.position, Quaternion.identity) as GameObject;
        }
    }
	
}
