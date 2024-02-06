DateTime days = DateTime.Now;
string[] weekDays = new string[7];
for (int i = 0; i < weekDays.Length; i++)
{
    weekDays[i] = string.Format("{0:dddd}", days.AddDays(i-1));
    Console.WriteLine(weekDays[i]);
    days = DateTime.Now;
}
