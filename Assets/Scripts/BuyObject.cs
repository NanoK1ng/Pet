using UnityEngine;


public class BuyObject : MonoBehaviour
{
    public int Price;

    public enum ObjectsToBuy
    {
        Arch, Wheel, Wall1, Wall2, Wall3, Wall4, Wall5, Wall6, Wall7,
        Ball1, Ball2, Ball3, Ball4, Ball5, Ball6, Circle1, Circle2,
        Circle3, Circle4, Circle5, Circle6, Pipe, Home, Watchtower,
        Maze,
    }

    public ObjectsToBuy Obj;

    public void OnMouseDown()
    {

        if (Game.Instance.Money.Coins >= Price && !CheckObject(Obj))
        {
            Game.Instance.Money.Coins -= Price;
            gameObject.SetActive(false);
            ObjectBuyed(Obj);
            Game.Instance.Save();
            Game.Instance.Money.SaveToFile();


        }
    }

    public bool CheckObject(ObjectsToBuy obj)
    {
        bool isPurchased = false;
        PurchasedObjects.Instance.PurchasedDict.TryGetValue(obj, out isPurchased);
        return isPurchased;

    }

    public void ObjectBuyed(ObjectsToBuy obj) => PurchasedObjects.Instance.PurchasedDict[obj] = true;
}
