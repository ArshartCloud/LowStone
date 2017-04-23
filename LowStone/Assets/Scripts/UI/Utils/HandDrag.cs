using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Lowstone.UI
{
    public class HandDrag : MonoBehaviour, IPointerDownHandler, IDragHandler, IDropHandler
    {
        private Vector2 originalLocalPointerPosition;
        private Vector3 originalLocalPosition;
        private Quaternion originalLocalRotation;
        private Vector3 originalLocalScale;

        private RectTransform handRectTransform;

        void Awake()
        {
            handRectTransform = transform.parent as RectTransform;

        }

        public void OnPointerDown(PointerEventData data)
        {
            originalLocalPosition = transform.localPosition; originalLocalRotation = transform.localRotation;
            originalLocalScale = transform.localScale;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(handRectTransform, data.position, data.pressEventCamera, out originalLocalPointerPosition);
        }

        public void OnDrag(PointerEventData data)
        {
            if (handRectTransform == null)
                return;

            Vector2 localPointerPosition;
            if (RectTransformUtility.ScreenPointToLocalPointInRectangle(handRectTransform, data.position, data.pressEventCamera, out localPointerPosition))
            {
                Vector3 offsetToOriginal = localPointerPosition - originalLocalPointerPosition;
                transform.localPosition = originalLocalPosition + offsetToOriginal;
                transform.localRotation = Quaternion.Euler(Vector3.zero);
                transform.localScale = originalLocalScale * 1.5f;
            }
        }

        public void OnDrop(PointerEventData data)
        {
            if (data.pointerDrag != null)
            {
                //Debug.Log(transform.localPosition);
                if (transform.localPosition.y < handRectTransform.sizeDelta.y / 2)
                {
                    // if in hand zone, return to original position
                    transform.localPosition = originalLocalPosition;
                    transform.localRotation = originalLocalRotation;
                    transform.localScale = originalLocalScale;
                }
            } else
            {
                //otherwize, use it.
                UICard card = GetComponent<UICard>();
                if (card != null)
                    UIManager.Instence.PlayerUseCard(card);
            }
        }
    }
}