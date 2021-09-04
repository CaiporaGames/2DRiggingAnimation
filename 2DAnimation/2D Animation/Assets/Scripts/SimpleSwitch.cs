using UnityEngine;
using UnityEngine.Experimental.U2D.Animation;


public class SimpleSwitch : MonoBehaviour
{
    [SerializeField] BodyParts[] bodyParts;
    [SerializeField] string[] labels;  

    private void Update()
    {
        bodyParts[0].SimpleSwitch(labels);
    }
}

[System.Serializable]
public class BodyParts
{
    
    [SerializeField] SpriteResolver[] spriteResolver;

    public void SimpleSwitch(string[] labels)
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            spriteResolver[0].SetCategoryAndLabel(spriteResolver[0].GetCategory(), labels[1]);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            spriteResolver[0].SetCategoryAndLabel(spriteResolver[0].GetCategory(), labels[0]);

        }
    }   
}
