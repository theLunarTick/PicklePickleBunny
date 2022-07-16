using UnityEngine;

public class destroyPickle : MonoBehaviour
{
    public float lifeCycle = 3f;

    void Update()
    {
        Destroy(gameObject, lifeCycle);
    }
}
