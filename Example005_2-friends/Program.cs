// Console.Clear();

int firstFriendSpeed = 3,
    secondFriendSpeed = 2,
    dogSpeed = 7,
    count = 0;

double distance = 25000,   
       time = 0;
bool firstFriendDirection = false;

while (distance > 2)
{
    if (firstFriendDirection)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        firstFriendDirection = true;
    }
    else
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        firstFriendDirection = false;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}

Console.WriteLine("Собака пробежит от одного друга к другому " + count + " раз");