using System.Collections.Generic;
using UnityEngine;

public class MolePool : MonoBehaviour
{
    [SerializeField] private GameObject molePrefab;
    
    private Stack<GameObject> availableObjects = new Stack<GameObject>();

    public GameObject GetFromPool()
    {
        GameObject obj;
        if(availableObjects.Count > 0)
        {
            obj = availableObjects.Pop();
        }
        else
        {
            obj = Instantiate(molePrefab);
            obj.GetComponent<Peek>().molePoolRef = this;
            Debug.Log("newMole");
        }

        obj.transform.SetParent(null);
        obj.SetActive(true);

        return obj;
    }

    public void ReturnToPool(GameObject obj)
    {
        obj.gameObject.SetActive(false);
        
        obj.transform.SetParent(transform);
        
        obj.transform.localPosition = Vector3.zero;
        
        availableObjects.Push(obj);
    }
}
