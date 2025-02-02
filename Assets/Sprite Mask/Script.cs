using UnityEngine;

public class Script : MonoBehaviour
{
    public float velocidad = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoX = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        float movimientoY = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;

        transform.Translate(movimientoX, movimientoY, 0);
    }
}
