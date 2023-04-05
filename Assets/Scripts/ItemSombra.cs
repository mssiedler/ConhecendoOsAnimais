using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemSombra : MonoBehaviour, IDropHandler
{
    public string nomeDaCena;
    public Button botaoCena;
    public Button botaoNome;
    public Button botaoSom;
    

void start()
{

}
 

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            if(eventData.pointerDrag.gameObject.tag == gameObject.tag)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = 
                GetComponent<RectTransform>().anchoredPosition;

                DragDrop.colouCerto = true;
                
                botaoCena.gameObject.SetActive(true);
                botaoNome.gameObject.SetActive(true);
                botaoSom.gameObject.SetActive(true);
                GetComponent<AudioSource>().enabled = true;
                
                                                     
            }
        }
    }

    private void CarregarNovaCena()
    {
        SceneManager.LoadScene(nomeDaCena);
    }
}
