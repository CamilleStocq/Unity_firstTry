using UnityEngine;

public class rotateObject : MonoBehaviour
{

    public float rotateSpeed = 130f; // f permet de preciser que c'es un float
    

    private void Update()
    {
       transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);  //Time.deltaTime = dt de pythons, pour rotate ca c'est l'ordre des axes (x,y,z)
    }
}
