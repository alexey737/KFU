// TASK 1
string GetAction(TrafficLight light)
{
    switch(light)
    {
        case TrafficLight.Red:
            return "stop";
        case TrafficLight.Yellow:
            return "wait";
        case TrafficLight.Green:
            return "go";
        default:
            return "unknown signal";
    }
   
}


//TASK 2

string GetOrderMessage(OrderStatus status)
{
    switch(status)
    {
        case OrderStatus.New:
            return "Заказ создан";
        case OrderStatus.Paid:
            return "Заказ оплачен, собирается";
        case OrderStatus.Sent:
            return "";
        case OrderStatus.Delivered:
            return "заказ доставлен";
        default:
            return "неизвестный статус";
    }
}



enum OrderStatus { New, Paid, Sent, Delivered  }

enum TrafficLight { Red, Yellow, Green }


