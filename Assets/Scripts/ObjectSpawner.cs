using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objetosParaEspalhar;
    public int quantidadeDeObjetos = 4;
    public GameObject[] spawnpoints;


    void Start()
    {
        EspalharObjetos();
    }

    void EspalharObjetos()
    {
        for (int i = 0; i < quantidadeDeObjetos; i++)
        {
            int indiceSpawnpoint = Random.Range(0, spawnpoints.Length);

            GameObject objetoInstanciado = Instantiate(objetosParaEspalhar, spawnpoints[indiceSpawnpoint].transform.position, Quaternion.identity);

        }
    }
}