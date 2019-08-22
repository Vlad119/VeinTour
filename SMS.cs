using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMS : MonoBehaviour
{
 
    public void SMS_open()
    {
        Application.OpenURL("mailto:" + "rasodallas@gmail.com" + "?subject=Email&body=");
    }

    public string msg = @"Заказать трансфер: Трансфер из аэропорта Вены&body=Закажите Ваш трансфер из аэропорта Вены на комфортабельном автомобиле. 
Цена 32 Евро.
Для данного заказа просим Вас ответить на несколько вопросов.
Ваше имя:
Номер рейса:
Дата:
Номер телефона:
Ваши пожелания, если таковые имеются:
Если у Вас возникнут вопросы, пожалуйста, напишите нам и мы c радостью ответим.
С уважением, Paco Даллас
AustriaDay 
Raso Dallas 
M&B Driver Mietwagen Ltd.";

    public void MessageMail()
    {
        Application.OpenURL("mailto:" + "rasodallas@gmail.com" + "?subject="+msg);
    }
}
