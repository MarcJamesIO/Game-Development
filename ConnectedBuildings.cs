using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Group ID idea - everytime a building is built, a group ID is created and assigned to that building.

//If other buildings are connected to the new building,the new building just inherits the groups ID.

//If no other buildings ar econnected, a new group ID is created.

//Any buildings with that ID get added to a group list.

//Buildings then look inside their current group to see if resources are connected ie. within their group.

public class ConnectedBuildings : MonoBehaviour
{
    FacilitiesManager fcm; //Wehere the current total number of groups and groupID's are tracked.

    BoxCollider box;

    public int groupID;       

    private void Awake()
    {
        fcm = GameObject.Find("Manager_Facilities").GetComponent<FacilitiesManager>();
        box = GetComponent<BoxCollider>();
    }

    public void ShrinkBoxCollider()
    {
        box.size = new Vector3(10,10,10);
    }

    public void ExpandBoxCollider()
    {
        box.size = new Vector3(25, 25, 25);
    }

}
