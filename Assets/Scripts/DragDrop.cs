using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IPointerDownHandler, IEndDragHandler, IDragHandler
{
   
   private RectTransform rt;
   private CanvasGroup grupo;
   private Vector2 posicaoOriginal;

   public static bool colouCerto;
   private AudioSource somAudio;

   [SerializeField] private Canvas canvas; //parecido com 'set'


    private void Awake() 
   {
        rt = GetComponent<RectTransform>();
        grupo = GetComponent<CanvasGroup>();
        posicaoOriginal = rt.anchoredPosition;
        colouCerto = false;
        somAudio= GetComponent<AudioSource>();
   }
   
   public void OnBeginDrag(PointerEventData eventData)
   {
    Debug.Log("Funfou o primeiro click");
    grupo.alpha = 0.3f;
    grupo.blocksRaycasts = false;
        //GetComponent<AudioSource>().Play();

        //OnMouseClick();
    
   }

    public void OnDrag(PointerEventData eventData)
   {
 
        rt.anchoredPosition += eventData.delta/canvas.scaleFactor;
    Debug.Log("Dragou");
        OnMouseDrag();

   }

   public void OnPointerDown(PointerEventData eventData)
   {
    Debug.Log("Clicou");
        somAudio.Play();
    }
   
   public void OnEndDrag(PointerEventData eventData)
   {
    Debug.Log("Final");
    grupo.alpha = 1f;
    grupo.blocksRaycasts = true;

        if (colouCerto == false)
    {
        rt.anchoredPosition = posicaoOriginal;
    }
    colouCerto = false;

        OnMouseDown();  


   }

    //-----------//
    private void OnMouseClick()
    {
        CursorController.instance.ActiveCursorClick();
    }

    private void OnMouseDrag()
    {
        CursorController.instance.ActiveCursorDrag();
    }

    private void OnMouseDown()
    {
        CursorController.instance.ActiveCursor();
    }

    private void OnMouseEnter()
    {
        CursorController.instance.ActiveCursor();
    }

}
