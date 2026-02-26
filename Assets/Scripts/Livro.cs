using UnityEngine;


public class Livro : MonoBehaviour
{
    public GameObject BolaDeFogo;

    public int Mana = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Mana > 0){
            Instantiate(BolaDeFogo, transform.position, Quaternion.identity);

            Mana--;
        }

        else if (Mana < 0){
            Debug.Log("Sem Mana! Beba uma poção (R)");
        }

        else if(Input.GetKeyDown(KeyCode.R)){
            Mana = 10;
        
            Debug.Log("Mana Restaurada");
        }
    }
}
