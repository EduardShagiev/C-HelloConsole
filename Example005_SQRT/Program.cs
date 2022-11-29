//ts - check
Console.WriteLine("Enter number:");
string number = Console.ReadLine()?? "";
int num = Convert.ToInt32(number);
string[] week = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
Console.WriteLine(week[num - 1]);
