using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjectColor : MonoBehaviour
{
    [SerializeField] private Material chaMaterial; // Material a cambiar
    [SerializeField] private Material defMaterial; //Material default

    bool hasChanged = false; //Bool sobre si ha cambiado el objeto de textura.
    
    public ManageObjects MO; //Ref al ManageObjects
    public List<MeshRenderer> renders = new List<MeshRenderer>(); //Lista para almacenar los renders de cada obj en MO.

    private void Start()
    { //Referencias a componentes
        MO = gameObject.GetComponent<ManageObjects>();
    }

    public void HandleColor() //Metodo que se llama desde change Color
    {       
        CheckObjects(); //Checkee que objetos se cambiara el color
        foreach (MeshRenderer render in renders) //Para cada render
        {
            if (!hasChanged) ChangeColor(render); //si no se han cambiado todos siga cambiando colores.
            else RevertColor(render); //Si ya se cambio y se preciona denuevo el boton, regreselos al original.
        }
        hasChanged = !hasChanged;
    }
     void CheckObjects()
     {    
        renders.Clear(); //Limpie la lista de Renders antes de agregarlos
        foreach (GameObject obj in MO.objects) //agregue solo los rendes de los objetos dentro de MO
        {
            renders.Add(obj.GetComponent<MeshRenderer>());
        }
     }

    //Fucionar estos 2 metodos en una sola cosa para el principio de extender sin modificar
    void ChangeColor(MeshRenderer render)
    {
        render.material = chaMaterial;
    }
    void RevertColor(MeshRenderer render)
    {
        render.material = defMaterial;

    }

}
