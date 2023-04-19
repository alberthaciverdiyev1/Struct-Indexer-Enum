using Struct__Indexer__Enum.Indexer;

ListInt list1 = new ListInt(8);

list1[0] = 0;
list1[1] = 1;
list1[2] = 2;
list1[3] = 3;
list1[4] = 4;
list1[5] = 5;
list1[6] = 6;
list1[7] = 7;

list1.ShowOnConsole(9);     //contains metodunu ekrana cicarmaq ucun ShowOnConsole yazdim
list1.Sum();
//list1.Remove(7);
list1.ShowOnConsole(7);
Console.WriteLine(list1.ToString());

list1.RemoveRange(1, 2, 3);

Console.WriteLine(list1.ToString());
