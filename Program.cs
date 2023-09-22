//AX = 3; // Väljer C
//AY = 4; // Väljer A
//AZ = 8; // Väljer B

//BX = 1; // Väljer A
//BY = 5; // Väljer B
//BZ = 9; // Väljer C

//CX = 2; // Väljer B
//CY = 6; // Väljer C
//CZ = 7; // Väljer A

/*
int tot = 0;

foreach (string item in list)
{

    switch (item)
    {
        case "A X":
            tot += 3;
            break;

        case "A Y":
            tot += 4;
            break;

        case "A Z":
            tot += 8;
            break;

        case "B X":
            tot += 1;
            break;

        case "B Y":
            tot += 5;
            break;

        case "B Z":
            tot += 9;
            break;

        case "C X":
            tot += 2;
            break;

        case "C Y":
            tot += 6;
            break;

        case "C Z":
            tot += 7;
            break;

    }
}

Console.WriteLine(tot);
*/



string[] list = File.ReadAllLines("../../../data.txt");

string[] combos = new string[] { "B X", "C X", "A X", "A Y", "B Y", "C Y", "C Z", "A Z", "B Z" }; // Different combos, 1 to 9 points
int[] point = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

int sum = 0;


foreach (string item in list)   //läser in data.txt kollar rad för rad
{
    for (int i = 0; i < 9; i++) // kör loopen 8 ggr
    {
        if (combos[i] == item)  // Jämnför "combo index 0" == data.txt OM den är det----->
        {
            sum += point[i]; // Lägger till poängen i sum, från "point! array.

        }
    }
}


Console.WriteLine(sum);





/*

int tot = 0;

for (int i = 0; i < list.Length; i++)
{
    if (list[i] == "A X")
    {
        tot += 3;
    }
    if (list[i] == "A Y")
    {
        tot += 4;
    }
    if (list[i] == "A Z")
    {
        tot += 8;
    }
    if (list[i] == "B X")
    {
        tot += 1;
    }
    if (list[i] == "B Y")
    {
        tot += 5;
    }
    if (list[i] == "B Z")
    {
        tot += 9;
    }
    if (list[i] == "C X")
    {
        tot += 2;
    }
    if (list[i] == "C Y")
    {
        tot += 6;
    }
    if (list[i] == "C Z")
    {
        tot += 7;
    }
}

Console.WriteLine(tot); // 12408

*/