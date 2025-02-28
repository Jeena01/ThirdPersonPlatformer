using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed;
    public GameManager gm;

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, 0);
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Coin collision");
        gm.AddCoin();
        Debug.Log("Coin collected");
        Destroy(gameObject);

    }
}
