using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ajanlar : MonoBehaviour
{
    public GameObject GameController;
    NavMeshAgent agent;
    public string ajanturu;
    public GameObject hedef;
    int carpmasayisi;
    float darbegucu;
    


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(hedef.transform.position);
        switch(ajanturu){
            case "mavi":
                carpmasayisi=3;
                darbegucu = 19f;
                break;
            case "sari":
                carpmasayisi = 2;
                darbegucu = 14f;
                break;
            case "siyah":
                carpmasayisi = 4;
                darbegucu =24f;
                break;
        }
            

    }
    void Update()
    {


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AnaHedef"))
        {
            Destroy(gameObject);
            GameController.GetComponent<GameController>().CanDusur(darbegucu);
        }

        if (other.gameObject.CompareTag("engel"))
        {
            if (carpmasayisi != 0)
            {
                carpmasayisi--;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
   
        
    


}
