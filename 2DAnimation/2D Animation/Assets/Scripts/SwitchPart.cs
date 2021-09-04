using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.U2D.Animation;
using UnityEngine.UI;

namespace CaiporaGames
{
    public class SwitchPart : MonoBehaviour
    {
        [SerializeField] BodyParts[] bodyParts;//we can set a group of bodies parts. Ex: superior part: head, neck. Medium partt: arms, body, low partes: legs
        [SerializeField] string[] labels;//This will hold the labels A, B and C.

        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; i < bodyParts.Length; i++)
            {
                bodyParts[i].Init(labels);
            }
        }
    }

    [System.Serializable]
    public class BodyParts
    {
        [SerializeField] Button button;//The button we can press to change the sprite. We can put some trigger here?????
        [SerializeField] SpriteResolver[] spriteResolver;//We can set differents sprites reoslvers and more then one sprite resolver
        public int id;

        public SpriteResolver[] SpriteResolver { get => spriteResolver; }

        //method to init the button callback
        public void Init(string[] labels)//This method will be called by the button. I think we can use this to change bodies parts wintohot the button?????
        {
            button.onClick.AddListener(delegate { SwitchParts(labels); });
        }

        //method that are going to be triggered by the button, and it will switch the sprites of each resolver list.
        public void SwitchParts(string[] labels)//This will change the id of
        {
            id++;
            id = id % labels.Length;//This is used to this particular example. This makes that the selectiong is always possible. It can not run out of index

            foreach (var item in spriteResolver)
            {
                Debug.Log(item.GetCategory() + " " + labels[id] + " " + id);
                item.SetCategoryAndLabel(item.GetCategory(), labels[id]);//Sets a category. Ex: Head, and the label ex: A
            }
        }
    }
}