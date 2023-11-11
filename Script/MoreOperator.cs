using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*        int x = 1;
                int y = 2;
                //bool result = x == y;
                //bool result = x != y;

                string playername = null;
                //bool result = playername != null;

                int nextLevelXP = 300;
                int PlayerOneXP = 185;
                //bool result = nextLevelXP > PlayerOneXP;

                int level = 5;
                int levelcap = 20;
                //bool result = level < levelcap;

                int point = 100;
                int highscore = 100;
                bool result = !(point >= highscore);
                Debug.Log(result);*/

        int coins = 100;
        int totallives = 13;
        int maxlives = 10;
        bool ispremium = false;

        //bool shouldincreaselifecount = coins >= 100 && totallives <= maxlives || ispremium;
        bool shouldincreasedifficult = !ispremium && totallives > 5;
        Debug.Log(shouldincreasedifficult);



        string firstname = null;
        bool isUpperCase = firstname != null && firstname.ToUpper() == "Dipo Pratomo";
        //Debug.Log(isUpperCase);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
