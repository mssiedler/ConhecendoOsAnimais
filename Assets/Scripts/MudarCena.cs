using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MudarCena : MonoBehaviour
{

    public string nomeDaCena;
    public string nomeDaCena2;
    public string nomeDaCena3;


    public void Cenas()
    {
        SceneManager.LoadScene(nomeDaCena);
    }

    public void Cenas2()
    {
        SceneManager.LoadScene(nomeDaCena2);
    }

    public void Cenas3()
    {
        SceneManager.LoadScene(nomeDaCena3);
    }

}
    
   /* void Update()
    {
        if(DragDrop.colouCerto == true)
        {
            CarregarNovaCena();
        }
    }

    private void CarregarNovaCena()
    {
        SceneManager.LoadScene(nomeDaCena);
    }
}
   */