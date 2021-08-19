using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segment : MonoBehaviour
{
    public int SegId { set; get; }
    public bool transition;

    public int lenght;
    public int beginY1, beginY2, beginY3;
    public int endY1, endY2, endY3;

    private PieceSpawner[] pieces;

    private void Awake()
    {
        pieces = gameObject.GetComponentsInChildren<PieceSpawner>();

        for (int i = 0; i < pieces.Length; i++)  //$$
            foreach (MeshRenderer mr in pieces[i].GetComponentsInChildren<MeshRenderer>())
                mr.enabled = LevelManager.Instance.SHOW_COLLIDER;
    }

    public void Spawn()
    {
        gameObject.SetActive(true);

        for (int i = 0; i < pieces.Length; i++)
            pieces[i].Spawn();
    }

    public void DeSpawn()
    {
        gameObject.SetActive(false);

        for (int i = 0; i < pieces.Length; i++)
            pieces[i].DeSpawn();
    }

}
