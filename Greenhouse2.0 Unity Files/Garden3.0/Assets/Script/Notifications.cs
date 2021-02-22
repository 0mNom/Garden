using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



namespace Assets.SimpleAndroidNotifications
{ 
    public class Notifications : MonoBehaviour
    {
        public ClickToPlant click, click1, click2;
    void Start()
    {
            sendNotif();
            sendNotif24h();
    }

    // Update is called once per frame
    void Update()
    {
        if (click.sendN)
            {
                sendNotifPlantfinished();
                click.sendN = false;
            }
            if (click1.sendN)
            {
                sendNotifPlantfinished();
                click1.sendN = false;
            }
            if (click2.sendN)
            {
                sendNotifPlantfinished();
                click2.sendN = false;
            }
        }

        public void sendNotif()
        {
            NotificationManager.Send(TimeSpan.FromSeconds(5), "BoopBoop", "this is your garden speaking, thank you for coming to see me ", Color.green, NotificationIcon.Star);
        }

        public void sendNotifPlantfinished()
        {
            NotificationManager.Send(TimeSpan.FromSeconds(0.5), "I'm Done!", "Your Plant has finisihed growing, come take a look", Color.green, NotificationIcon.Star);
        }

        public void sendNotif24h()
        {
            NotificationManager.Send(TimeSpan.FromHours(24), "I'm Thirsty", "have you thought about watering your plants?", Color.green, NotificationIcon.Star);
        }


    }
}
