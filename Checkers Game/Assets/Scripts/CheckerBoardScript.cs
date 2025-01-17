using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerBoardScript : MonoBehaviour
{
    public C_Piece[,] c_Pieces = new C_Piece[8, 8];
    public GameObject whitePiecePrefab;
    public GameObject blackPiecePrefab;

    public Vector3 boardOffset = new Vector3(-4.0f, 0, -4.0f);

    private void Start()
    {
        GenerateBoard();
    }

    private void GenerateBoard()
    {
        // Generate white team
        for (int y = 0; y < 3; y++)
        {
            for(int x = 0; x < 8; x += 2)
            {
                //Generate our Piece
                GeneratePiece(x, y);
            }
        }
    }

    private void GeneratePiece(int x, int y)
    {
        GameObject gobj = Instantiate(whitePiecePrefab) as GameObject;
        gobj.transform.SetParent(transform);
        C_Piece p = gobj.GetComponent<C_Piece>();
        c_Pieces[x, y] = p;
    }

    private void SetPiece(C_Piece p, int x, int y)
    {
        p.transform.position = (Vector3.right * x) + (Vector3.forward * y) + boardOffset;
    }
}
