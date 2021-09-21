using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjectColor : MonoBehaviour
{
    // Update is called once per frame
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private Material highlightMaterial;
    public Material dMaterial;

    MeshRenderer selectionRenderer;
    GameObject selection;
    private GameObject _selection;


    private void Awake()
    {
        dMaterial = gameObject.GetComponent<Renderer>().material;
        selectionRenderer = gameObject.GetComponent<MeshRenderer>();
    }
    void Update()
    {
        if (_selection != null)
        {
            selectionRenderer.material = dMaterial;
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            selection = hit.transform.gameObject;
            if (selection.CompareTag(selectableTag))
            {
                var selectionRenderer = selection.GetComponent<MeshRenderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlightMaterial;
                }
                _selection = selection;
            }
            if (selection.CompareTag("SelectableExit"))
            {
                var selectionRenderer = selection.GetComponent<MeshRenderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlightMaterial;
                }
                _selection = selection;
            }
        }
    }
}
