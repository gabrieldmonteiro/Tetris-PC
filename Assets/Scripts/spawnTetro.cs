using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class spawnTetro : MonoBehaviour {

    public int proxPeca;
    public List<GameObject> mostraPecas;

	public Transform[] criaPecas ;


	void Start () {

        proxPeca = Random.Range(0, 7);
        proximaPeca();
        


	}

    public void proximaPeca()
    {
        Instantiate(criaPecas[proxPeca], transform.position, Quaternion.identity);

        proxPeca = Random.Range(0, 7);

        for (int i = 0; i < mostraPecas.Count; i++)
        {
            mostraPecas[i].SetActive(false);
        }

        mostraPecas[proxPeca].SetActive(true);

    }
}
