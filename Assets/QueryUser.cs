using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QueryUser : MonoBehaviour {
    public Text ErrorTxt;

    public Text thevalue;
    public GameObject thingyMcThingyface;
    public Text uskill1, uskill2, uskill3;
    public GameObject bar1, bar2, bar3;
    public float height1, height2, height3;
    public Text phone, email, github, twitter;
    public Text user, role;
    public Text status;
    public Text thing1, thing2, thing3, thing4, thing5;
    public Image pic;

    public User usr;



    int lolcount;

    public void BOOP() {
        try {
            usr = GameObject.Find(thevalue.text).GetComponent<User>();
        } catch (System.Exception) {
            ErrorTxt.text = "Invalid User";
            ErrorTxt.color = Color.red;
            return;
            throw;
        }

        //if(lolcount >= 1) {
        //    bar1.transform.position = new Vector3(bar1.transform.position.x, bar1.transform.position.y, bar1.transform.position.z + height1);
        //    bar2.transform.position = new Vector3(bar2.transform.position.x, bar2.transform.position.y, bar2.transform.position.z + height2);
        //    bar3.transform.position = new Vector3(bar3.transform.position.x, bar3.transform.position.y, bar3.transform.position.z + height3);
        //}
        //lolcount++;
        


        ErrorTxt.text = "Authentication Successful";
        ErrorTxt.color = Color.green;

        uskill1.text = usr.skill1;
        uskill2.text = usr.skill2;
        uskill3.text = usr.skill3;

        height1 = usr.height1;
        height2 = usr.height2;
        height3 = usr.height3;

        //bar1.transform.position = new Vector3(bar1.transform.position.x, bar1.transform.position.y, bar1.transform.position.z - height1);
        //bar2.transform.position = new Vector3(bar2.transform.position.x, bar2.transform.position.y, bar2.transform.position.z - height2);
        //bar3.transform.position = new Vector3(bar3.transform.position.x, bar3.transform.position.y, bar3.transform.position.z - height3);


        phone.text = usr.phone;
        email.text = usr.email;
        github.text = usr.github;
        twitter.text = usr.twitter;
        user.text = usr.user;
        role.text = usr.role;
        status.text = usr.status;
        thing1.text = usr.thing1;
        thing2.text = usr.thing2;
        thing3.text = usr.thing3;
        thing4.text = usr.thing4;
        thing5.text = usr.thing5;
        pic.sprite = usr.pic;

        thingyMcThingyface.SetActive(true);


    }
}
